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
	public partial class frmModifyObj : Form
	{
		AniManager manager;
		int objectIndex;

		public frmModifyObj(ref AniManager manager, int objIndex)
		{
			InitializeComponent();
			this.manager = manager;
			this.objectIndex = objIndex;

			txtName.Text = manager.Object[objIndex].Name;
			txtFile.Text = manager.Object[objIndex].Path;
			picColor.BackColor = manager.Object[objIndex].TransparentColor;
			switch (manager.Object[objIndex].ObjectType)
			{ 
				case ObjType.Image:
					rdbImage.Checked = true;
					break;
				case ObjType.Sound:
					rdbSound.Checked = true;
					break;
				case ObjType.DamagePoint:
					rdbDamage.Checked = true;
					break;
				case ObjType.AssultPoint:
					rdbAssult.Checked = true;
					break;
			}
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

			manager.Object[objectIndex].Name = txtName.Text;
			manager.Object[objectIndex].ObjectType = type;
			manager.Object[objectIndex].Path = txtFile.Text;
			manager.Object[objectIndex].TransparentColor = picColor.BackColor;

			if (type == ObjType.Image || type == ObjType.Sound)
				manager.Object[objectIndex].Data = File.ReadAllBytes(txtFile.Text);
			else
				manager.Object[objectIndex].Data = null;

			DialogResult = DialogResult.OK;
			this.Close();
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			if (rdbImage.Checked)
				ofd.Filter = "이미지 파일(*.bmp;*.jpg;*.jpeg;*.png;*.gif)|*.bmp;*.jpg;*.jpeg;*.png;*.gif";
			else
				ofd.Filter = "사운드 파일(*.mp3;*.wav;*.mid;*.ogg;*.wma)|*.mp3;*.wav;*.mid;*.ogg;*.wma";

			if (ofd.ShowDialog() == DialogResult.Cancel) return;

			txtFile.Text = ofd.FileName;
		}

		private void btnTransKey_Click(object sender, EventArgs e)
		{
			ColorDialog cd = new ColorDialog();
			cd.Color = picColor.BackColor;
			if (cd.ShowDialog() == DialogResult.Cancel) return;
			picColor.BackColor = cd.Color;
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
	}
}
