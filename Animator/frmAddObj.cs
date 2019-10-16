using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GameDevAssistPack.Ani;
using System.IO;
using GameDevAssistPack.Common;

namespace Animator
{
	public partial class frmAddObj : Form
	{
		AniManager manager;

		public frmAddObj(ref AniManager manager)
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

			ObjType type = ObjType.Image;

			if (rdbAssult.Checked)
				type = ObjType.AssultPoint;
			else if (rdbDamage.Checked)
				type = ObjType.DamagePoint;
			else if (rdbImage.Checked)
				type = ObjType.Image;
			else if (rdbSound.Checked)
				type = ObjType.Sound;

			byte[] data = null;
			if (type == ObjType.Image || type == ObjType.Sound)
				data = File.ReadAllBytes(txtFile.Text);
			else
				data = null;
			
			manager.Object.Add(new AniObj(txtName.Text, txtFile.Text, data, picColor.BackColor, type));

			DialogResult = DialogResult.OK;
			this.Close();
		}

		private void rdbImage_CheckedChanged(object sender, EventArgs e)
		{
			txtFile.Enabled = btnBrowse.Enabled = picColor.Enabled = btnTransKey.Enabled = true;
		}

		private void rdbSound_CheckedChanged(object sender, EventArgs e)
		{
			txtFile.Enabled = btnBrowse.Enabled = true;
			picColor.Enabled = btnTransKey.Enabled = false;
		}

		private void rdbDamage_CheckedChanged(object sender, EventArgs e)
		{
			txtFile.Enabled = btnBrowse.Enabled = picColor.Enabled = btnTransKey.Enabled = false;
		}

		private void rdbAssult_CheckedChanged(object sender, EventArgs e)
		{
			txtFile.Enabled = btnBrowse.Enabled = picColor.Enabled = btnTransKey.Enabled = false;
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			if (rdbImage.Checked)
				ofd.Filter = "이미지 파일(*.bmp;*.jpg;*.jpeg;*.png;*.gif)|*.bmp;*.jpg;*.jpeg;*.png;*.gif";
			else
				ofd.Filter = "사운드 파일(*.mp3;*.wav;*.mid;*.ogg;*.wma)|*.mp3;*.wav;*.mid;*.ogg;*.wma";

			if (ofd.ShowDialog() == DialogResult.Cancel) return;

			if (txtName.Text == "")
				txtName.Text = Library.GetTrueFileName(ofd.FileName);
			txtFile.Text = ofd.FileName;
		}

		private void btnTransKey_Click(object sender, EventArgs e)
		{
			ColorDialog cd = new ColorDialog();
			cd.Color = picColor.BackColor;
			if (cd.ShowDialog() == DialogResult.Cancel) return;
			picColor.BackColor = cd.Color;
		}
	}
}
