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
	public partial class frmSpeed : Form
	{
		AniManager manager;

		public frmSpeed(ref AniManager manager)
		{
			InitializeComponent();
			this.manager = manager;
			numericUpDown1.Value = manager.Speed;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			manager.Speed = (int)numericUpDown1.Value;
			DialogResult = DialogResult.OK;
			this.Close();
		}
	}
}
