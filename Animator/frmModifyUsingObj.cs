using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GameDevAssistPack.Ani;

namespace Animator
{
	public partial class frmModifyUsingObj : Form
	{
		AniManager manager;
		int selFm;
		int selF;
		int selUobj;

		public frmModifyUsingObj(ref AniManager manager, int SelFm, int SelF, int SelU)
		{
			InitializeComponent();
			this.manager = manager;
			selFm = SelFm;
			selF = SelF;
			selUobj = SelU;

			numIndex.Maximum = manager.Object.Count;
			numIndex.Value = manager.FrameMode[selFm][selF][selUobj].Index;
			numLocationX.Value = manager.FrameMode[selFm][selF][selUobj].Location.X;
			numLocationY.Value = manager.FrameMode[selFm][selF][selUobj].Location.Y;
			numSizeW.Value = manager.FrameMode[selFm][selF][selUobj].Size.Width;
			numSizeH.Value = manager.FrameMode[selFm][selF][selUobj].Size.Height;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void btnModify_Click(object sender, EventArgs e)
		{
			manager.FrameMode[selFm][selF][selUobj].Index = (int)numIndex.Value;
			manager.FrameMode[selFm][selF][selUobj].Location = new Point((int)numLocationX.Value, (int)numLocationY.Value);
			manager.FrameMode[selFm][selF][selUobj].Size = new Size((int)numSizeW.Value, (int)numSizeH.Value);

			DialogResult = DialogResult.OK;
			this.Close();
		}

		private void btnView_Click(object sender, EventArgs e)
		{
			frmMOShow sh = new frmMOShow(ref manager);
			if (sh.ShowDialog() == DialogResult.Cancel) return;
			numIndex.Value = sh.SelectedIndex;
		}
	}
}
