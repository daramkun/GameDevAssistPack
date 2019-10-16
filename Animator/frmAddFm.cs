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
	public partial class frmAddFm : Form
	{
		AniManager manager;

		public frmAddFm(ref AniManager manager)
		{
			InitializeComponent();
			this.manager = manager;
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

			manager.FrameMode.Add(new AniFrameMode(txtName.Text, new Size((int)nudWidth.Value, (int)nudHeight.Value)));

			DialogResult = DialogResult.OK;
			this.Close();
		}
	}
}
