namespace Animator
{
	partial class frmMOShow
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.lstObjs = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.picImage = new System.Windows.Forms.PictureBox();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.lstObjs);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.picImage);
			this.splitContainer1.Size = new System.Drawing.Size(466, 299);
			this.splitContainer1.SplitterDistance = 182;
			this.splitContainer1.TabIndex = 1;
			// 
			// lstObjs
			// 
			this.lstObjs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
			this.lstObjs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstObjs.Location = new System.Drawing.Point(0, 0);
			this.lstObjs.Name = "lstObjs";
			this.lstObjs.Size = new System.Drawing.Size(182, 299);
			this.lstObjs.TabIndex = 1;
			this.lstObjs.UseCompatibleStateImageBehavior = false;
			this.lstObjs.View = System.Windows.Forms.View.Details;
			this.lstObjs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstObjs_MouseDoubleClick);
			this.lstObjs.SelectedIndexChanged += new System.EventHandler(this.lstObjs_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "객체명";
			this.columnHeader1.Width = 155;
			// 
			// picImage
			// 
			this.picImage.BackColor = System.Drawing.Color.White;
			this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picImage.Location = new System.Drawing.Point(0, 0);
			this.picImage.Name = "picImage";
			this.picImage.Size = new System.Drawing.Size(280, 299);
			this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picImage.TabIndex = 2;
			this.picImage.TabStop = false;
			this.picImage.Paint += new System.Windows.Forms.PaintEventHandler(this.picImage_Paint);
			// 
			// frmMOShow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(466, 299);
			this.Controls.Add(this.splitContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmMOShow";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "사용 가능 객체 보기";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ListView lstObjs;
		private System.Windows.Forms.PictureBox picImage;
		private System.Windows.Forms.ColumnHeader columnHeader1;
	}
}