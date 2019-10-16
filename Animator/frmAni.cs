using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GameDevAssistPack.Ani;
using System.IO;
using System.Drawing.Imaging;

namespace Animator
{
	public partial class frmAni : Form
	{
		AniManager manager;
		int SelectedFrameMode;

		int frame;

		public frmAni(ref AniManager manager, int selFm)
		{
			InitializeComponent();
			this.manager = manager;
			SelectedFrameMode = selFm;
			tmrRun.Interval = manager.Speed;
			frame = 0;
		}

		private void tmrRun_Tick(object sender, EventArgs e)
		{
			Graphics graphics = Graphics.FromHwnd(picPlay.Handle);

			int startX = picPlay.Width / 2 - manager.FrameMode[SelectedFrameMode].Size.Width / 2;
			int startY = picPlay.Height / 2 - manager.FrameMode[SelectedFrameMode].Size.Height / 2;

			graphics.FillRectangle(new SolidBrush(Color.LightGray), new Rectangle(0, 0, picPlay.Width, picPlay.Height));
			graphics.FillRectangle(new SolidBrush(Color.White),
				new RectangleF(startX, startY, 
					manager.FrameMode[SelectedFrameMode].Size.Width,
					manager.FrameMode[SelectedFrameMode].Size.Height));

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

						graphics.DrawImage(img, new Rectangle((int)startX + obj.Location.X, (int)startY + obj.Location.Y,
							obj.Size.Width, obj.Size.Height),
							0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imageAttr);
						break;
					case ObjType.AssultPoint:
						graphics.DrawRectangle(new Pen(Color.Red),
							startX + obj.Location.X, startY + obj.Location.Y, obj.Size.Width, obj.Size.Height);
						break;
					case ObjType.DamagePoint:
						graphics.DrawRectangle(new Pen(Color.Blue),
							startX + obj.Location.X, startY + obj.Location.Y, obj.Size.Width, obj.Size.Height);
						break;
				}
			}
			
			frame++;
			if (frame >= manager.FrameMode[SelectedFrameMode].Count)
				frame = 0;
		}
	}
}
