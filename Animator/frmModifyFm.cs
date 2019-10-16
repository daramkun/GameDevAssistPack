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
	public partial class frmModifyFm : Form
	{
		AniManager manager;
		int sfm = -1;

		public frmModifyFm(ref AniManager manager, int selectedFm)
		{
			InitializeComponent();
			this.manager = manager;
			sfm = selectedFm;

			txtName.Text = manager.FrameMode[sfm].Name;
			nudWidth.Value = manager.FrameMode[sfm].Size.Width;
			nudHeight.Value = manager.FrameMode[sfm].Size.Height;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (txtName.Text.Trim() == "")
			{
				MessageBox.Show("이름을 입력해주십시오.");
				return;
			}

			manager.FrameMode[sfm].Name = txtName.Text;
			manager.FrameMode[sfm].Size = new Size((int)nudWidth.Value, (int)nudHeight.Value);

			DialogResult = DialogResult.OK;
			this.Close();
		}
	}
}
