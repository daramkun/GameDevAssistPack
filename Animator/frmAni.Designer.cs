﻿namespace Animator
{
	partial class frmAni
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.picPlay = new System.Windows.Forms.PictureBox();
			this.tmrRun = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.picPlay)).BeginInit();
			this.SuspendLayout();
			// 
			// picPlay
			// 
			this.picPlay.BackColor = System.Drawing.Color.White;
			this.picPlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picPlay.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picPlay.Location = new System.Drawing.Point(0, 0);
			this.picPlay.Name = "picPlay";
			this.picPlay.Size = new System.Drawing.Size(307, 290);
			this.picPlay.TabIndex = 1;
			this.picPlay.TabStop = false;
			// 
			// tmrRun
			// 
			this.tmrRun.Enabled = true;
			this.tmrRun.Tick += new System.EventHandler(this.tmrRun_Tick);
			// 
			// frmAni
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(307, 290);
			this.Controls.Add(this.picPlay);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "frmAni";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "재생 창";
			((System.ComponentModel.ISupportInitialize)(this.picPlay)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox picPlay;
		private System.Windows.Forms.Timer tmrRun;
	}
}