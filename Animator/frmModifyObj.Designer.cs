namespace Animator
{
	partial class frmModifyObj
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
			this.txtName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.picColor = new System.Windows.Forms.PictureBox();
			this.btnTransKey = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.txtFile = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdbAssult = new System.Windows.Forms.RadioButton();
			this.rdbDamage = new System.Windows.Forms.RadioButton();
			this.rdbSound = new System.Windows.Forms.RadioButton();
			this.rdbImage = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.picColor)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(83, 81);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(275, 22);
			this.txtName.TabIndex = 21;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 84);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 13);
			this.label3.TabIndex = 20;
			this.label3.Text = "객체 이름 :";
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(306, 167);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(60, 23);
			this.btnCancel.TabIndex = 19;
			this.btnCancel.Text = "취소(&C)";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(240, 167);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(60, 23);
			this.btnAdd.TabIndex = 18;
			this.btnAdd.Text = "수정(&M)";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// picColor
			// 
			this.picColor.BackColor = System.Drawing.Color.Magenta;
			this.picColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picColor.Location = new System.Drawing.Point(67, 155);
			this.picColor.Name = "picColor";
			this.picColor.Size = new System.Drawing.Size(23, 23);
			this.picColor.TabIndex = 17;
			this.picColor.TabStop = false;
			// 
			// btnTransKey
			// 
			this.btnTransKey.Location = new System.Drawing.Point(96, 155);
			this.btnTransKey.Name = "btnTransKey";
			this.btnTransKey.Size = new System.Drawing.Size(83, 23);
			this.btnTransKey.TabIndex = 16;
			this.btnTransKey.Text = "투명색 선택";
			this.btnTransKey.UseVisualStyleBackColor = true;
			this.btnTransKey.Click += new System.EventHandler(this.btnTransKey_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 160);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 13);
			this.label2.TabIndex = 15;
			this.label2.Text = "투명색 :";
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(283, 118);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(75, 23);
			this.btnBrowse.TabIndex = 14;
			this.btnBrowse.Text = "찾아보기...";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// txtFile
			// 
			this.txtFile.Location = new System.Drawing.Point(57, 120);
			this.txtFile.Name = "txtFile";
			this.txtFile.Size = new System.Drawing.Size(223, 22);
			this.txtFile.TabIndex = 13;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 123);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "파일 :";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdbAssult);
			this.groupBox1.Controls.Add(this.rdbDamage);
			this.groupBox1.Controls.Add(this.rdbSound);
			this.groupBox1.Controls.Add(this.rdbImage);
			this.groupBox1.Location = new System.Drawing.Point(19, 15);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(339, 54);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "객체의 종류";
			// 
			// rdbAssult
			// 
			this.rdbAssult.AutoSize = true;
			this.rdbAssult.Location = new System.Drawing.Point(239, 21);
			this.rdbAssult.Name = "rdbAssult";
			this.rdbAssult.Size = new System.Drawing.Size(95, 17);
			this.rdbAssult.TabIndex = 3;
			this.rdbAssult.Text = "어썰트 포인트";
			this.rdbAssult.UseVisualStyleBackColor = true;
			this.rdbAssult.CheckedChanged += new System.EventHandler(this.rdbAssult_CheckedChanged);
			// 
			// rdbDamage
			// 
			this.rdbDamage.AutoSize = true;
			this.rdbDamage.Location = new System.Drawing.Point(138, 21);
			this.rdbDamage.Name = "rdbDamage";
			this.rdbDamage.Size = new System.Drawing.Size(95, 17);
			this.rdbDamage.TabIndex = 2;
			this.rdbDamage.Text = "대미지 포인트";
			this.rdbDamage.UseVisualStyleBackColor = true;
			this.rdbDamage.CheckedChanged += new System.EventHandler(this.rdbDamage_CheckedChanged);
			// 
			// rdbSound
			// 
			this.rdbSound.AutoSize = true;
			this.rdbSound.Location = new System.Drawing.Point(74, 21);
			this.rdbSound.Name = "rdbSound";
			this.rdbSound.Size = new System.Drawing.Size(58, 17);
			this.rdbSound.TabIndex = 1;
			this.rdbSound.Text = "사운드";
			this.rdbSound.UseVisualStyleBackColor = true;
			this.rdbSound.CheckedChanged += new System.EventHandler(this.rdbSound_CheckedChanged);
			// 
			// rdbImage
			// 
			this.rdbImage.AutoSize = true;
			this.rdbImage.Checked = true;
			this.rdbImage.Location = new System.Drawing.Point(10, 21);
			this.rdbImage.Name = "rdbImage";
			this.rdbImage.Size = new System.Drawing.Size(58, 17);
			this.rdbImage.TabIndex = 0;
			this.rdbImage.TabStop = true;
			this.rdbImage.Text = "이미지";
			this.rdbImage.UseVisualStyleBackColor = true;
			this.rdbImage.CheckedChanged += new System.EventHandler(this.rdbImage_CheckedChanged);
			// 
			// frmModifyObj
			// 
			this.AcceptButton = this.btnAdd;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(378, 204);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.picColor);
			this.Controls.Add(this.btnTransKey);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.txtFile);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmModifyObj";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "객체 수정";
			((System.ComponentModel.ISupportInitialize)(this.picColor)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.PictureBox picColor;
		private System.Windows.Forms.Button btnTransKey;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.TextBox txtFile;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdbAssult;
		private System.Windows.Forms.RadioButton rdbDamage;
		private System.Windows.Forms.RadioButton rdbSound;
		private System.Windows.Forms.RadioButton rdbImage;
	}
}