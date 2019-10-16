using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using GameDevAssistPack.Common;

namespace GameDevAssistPack.Ani
{
	public static class AniFile
	{
		public static bool SaveOK = true;
		public static string SavePath = "";

		public static void InitFileSys()
		{
			SaveOK = true;
			SavePath = "";
		}

		public static bool CheckSave(ref AniManager manager)
		{
			if (!AniFile.SaveOK)
			{
				DialogResult dr = MessageBox.Show("저장하시겠어요?", "질문", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
				switch (dr)
				{
					case DialogResult.Yes:
						return FileSave(ref manager);
					case DialogResult.No:
						return true;
					default:
						return false;
				}
			}
			else
				return true;
		}
		public static void FileNew(ref AniManager manager)
		{
			if (!CheckSave(ref manager)) return;

			AniFile.InitFileSys();
			manager = new AniManager();
		}

		public static void FileOpen(ref AniManager manager)
		{
			if (!CheckSave(ref manager)) return;

			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "BitDiary 애니메이터 파일(*.bdani)|*.bdani";
			ofd.Title = "애니메이터 파일 불러올 경로 선택";

			if (ofd.ShowDialog() == DialogResult.Cancel) return;

			if (!AniFile.Loading(ref manager, ofd.FileName)) return;
		}

		public static bool FileSave(ref AniManager manager)
		{
			if (AniFile.SavePath == "")
				return FileSaveAs(ref manager);

			return AniFile.Saving(manager, AniFile.SavePath, 0);
		}

		public static bool FileSaveAs(ref AniManager manager)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "BitDiary 애니메이터 파일(*.bdani)|*.bdani";
			sfd.Title = "애니메이터 파일 저장 경로 선택";

			if (sfd.ShowDialog() == DialogResult.Cancel) return false;

			if (!AniFile.Saving(manager, sfd.FileName, 0)) return false;

			return true;
		}

		public static bool Loading(ref AniManager manager, string path)
		{
			Register.ThrowException(Project.Animation);

			if (!File.Exists(path))
				return false;
			using (FileStream fs = new FileStream(path, FileMode.Open))
			{
				//try
				//{
					BinaryReader br = new BinaryReader(fs);

					if (br.ReadChar() != 'A') return false;
					if (br.ReadChar() != 'N') return false;
					byte version = br.ReadByte();

					manager = new AniManager();

					manager.Speed = br.ReadInt32();

					int modes = br.ReadInt32();
					for (int i = 0; i < modes; i++)
					{
						int namelength = br.ReadByte();
						string name = "";
						if (namelength != 0)
							name = Encoding.Default.GetString(br.ReadBytes(namelength));

						int wid, hei;
						wid = br.ReadInt32();
						hei = br.ReadInt32();
						Size size = new Size(wid, hei);

						manager.FrameMode.Add(new AniFrameMode(name, size));

						int frames = br.ReadInt32();
						for (int j = 0; j < frames; j++)
						{
							int fx, fy;
							fx = br.ReadInt32();
							fy = br.ReadInt32();
							manager.FrameMode[i].AddFrame();
							manager.FrameMode[i][j].AnchorPoint = new Point(fx, fy);
							int frmobjs = br.ReadInt32();
							for (int k = 0; k < frmobjs; k++)
							{
								int objIndex, x, y, w, h;
								objIndex = br.ReadInt32();
								x = br.ReadInt32();
								y = br.ReadInt32();
								w = br.ReadInt32();
								h = br.ReadInt32();
								manager.FrameMode[i][j].AddUseObject(objIndex, w, h);
								manager.FrameMode[i][j][k].Location = new Point(x, y);
							}
						}
					}

					modes = br.ReadInt32();
					for (int i = 0; i < modes; i++)
					{
						int namelength = br.ReadByte();
						string name = null;
						if (namelength != 0)
							name = Encoding.ASCII.GetString(br.ReadBytes(namelength));

						namelength = br.ReadByte();
						string pth = null;
						if (namelength != 0)
							pth = Encoding.ASCII.GetString(br.ReadBytes(namelength));

						byte objType = br.ReadByte();
						byte a, r, g, b;
						a = br.ReadByte();
						r = br.ReadByte();
						g = br.ReadByte();
						b = br.ReadByte();

						byte[] data = null;
						namelength = br.ReadInt32();
						if (namelength != 0)
							data = br.ReadBytes(namelength);

						manager.Object.Add(new AniObj(name, pth, (data != null) ?(byte[])data.Clone() : null, Color.FromArgb(a, r, g, b), (ObjType)objType));

					}

					br.Close();
					fs.Close();
					fs.Dispose();

					SaveOK = true;
					SavePath = path;
				//}
				//catch (Exception e)
				//{
				//	string temp = e.Message;
				//	return false;
				//}
			}

			return true;
		}

		public static bool Saving(AniManager manager, string path, byte ver)
		{
			Register.ThrowException(Project.Animation);

			if (File.Exists(path))
				File.Delete(path);
			using (FileStream fs = new FileStream(path, FileMode.CreateNew))
			{
				//try
				//{
					BinaryWriter bw = new BinaryWriter(fs);

					bw.Write('A');
					bw.Write('N');
					bw.Write((byte)ver);

					bw.Write((int)manager.Speed);

					bw.Write((int)manager.FrameMode.Count);
					for (int i = 0; i < manager.FrameMode.Count; i++)
					{
						if (manager.FrameMode[i].Name.Length != 0)
							bw.Write((string)manager.FrameMode[i].Name);
						else
							bw.Write((byte)0);

						bw.Write((int)manager.FrameMode[i].Size.Width);
						bw.Write((int)manager.FrameMode[i].Size.Height);
						
						bw.Write((int)manager.FrameMode[i].Count);
						for (int j = 0; j < manager.FrameMode[i].Count; j++)
						{
							bw.Write((int)manager.FrameMode[i][j].AnchorPoint.X);
							bw.Write((int)manager.FrameMode[i][j].AnchorPoint.Y);
							bw.Write((int)manager.FrameMode[i][j].Count);
							for (int k = 0; k < manager.FrameMode[i][j].Count; k++)
							{
								bw.Write((int)manager.FrameMode[i][j][k].Index);
								bw.Write((int)manager.FrameMode[i][j][k].Location.X);
								bw.Write((int)manager.FrameMode[i][j][k].Location.Y);
								bw.Write((int)manager.FrameMode[i][j][k].Size.Width);
								bw.Write((int)manager.FrameMode[i][j][k].Size.Height);
							}
						}
					}

					bw.Write((int)manager.Object.Count);
					for (int i = 0; i < manager.Object.Count; i++)
					{
						if (manager.Object[i].Name != null)
						{
							byte[] text = Encoding.ASCII.GetBytes(manager.Object[i].Name);
							bw.Write((byte)text.Length);
							bw.Write((byte[])text);
						}
						else
						{
							bw.Write((byte)0);
						}

						if (manager.Object[i].Path != null)
						{
							byte[] text = Encoding.ASCII.GetBytes(manager.Object[i].Path);
							bw.Write((byte)text.Length);
							bw.Write((byte[])text);
						}
						else
						{
							bw.Write((byte)0);
						}

						bw.Write((byte)manager.Object[i].ObjectType);
						bw.Write((byte)manager.Object[i].TransparentColor.A);
						bw.Write((byte)manager.Object[i].TransparentColor.R);
						bw.Write((byte)manager.Object[i].TransparentColor.G);
						bw.Write((byte)manager.Object[i].TransparentColor.B);

						if (manager.Object[i].Data != null)
						{
							bw.Write((int)manager.Object[i].Data.Length);
							bw.Write((byte[])manager.Object[i].Data);
						}
						else
						{
							bw.Write((int)0);
						}
					}

					bw.Close();
					fs.Close();
					fs.Dispose();

					SaveOK = true;
					SavePath = path;
				//}
				//catch (Exception e)
				//{
				//	string temp = e.Message;
				//	MessageBox.Show(temp);
				//	return false;
				//}
			}

			return true;
		}
	}
}