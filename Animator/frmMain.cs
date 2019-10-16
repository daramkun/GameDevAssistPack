using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GameDevAssistPack.Ani;
using GameDevAssistPack.Common;
using GameDevAssistPack;
using System.IO;
using System.Drawing.Imaging;

namespace Animator
{
	public partial class frmMain : Form
	{
		AniManager manager = new AniManager();
		int selFrameMode = -1;
		int selFrame = -1;
		int selObj = -1;

		bool isClick = false;
		bool isRClick = false;

		bool isAnchorMode = false;

		float MagX = 1;

		Point point = new Point();

		public int SelectedFrameMode
		{
			get { return selFrameMode; }
			set 
			{
				selFrameMode = value; 
				selFrame = -1;
				lstFrame.Enabled = (selFrameMode != -1) ? true : false;
			}
		}

		public int SelectedFrame
		{
			get { return selFrame; }
			set { selFrame = value; selObj = -1; }
		}

		public int SelectedUsingObject
		{
			get { return selObj; }
			set { selObj = value; }
		}

		public bool CheckSelectFrameMode()
		{
			if (SelectedFrameMode == -1)
			{
				MessageBox.Show("프레임모드를 활성화 해주세요.");
				return false;
			}
			else
				return true;
		}

		public bool CheckSelectFrame()
		{
			if (SelectedFrame == -1)
			{
				MessageBox.Show("프레임을 활성화 해주세요.");
				return false;
			}
			else
				return true;
		}

		public bool CheckFrameMode()
		{
			if (lstFrameMode.FocusedItem != null)
				return true;
			else
			{
				MessageBox.Show("리스트에서 프레임모드를 선택해주세요.");
				return false;
			}
		}

		public bool CheckFrame()
		{
			if (lstFrame.FocusedItem != null)
				return true;
			else
			{
				MessageBox.Show("리스트에서 프레임을 선택해주세요.");
				return false;
			}
		}

		public bool CheckObject()
		{
			if (lstObject.FocusedItem != null)
				return true;
			else
			{
				MessageBox.Show("리스트에서 객체를 선택해주세요.");
				return false;
			}
		}

		public bool CheckUsingObject()
		{
			if (lstUsingObject.FocusedItem != null)
				return true;
			else
			{
				MessageBox.Show("리스트에서 사용중인 객체를 선택해주세요.");
				return false;
			}
		}

		public int GetAniWidth
		{
			get 
			{
				return manager.FrameMode[SelectedFrameMode].Size.Width;
			}
		}

		public int GetAniHeight
		{
			get
			{
				return manager.FrameMode[SelectedFrameMode].Size.Height;
			}
		}

		public frmMain()
		{
			InitializeComponent();
			SelectedFrameMode = -1;
		}

		public frmMain(string file)
		{
			InitializeComponent();
			manager = new AniManager();
			AniFile.Loading(ref manager, file);
			SelectedFrameMode = -1;
			RefreshObjectList();
			RefreshFrameModeList();
			RefreshFrameList();
			RefreshUsingObject();
		}

		public void RefreshObjectList()
		{
			lstObject.Items.Clear();

			foreach(AniObj obj in manager.Object)
			{
				int index = 0;
				switch(obj.ObjectType)
				{
					case ObjType.Image:
						index = 0;
						break;
					case ObjType.Sound:
						index = 1;
						break;
					case ObjType.AssultPoint:
						index = 2;
						break;
					case ObjType.DamagePoint:
						index = 3;
						break;
				}
				lstObject.Items.Add(obj.Name, index);
			}
		}

		public void RefreshFrameModeList()
		{
			lstFrameMode.Items.Clear();

			int c = 0;

			foreach(AniFrameMode mode in manager.FrameMode)
			{
				lstFrameMode.Items.Add(mode.Name);
				if (c == SelectedFrameMode)
					lstFrameMode.Items[c].Font = new Font("맑은 고딕", 8, FontStyle.Bold);
			}
		}

		public void RefreshFrameList()
		{
			lstFrame.Items.Clear();

			if (SelectedFrameMode == -1) return;
			int count = manager.FrameMode[SelectedFrameMode].Count;
			int c = 0;

			for (int i = 0; i < count; i++)
			{
				lstFrame.Items.Add(String.Format("{0:0000}", (i + 1)), 0);
				if (c == SelectedFrame)
					lstFrame.Items[c].Font = new Font("맑은 고딕", 8, FontStyle.Bold);
			}
		}

		public void RefreshUsingObject()
		{
			lstUsingObject.Items.Clear();

			if (SelectedFrameMode == -1) return;
			if (SelectedFrame == -1) return;

			foreach(AniFrmObj obj in manager.FrameMode[SelectedFrameMode][SelectedFrame])
			{
				int index = 0;
				switch (manager.Object[obj.Index].ObjectType)
				{
					case ObjType.Image:
						index = 0;
						break;
					case ObjType.Sound:
						index = 1;
						break;
					case ObjType.AssultPoint:
						index = 2;
						break;
					case ObjType.DamagePoint:
						index = 3;
						break;
				}

				lstUsingObject.Items.Add(manager.Object[obj.Index].Name, index);
			}
		}

		public void FileNew()
		{
			AniFile.FileNew(ref manager);
			this.Text = Library.GetTitle("Untitled.bdani", Project.Animation);
			SelectedFrameMode = -1;

			RefreshObjectList();
			RefreshFrameModeList();
			RefreshFrameList();
			RefreshUsingObject();
		}

		public void FileOpen()
		{
			AniFile.FileOpen(ref manager);
			this.Text = Library.GetTitle(Library.GetFileName(AniFile.SavePath), Project.Animation);
			SelectedFrameMode = -1;

			RefreshObjectList();
			RefreshFrameModeList();
			RefreshFrameList();
			RefreshUsingObject();
		}

		public void FileSave()
		{
			if(!AniFile.FileSave(ref manager)) return;
			this.Text = Library.GetTitle(Library.GetFileName(AniFile.SavePath), Project.Animation);
		}

		public void FileSaveAs()
		{
			if(!AniFile.FileSaveAs(ref manager)) return;
			this.Text = Library.GetTitle(Library.GetFileName(AniFile.SavePath), Project.Animation);
		}

		public void AddObject()
		{
			if (new frmAddObj(ref manager).ShowDialog() == DialogResult.Cancel) return;
			AniFile.SaveOK = false;
			RefreshObjectList();
		}

		public void ModifyObject()
		{
			if (!CheckObject()) return;
			if (new frmModifyObj(ref manager, lstObject.FocusedItem.Index).ShowDialog() == DialogResult.Cancel) return;
			AniFile.SaveOK = false;
			RefreshObjectList();
		}

		public void RemoveObject()
		{
			if (!CheckObject()) return;
			manager.Object.RemoveAt(lstObject.FocusedItem.Index);
			AniFile.SaveOK = false;
			RefreshObjectList();
		}

		public void AddFrameMode()
		{
			if (new frmAddFm(ref manager).ShowDialog() == DialogResult.Cancel) return;
			AniFile.SaveOK = false;
			RefreshFrameModeList();
		}

		public void ModifyFrameMode()
		{
			if (!CheckFrameMode()) return;
			if (new frmModifyFm(ref manager, lstFrameMode.FocusedItem.Index).ShowDialog() == DialogResult.Cancel) return;
			AniFile.SaveOK = false;
			RefreshFrameModeList();
		}

		public void RemoveFrameMode()
		{
			if (!CheckFrameMode()) return;
			manager.FrameMode.RemoveAt(lstFrameMode.FocusedItem.Index);
			AniFile.SaveOK = false;
			SelectedFrameMode = -1;
			RefreshFrameModeList();
		}

		public void AddFrame()
		{
			if (!CheckSelectFrameMode()) return;
			manager.FrameMode[SelectedFrameMode].AddFrame();
			AniFile.SaveOK = false;
			RefreshFrameList();
		}

		public void RemoveFrame()
		{
			if (!CheckSelectFrameMode()) return;
			if (!CheckFrame()) return;
			manager.FrameMode[SelectedFrameMode].RemoveFrame(lstFrame.FocusedItem.Index);
			SelectedFrame = -1;
			AniFile.SaveOK = false;
			RefreshFrameList();
		}

		public void FrameModeSelect()
		{
			if (!CheckFrameMode()) return;
			if (SelectedFrameMode != -1)
				lstFrameMode.Items[SelectedFrameMode].Font = new Font("맑은 고딕", 8);
			SelectedFrameMode = lstFrameMode.FocusedItem.Index;
			lstFrameMode.Items[SelectedFrameMode].Font = new Font("맑은 고딕", 8, FontStyle.Bold);
			RefreshFrameList();
		}

		public void FrameSelect()
		{
			if (!CheckSelectFrameMode()) return;
			if (!CheckFrame()) return;
			if (SelectedFrame != -1)
				lstFrame.Items[SelectedFrame].Font = new Font("맑은 고딕", 8);
			SelectedFrame = lstFrame.FocusedItem.Index;
			lstFrame.Items[SelectedFrame].Font = new Font("맑은 고딕", 8, FontStyle.Bold);
			RefreshUsingObject();
			picEdit.Refresh();
		}

		public void ObjectSelect()
		{
			if (!CheckSelectFrameMode()) return;
			if (!CheckSelectFrame()) return;
			int w = 20, h = 20;
			if (manager.Object[lstObject.FocusedItem.Index].ObjectType == ObjType.Image)
			{
				MemoryStream memStream = new MemoryStream(manager.Object[lstObject.FocusedItem.Index].Data);
				Image image = Image.FromStream(memStream);
				w = image.Width;
				h = image.Height;
				image.Dispose();
				memStream.Dispose();
			}
			manager.FrameMode[SelectedFrameMode][SelectedFrame].AddUseObject(lstObject.FocusedItem.Index, w, h);
			AniFile.SaveOK = false;
			RefreshUsingObject();
			picEdit.Refresh();
		}

		public void DrawFrame(int frame, float startX, float startY, PaintEventArgs e)
		{
			foreach (AniFrmObj obj in manager.FrameMode[SelectedFrameMode][frame])
			{
				switch (manager.Object[obj.Index].ObjectType)
				{
					case ObjType.Image:
						MemoryStream memStream = new MemoryStream(manager.Object[obj.Index].Data);
						Image img = Image.FromStream(memStream);
						ImageAttributes imageAttr = new ImageAttributes();
						ColorMap[] colorMap = new ColorMap[1];
						colorMap[0] = new ColorMap();
						colorMap[0].OldColor = manager.Object[obj.Index].TransparentColor;
						colorMap[0].NewColor = Color.Transparent;
						imageAttr.SetRemapTable(colorMap, ColorAdjustType.Bitmap);

						e.Graphics.DrawImage(img, new Rectangle((int)startX + (int)(obj.Location.X * MagX), (int)startY + (int)(obj.Location.Y * MagX),
							(int)(obj.Size.Width * MagX), (int)(obj.Size.Height * MagX)), 
							0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imageAttr);
						e.Graphics.DrawRectangle(new Pen(Color.Brown), new Rectangle((int)startX + (int)(obj.Location.X * MagX),
							(int)startY + (int)(obj.Location.Y * MagX), (int)(obj.Size.Width * MagX), 
							(int)(obj.Size.Height * MagX)));
						break;
					case ObjType.AssultPoint:
						e.Graphics.DrawRectangle(new Pen(Color.Red),
							startX + (int)(obj.Location.X * MagX), (int)startY + (int)(obj.Location.Y * MagX), obj.Size.Width * MagX, obj.Size.Height * MagX);
						break;
					case ObjType.DamagePoint:
						e.Graphics.DrawRectangle(new Pen(Color.Blue),
							startX + (int)(obj.Location.X * MagX), (int)startY + (int)(obj.Location.Y * MagX), obj.Size.Width * MagX, obj.Size.Height * MagX);
						break;
				}
			}
		}

		public void SpeedChange()
		{
			new frmSpeed(ref manager).ShowDialog();
			AniFile.SaveOK = false;
		}

		public void RunAnimation()
		{
			if (!CheckSelectFrameMode()) return;
			new frmAni(ref manager, SelectedFrameMode).ShowDialog();
		}

		public void ModifyUsingObject()
		{
			if (!CheckUsingObject()) return;
			if(new frmModifyUsingObj(ref manager, SelectedFrameMode, SelectedFrame,
				lstUsingObject.FocusedItem.Index).ShowDialog() == DialogResult.Cancel) return;
			AniFile.SaveOK = false;
			RefreshUsingObject();
		}

		public void SetAnchorPoint()
		{
			isAnchorMode = true;
		}

		//-----------------------------------------------------------------------------------------------------//
		//-----------------------------------------------------------------------------------------------------//
		//-----------------------------------------------------------------------------------------------------//
		//-----------------------------------------------경계선-----------------------------------------------//
		//-----------------------------------------------------------------------------------------------------//
		//-----------------------------------------------------------------------------------------------------//

		private void mnuAddObject_Click(object sender, EventArgs e)
		{
			AddObject();
		}

		private void mnuRemoveObject_Click(object sender, EventArgs e)
		{
			RemoveObject();
		}

		private void mnuAddFrameMode_Click(object sender, EventArgs e)
		{
			AddFrameMode();
		}

		private void mnuRemoveFrameMode_Click(object sender, EventArgs e)
		{
			RemoveFrameMode();
		}

		private void mnuAddFrame_Click(object sender, EventArgs e)
		{
			AddFrame();
		}

		private void mnuRemoveFrame_Click(object sender, EventArgs e)
		{
			RemoveFrame();
		}

		private void lstFrameMode_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			FrameModeSelect();
		}

		private void lstFrame_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			FrameSelect();
		}

		private void lstObject_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			ObjectSelect();
		}

		private void picEdit_Resize(object sender, EventArgs e)
		{
			picEdit.Refresh();
		}

		private void mnuNew_Click(object sender, EventArgs e)
		{
			FileNew();
		}

		private void mnuOpen_Click(object sender, EventArgs e)
		{
			FileOpen();
		}

		private void mnuSave_Click(object sender, EventArgs e)
		{
			FileSave();
		}

		private void mnuSaveAs_Click(object sender, EventArgs e)
		{
			FileSaveAs();
		}

		private void mnuExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void tsNew_Click(object sender, EventArgs e)
		{
			FileNew();
		}

		private void tsOpen_Click(object sender, EventArgs e)
		{
			FileOpen();
		}

		private void tsSave_Click(object sender, EventArgs e)
		{
			FileSave();
		}

		private void tsAddFrameMode_Click(object sender, EventArgs e)
		{
			AddFrameMode();
		}

		private void tsRemoveFrameMode_Click(object sender, EventArgs e)
		{
			RemoveFrameMode();
		}

		private void tsAddFrame_Click(object sender, EventArgs e)
		{
			AddFrame();
		}

		private void tsRemoveFrame_Click(object sender, EventArgs e)
		{
			RemoveFrame();
		}

		private void tsAddObject_Click(object sender, EventArgs e)
		{
			AddObject();
		}

		private void tsRemoveObject_Click(object sender, EventArgs e)
		{
			RemoveObject();
		}

		private void tsUseObject_Click(object sender, EventArgs e)
		{
			ObjectSelect();
		}

		private void mnuModifyFrameMode_Click(object sender, EventArgs e)
		{
			ModifyFrameMode();
		}

		private void tsModifyFrameMode_Click(object sender, EventArgs e)
		{
			ModifyFrameMode();
		}

		private void mnuModifyObject_Click(object sender, EventArgs e)
		{
			ModifyObject();
		}

		private void tsModifyObject_Click(object sender, EventArgs e)
		{
			ModifyObject();
		}

		private void picEdit_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.FillRectangle(new SolidBrush(Color.Gray), new Rectangle(0, 0, picEdit.Width, picEdit.Height));

			if (SelectedFrameMode != -1 && SelectedFrame != -1)
			{
				float startX = picEdit.Width / 2 - GetAniWidth / 2 * MagX;
				float startY = picEdit.Height / 2 - GetAniHeight / 2 * MagX;

				e.Graphics.FillRectangle(new SolidBrush(Color.White), new RectangleF(startX, startY, GetAniWidth * MagX, GetAniHeight * MagX));

				if (SelectedFrame != 0)
				{
					DrawFrame(SelectedFrame - 1, startX, startY, e);
				}
				e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(120, 0xff, 0xff, 0xff)), new RectangleF(0, 0, picEdit.Width, picEdit.Height));
				DrawFrame(SelectedFrame, startX, startY, e);


				if (SelectedFrame != 0)
				{
					AniFrame lframe = manager.FrameMode[SelectedFrameMode][SelectedFrame - 1];
					e.Graphics.DrawLine(new Pen(Color.LightGray), new PointF(lframe.AnchorPoint.X + startX, lframe.AnchorPoint.Y - 5 + startY),
						new PointF(lframe.AnchorPoint.X + startX, lframe.AnchorPoint.Y + 5 + startY));
					e.Graphics.DrawLine(new Pen(Color.LightGray), new PointF(lframe.AnchorPoint.X - 5 + startX, lframe.AnchorPoint.Y + startY),
						new PointF(lframe.AnchorPoint.X + 5 + startX, lframe.AnchorPoint.Y + startY));
				}

				if (!isAnchorMode)
				{
					AniFrame frame = manager.FrameMode[SelectedFrameMode][SelectedFrame];
					e.Graphics.DrawLine(new Pen(Color.Gray), new PointF(frame.AnchorPoint.X + startX, frame.AnchorPoint.Y - 5 + startY),
						new PointF(frame.AnchorPoint.X + startX, frame.AnchorPoint.Y + 5 + startY));
					e.Graphics.DrawLine(new Pen(Color.Gray), new PointF(frame.AnchorPoint.X - 5 + startX, frame.AnchorPoint.Y + startY),
						new PointF(frame.AnchorPoint.X + 5 + startX, frame.AnchorPoint.Y + startY));
				}
				else
				{
					AniFrame frame = manager.FrameMode[SelectedFrameMode][SelectedFrame];
					e.Graphics.DrawLine(new Pen(Color.Gray), new PointF(point.X, point.Y - 5),
						new PointF(point.X, point.Y + 5));
					e.Graphics.DrawLine(new Pen(Color.Gray), new PointF(point.X - 5, point.Y),
						new PointF(point.X + 5, point.Y));
				}
			}
			else
			{
				e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(120, 0xff, 0xff, 0xff)), new RectangleF(0, 0, picEdit.Width, picEdit.Height));
			}
		}

		private void picEdit_Click(object sender, EventArgs e)
		{
			picEdit.Focus();
		}

		private void trkX_Scroll(object sender, EventArgs e)
		{
			MagX = trkX.Value * 0.2f;
			picEdit.Refresh();
		}

		private void picEdit_MouseDown(object sender, MouseEventArgs e)
		{
			int count = 0;

			if (SelectedFrameMode == -1) return;
			if (SelectedFrame == -1) return;

			AniFile.SaveOK = false;

			SelectedUsingObject = -1;

			float startX = picEdit.Width / 2 - GetAniWidth / 2 * MagX;
			float startY = picEdit.Height / 2 - GetAniHeight / 2 * MagX;

			if (isAnchorMode)
			{
				manager.FrameMode[SelectedFrameMode][SelectedFrame].AnchorPoint = new Point(e.X - (int)startX, e.Y - (int)startY);
				picEdit.Refresh();
				isAnchorMode = false;
				return;
			}
			
			foreach (AniFrmObj obj in manager.FrameMode[SelectedFrameMode][SelectedFrame])
			{
				if (e.X - startX <= obj.Location.X + obj.Size.Width && obj.Location.X <= e.X - startX + 1 &&
					e.Y - startY <= obj.Location.Y + obj.Size.Height && obj.Location.Y <= e.Y - startY + 1)
				{
					SelectedUsingObject = count;
				}
				count++;
			}

			if (SelectedUsingObject == -1)
			{
				isClick = false;
				isRClick = false;
				return;
			}

			if (e.Button == MouseButtons.Left)
			{
				isClick = true;
				isRClick = false;
			}
			else if(e.Button == MouseButtons.Right)
			{
				isClick = false;
				isRClick = true;
			}

			point = new Point(e.X, e.Y);
		}

		private void picEdit_MouseMove(object sender, MouseEventArgs e)
		{
			tssCoor.Text = "마우스 좌표 : {0, 0}";

			if (SelectedFrameMode == -1) return;
			if (SelectedFrame == -1) return;

			float startX = picEdit.Width / 2 - GetAniWidth / 2 * MagX;
			float startY = picEdit.Height / 2 - GetAniHeight / 2 * MagX;

			tssCoor.Text = "마우스 좌표 : {" + (e.X - startX) + ", " + (e.Y - startY) + "}";

			if (isAnchorMode)
			{
				point = new Point(e.X, e.Y);
				picEdit.Refresh();
				return;
			}

			if (SelectedUsingObject == -1)
				ttsUObj.Text = "객체 정보 : {X, X, X, X}";
		
			if (SelectedUsingObject == -1) return;
			if (!isClick && !isRClick) return;

			AniFrmObj obj = manager.FrameMode[SelectedFrameMode][SelectedFrame][SelectedUsingObject];

			if (isClick)
			{
				int nX = obj.Location.X + (e.X - point.X);
				int nY = obj.Location.Y + (e.Y - point.Y);

				obj.Location = new Point(nX, nY);
			}
			else if(isRClick)
			{
				int nW = obj.Size.Width + (e.X - point.X);
				int nH = obj.Size.Height + (e.Y - point.Y);

				obj.Size = new Size(nW, nH);
			}
			point = new Point(e.X, e.Y);

			ttsUObj.Text = "객체 정보 : {" + obj.Location.X + ", " + obj.Location.Y + ", " + obj.Size.Width + ", " + obj.Size.Height + "}";

			manager.FrameMode[SelectedFrameMode][SelectedFrame][SelectedUsingObject] = obj;

			picEdit.Refresh();
		}

		private void picEdit_MouseUp(object sender, MouseEventArgs e)
		{
			isClick = false;
			isRClick = false;
		}

		private void mnuAniSpeed_Click(object sender, EventArgs e)
		{
			SpeedChange();
		}

		private void tsAniSpeed_Click(object sender, EventArgs e)
		{
			SpeedChange();
		}

		private void lstUsingObject_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{ 
				case Keys.Delete:
					if (!CheckUsingObject()) return;
					DialogResult dr = MessageBox.Show("정말로 지우시겠습니까?", "으릉?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					switch (dr)
					{ 
						case DialogResult.Yes:
							manager.FrameMode[SelectedFrameMode][SelectedFrame].RemoveUseObject(lstUsingObject.FocusedItem.Index);
							RefreshUsingObject();
							picEdit.Refresh();
							break;
					}
					break;
			}
		}

		private void mnuPlayWindow_Click(object sender, EventArgs e)
		{
			RunAnimation();
		}

		private void tsPlayWindow_Click(object sender, EventArgs e)
		{
			RunAnimation();
		}

		private void mnuModuleInfo_Click(object sender, EventArgs e)
		{
			new ModuleInfo().ShowDialog();
		}

		private void mnuAbout_Click(object sender, EventArgs e)
		{
			new frmAbout().ShowDialog();
		}

		private void tsModifyUsingObject_Click(object sender, EventArgs e)
		{
			ModifyUsingObject();
		}

		private void mnuModifyUseObject_Click(object sender, EventArgs e)
		{
			ModifyUsingObject();
		}

		private void mnuOption_Click(object sender, EventArgs e)
		{
			new frmOption().ShowDialog();
		}

		private void mnuAnchorPoint_Click(object sender, EventArgs e)
		{
			SetAnchorPoint();
		}

		private void tsAnchorPoint_Click(object sender, EventArgs e)
		{
			SetAnchorPoint();
		}

		private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!AniFile.CheckSave(ref manager))
			{
				e.Cancel = true;
			}
		}

		private void picEdit_MouseLeave(object sender, EventArgs e)
		{
			isAnchorMode = false;
			isClick = false;
			isRClick = false;
		}
	}
}
