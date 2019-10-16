using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GameDevAssistPack.Ani;
using System.IO;

namespace Animator
{
	public partial class frmMOShow : Form
	{
		AniManager manager;
		int selIndex = 0;

		public int SelectedIndex
		{
			get { return selIndex; }
			set { selIndex = value; }
		}

		public frmMOShow(ref AniManager manager)
		{
			InitializeComponent();
			this.manager = manager;

			foreach (AniObj obj in manager.Object)
			{
				lstObjs.Items.Add(obj.Name);
			}
		}

		private void lstObjs_SelectedIndexChanged(object sender, EventArgs e)
		{
			picImage.Refresh();
		}

		private void lstObjs_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (lstObjs.FocusedItem == null) return;
			SelectedIndex = lstObjs.FocusedItem.Index;
			DialogResult = DialogResult.OK;
			this.Close();
		}

		private void picImage_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = Graphics.FromHwnd(picImage.Handle);
			g.Clear(Color.White);

			if (lstObjs.FocusedItem == null) return;

			switch (manager.Object[lstObjs.FocusedItem.Index].ObjectType)
			{
				case ObjType.Image:
					MemoryStream memStream = new MemoryStream(manager.Object[lstObjs.FocusedItem.Index].Data);
					Image image = Image.FromStream(memStream);
					picImage.Image = image;
					break;
				case ObjType.AssultPoint:
				case ObjType.DamagePoint:
					g.DrawString("충돌 포인트", new Font("맑은 고딕", 8), new SolidBrush(Color.Black), new Point(5, 5));
					break;
				case ObjType.Sound:
					g.DrawString("사운드 파일", new Font("맑은 고딕", 8), new SolidBrush(Color.Black), new Point(5, 5));
					break;
			}
		}
	}
}
