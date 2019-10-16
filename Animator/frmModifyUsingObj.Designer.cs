namespace Animator
{
	partial class frmModifyUsingObj
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
			this.label1 = new System.Windows.Forms.Label();
			this.numIndex = new System.Windows.Forms.NumericUpDown();
			this.btnView = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.numLocationX = new System.Windows.Forms.NumericUpDown();
			this.numLocationY = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.numSizeH = new System.Windows.Forms.NumericUpDown();
			this.numSizeW = new System.Windows.Forms.NumericUpDown();
			this.btnModify = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numIndex)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numLocationX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numLocationY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numSizeH)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numSizeW)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "객체 번호 :";
			// 
			// numIndex
			// 
			this.numIndex.Location = new System.Drawing.Point(91, 19);
			this.numIndex.Name = "numIndex";
			this.numIndex.Size = new System.Drawing.Size(62, 22);
			this.numIndex.TabIndex = 1;
			// 
			// btnView
			// 
			this.btnView.Location = new System.Drawing.Point(159, 19);
			this.btnView.Name = "btnView";
			this.btnView.Size = new System.Drawing.Size(48, 22);
			this.btnView.TabIndex = 2;
			this.btnView.Text = "보기";
			this.btnView.UseVisualStyleBackColor = true;
			this.btnView.Click += new System.EventHandler(this.btnView_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "위치 :";
			// 
			// numLocationX
			// 
			this.numLocationX.Location = new System.Drawing.Point(65, 62);
			this.numLocationX.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
			this.numLocationX.Minimum = new decimal(new int[] {
            1410065408,
            2,
            0,
            -2147483648});
			this.numLocationX.Name = "numLocationX";
			this.numLocationX.Size = new System.Drawing.Size(67, 22);
			this.numLocationX.TabIndex = 4;
			// 
			// numLocationY
			// 
			this.numLocationY.Location = new System.Drawing.Point(140, 62);
			this.numLocationY.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
			this.numLocationY.Minimum = new decimal(new int[] {
            1410065408,
            2,
            0,
            -2147483648});
			this.numLocationY.Name = "numLocationY";
			this.numLocationY.Size = new System.Drawing.Size(67, 22);
			this.numLocationY.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(24, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "크기 :";
			// 
			// numSizeH
			// 
			this.numSizeH.Location = new System.Drawing.Point(140, 106);
			this.numSizeH.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
			this.numSizeH.Minimum = new decimal(new int[] {
            1410065408,
            2,
            0,
            -2147483648});
			this.numSizeH.Name = "numSizeH";
			this.numSizeH.Size = new System.Drawing.Size(67, 22);
			this.numSizeH.TabIndex = 8;
			// 
			// numSizeW
			// 
			this.numSizeW.Location = new System.Drawing.Point(65, 106);
			this.numSizeW.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
			this.numSizeW.Minimum = new decimal(new int[] {
            1410065408,
            2,
            0,
            -2147483648});
			this.numSizeW.Name = "numSizeW";
			this.numSizeW.Size = new System.Drawing.Size(67, 22);
			this.numSizeW.TabIndex = 7;
			// 
			// btnModify
			// 
			this.btnModify.Location = new System.Drawing.Point(27, 149);
			this.btnModify.Name = "btnModify";
			this.btnModify.Size = new System.Drawing.Size(75, 23);
			this.btnModify.TabIndex = 9;
			this.btnModify.Text = "수정(&M)";
			this.btnModify.UseVisualStyleBackColor = true;
			this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(132, 149);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "취소(&C)";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// frmModifyUsingObj
			// 
			this.AcceptButton = this.btnModify;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(238, 194);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnModify);
			this.Controls.Add(this.numSizeH);
			this.Controls.Add(this.numSizeW);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.numLocationY);
			this.Controls.Add(this.numLocationX);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnView);
			this.Controls.Add(this.numIndex);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmModifyUsingObj";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "사용 객체 수정";
			((System.ComponentModel.ISupportInitialize)(this.numIndex)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numLocationX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numLocationY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numSizeH)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numSizeW)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numIndex;
		private System.Windows.Forms.Button btnView;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numLocationX;
		private System.Windows.Forms.NumericUpDown numLocationY;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numSizeH;
		private System.Windows.Forms.NumericUpDown numSizeW;
		private System.Windows.Forms.Button btnModify;
		private System.Windows.Forms.Button btnCancel;
	}
}