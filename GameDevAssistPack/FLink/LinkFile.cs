using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace GameDevAssistPack.FLink
{
	public static class LinkFile
	{
		public static bool Loading(ref LinkManager manager, string path)
		{
			Register.ThrowException(Project.FilesLinker);

			if (!File.Exists(path))
				return false;
			using (FileStream fs = new FileStream(path, FileMode.Open))
			{
				try
				{
					BinaryReader br = new BinaryReader(fs);

					if (br.ReadChar() != 'F') return false;
					if (br.ReadChar() != 'L') return false;
					byte version = br.ReadByte();

					manager.Clear();

					int files = br.ReadInt32();
					for (int i = 0; i < files; i++)
					{
						string name = "";
						byte[] data = null;

						if (br.ReadBoolean())
						{
							name = br.ReadString();
						}

						if (br.ReadBoolean())
						{
							int length = br.ReadInt32();
							data = br.ReadBytes(length);
						}

						manager.AddFile(name, data);
					}

					br.Close();
					fs.Close();
					fs.Dispose();
				}
				catch (Exception e)
				{
					string temp = e.Message;
					return false;
				}
			}

			return true;
		}

		public static bool Saving(LinkManager manager, string path, byte version)
		{
			Register.ThrowException(Project.FilesLinker);

			if (File.Exists(path))
				File.Delete(path);
			using (FileStream fs = new FileStream(path, FileMode.CreateNew))
			{
				try
				{
					BinaryWriter bw = new BinaryWriter(fs);

					bw.Write('F');
					bw.Write('L');
					bw.Write((byte)version);

					bw.Write(manager.Count);
					for (int i = 0; i < manager.Count; i++)
					{
						if (manager[i].FileName.Length == 0)
						{
							bw.Write(false);
						}
						else
						{
							bw.Write(manager[i].FileName);
						}

						if (manager[i].Data == null || manager[i].Data.Length == 0)
						{
							bw.Write(false);
						}
						else
						{
							bw.Write(manager[i].DataSize);
							bw.Write(manager[i].Data);
						}
					}

					bw.Close();
					fs.Close();
					fs.Dispose();
				}
				catch (Exception e)
				{
					string temp = e.Message;
					return false;
				}
			}

			return true;
		}
	}
}
