namespace Animator
{
	partial class frmMain
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.sttStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tssCoor = new System.Windows.Forms.ToolStripStatusLabel();
			this.ttsUObj = new System.Windows.Forms.ToolStripStatusLabel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.lstObject = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.imgLst = new System.Windows.Forms.ImageList(this.components);
			this.splitContainer3 = new System.Windows.Forms.SplitContainer();
			this.lstFrameMode = new System.Windows.Forms.ListView();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.lstFrame = new System.Windows.Forms.ListView();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.imgFrame = new System.Windows.Forms.ImageList(this.components);
			this.splitContainer4 = new System.Windows.Forms.SplitContainer();
			this.trkX = new System.Windows.Forms.TrackBar();
			this.lstUsingObject = new System.Windows.Forms.ListView();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.mnuStrip = new System.Windows.Forms.MenuStrip();
			this.tStrip = new System.Windows.Forms.ToolStrip();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
			this.picEdit = new System.Windows.Forms.PictureBox();
			this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFrameMode = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuAddFrameMode = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuModifyFrameMode = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuRemoveFrameMode = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuAddFrame = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuRemoveFrame = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuAnchorPoint = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuObject = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuAddObject = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuModifyObject = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuRemoveObject = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuSelUse = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuModifyUseObject = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuAnimation = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuAniSpeed = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuPlayWindow = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuTools = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuOption = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuContents = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuModuleInfo = new System.Windows.Forms.ToolStripMenuItem();
			this.tsNew = new System.Windows.Forms.ToolStripButton();
			this.tsOpen = new System.Windows.Forms.ToolStripButton();
			this.tsSave = new System.Windows.Forms.ToolStripButton();
			this.tsAddFrameMode = new System.Windows.Forms.ToolStripButton();
			this.tsModifyFrameMode = new System.Windows.Forms.ToolStripButton();
			this.tsRemoveFrameMode = new System.Windows.Forms.ToolStripButton();
			this.tsAddFrame = new System.Windows.Forms.ToolStripButton();
			this.tsRemoveFrame = new System.Windows.Forms.ToolStripButton();
			this.tsAnchorPoint = new System.Windows.Forms.ToolStripButton();
			this.tsAddObject = new System.Windows.Forms.ToolStripButton();
			this.tsModifyObject = new System.Windows.Forms.ToolStripButton();
			this.tsRemoveObject = new System.Windows.Forms.ToolStripButton();
			this.tsUseObject = new System.Windows.Forms.ToolStripButton();
			this.tsModifyUsingObject = new System.Windows.Forms.ToolStripButton();
			this.tsAniSpeed = new System.Windows.Forms.ToolStripButton();
			this.tsPlayWindow = new System.Windows.Forms.ToolStripButton();
			this.tsHelp = new System.Windows.Forms.ToolStripButton();
			this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.sttStrip.SuspendLayout();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.splitContainer3.Panel1.SuspendLayout();
			this.splitContainer3.Panel2.SuspendLayout();
			this.splitContainer3.SuspendLayout();
			this.splitContainer4.Panel1.SuspendLayout();
			this.splitContainer4.Panel2.SuspendLayout();
			this.splitContainer4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trkX)).BeginInit();
			this.mnuStrip.SuspendLayout();
			this.tStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picEdit)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.BottomToolStripPanel
			// 
			this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.sttStrip);
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(615, 417);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.LeftToolStripPanelVisible = false;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.RightToolStripPanelVisible = false;
			this.toolStripContainer1.Size = new System.Drawing.Size(615, 488);
			this.toolStripContainer1.TabIndex = 0;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.mnuStrip);
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.tStrip);
			// 
			// sttStrip
			// 
			this.sttStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.sttStrip.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.sttStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.sttStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tssCoor,
            this.ttsUObj});
			this.sttStrip.Location = new System.Drawing.Point(0, 0);
			this.sttStrip.Name = "sttStrip";
			this.sttStrip.Size = new System.Drawing.Size(615, 22);
			this.sttStrip.TabIndex = 0;
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(107, 17);
			this.toolStripStatusLabel1.Text = "게임 개발 보조 키트";
			// 
			// tssCoor
			// 
			this.tssCoor.Name = "tssCoor";
			this.tssCoor.Size = new System.Drawing.Size(100, 17);
			this.tssCoor.Text = "마우스 좌표 : {0, 0}";
			// 
			// ttsUObj
			// 
			this.ttsUObj.Name = "ttsUObj";
			this.ttsUObj.Size = new System.Drawing.Size(117, 17);
			this.ttsUObj.Text = "객체 정보 : {X, X, X, X}";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(10);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer4);
			this.splitContainer1.Size = new System.Drawing.Size(615, 417);
			this.splitContainer1.SplitterDistance = 186;
			this.splitContainer1.SplitterWidth = 5;
			this.splitContainer1.TabIndex = 0;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.lstObject);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
			this.splitContainer2.Size = new System.Drawing.Size(186, 417);
			this.splitContainer2.SplitterDistance = 113;
			this.splitContainer2.SplitterWidth = 5;
			this.splitContainer2.TabIndex = 0;
			// 
			// lstObject
			// 
			this.lstObject.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
			this.lstObject.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstObject.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lstObject.Location = new System.Drawing.Point(0, 0);
			this.lstObject.Name = "lstObject";
			this.lstObject.Size = new System.Drawing.Size(186, 113);
			this.lstObject.SmallImageList = this.imgLst;
			this.lstObject.TabIndex = 0;
			this.lstObject.UseCompatibleStateImageBehavior = false;
			this.lstObject.View = System.Windows.Forms.View.Details;
			this.lstObject.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstObject_MouseDoubleClick);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "객체명";
			this.columnHeader1.Width = 156;
			// 
			// imgLst
			// 
			this.imgLst.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLst.ImageStream")));
			this.imgLst.TransparentColor = System.Drawing.Color.Transparent;
			this.imgLst.Images.SetKeyName(0, "picture.png");
			this.imgLst.Images.SetKeyName(1, "music.png");
			this.imgLst.Images.SetKeyName(2, "asterisk_orange.png");
			this.imgLst.Images.SetKeyName(3, "chart_pie.png");
			// 
			// splitContainer3
			// 
			this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer3.Location = new System.Drawing.Point(0, 0);
			this.splitContainer3.Name = "splitContainer3";
			this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer3.Panel1
			// 
			this.splitContainer3.Panel1.Controls.Add(this.lstFrameMode);
			// 
			// splitContainer3.Panel2
			// 
			this.splitContainer3.Panel2.Controls.Add(this.lstFrame);
			this.splitContainer3.Size = new System.Drawing.Size(186, 299);
			this.splitContainer3.SplitterDistance = 121;
			this.splitContainer3.SplitterWidth = 5;
			this.splitContainer3.TabIndex = 0;
			// 
			// lstFrameMode
			// 
			this.lstFrameMode.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
			this.lstFrameMode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstFrameMode.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lstFrameMode.Location = new System.Drawing.Point(0, 0);
			this.lstFrameMode.Name = "lstFrameMode";
			this.lstFrameMode.Size = new System.Drawing.Size(186, 121);
			this.lstFrameMode.TabIndex = 0;
			this.lstFrameMode.UseCompatibleStateImageBehavior = false;
			this.lstFrameMode.View = System.Windows.Forms.View.Details;
			this.lstFrameMode.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstFrameMode_MouseDoubleClick);
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "프레임모드 이름";
			this.columnHeader2.Width = 156;
			// 
			// lstFrame
			// 
			this.lstFrame.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
			this.lstFrame.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstFrame.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lstFrame.Location = new System.Drawing.Point(0, 0);
			this.lstFrame.Name = "lstFrame";
			this.lstFrame.Size = new System.Drawing.Size(186, 173);
			this.lstFrame.SmallImageList = this.imgFrame;
			this.lstFrame.TabIndex = 0;
			this.lstFrame.UseCompatibleStateImageBehavior = false;
			this.lstFrame.View = System.Windows.Forms.View.Details;
			this.lstFrame.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstFrame_MouseDoubleClick);
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "프레임";
			this.columnHeader3.Width = 156;
			// 
			// imgFrame
			// 
			this.imgFrame.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgFrame.ImageStream")));
			this.imgFrame.TransparentColor = System.Drawing.Color.Transparent;
			this.imgFrame.Images.SetKeyName(0, "film.png");
			// 
			// splitContainer4
			// 
			this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer4.Location = new System.Drawing.Point(0, 0);
			this.splitContainer4.Name = "splitContainer4";
			this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer4.Panel1
			// 
			this.splitContainer4.Panel1.Controls.Add(this.trkX);
			this.splitContainer4.Panel1.Controls.Add(this.picEdit);
			// 
			// splitContainer4.Panel2
			// 
			this.splitContainer4.Panel2.Controls.Add(this.lstUsingObject);
			this.splitContainer4.Size = new System.Drawing.Size(424, 417);
			this.splitContainer4.SplitterDistance = 295;
			this.splitContainer4.SplitterWidth = 5;
			this.splitContainer4.TabIndex = 0;
			// 
			// trkX
			// 
			this.trkX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.trkX.LargeChange = 1;
			this.trkX.Location = new System.Drawing.Point(1, 248);
			this.trkX.Minimum = 1;
			this.trkX.Name = "trkX";
			this.trkX.Size = new System.Drawing.Size(423, 45);
			this.trkX.TabIndex = 1;
			this.trkX.Value = 5;
			this.trkX.Scroll += new System.EventHandler(this.trkX_Scroll);
			// 
			// lstUsingObject
			// 
			this.lstUsingObject.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4});
			this.lstUsingObject.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstUsingObject.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lstUsingObject.Location = new System.Drawing.Point(0, 0);
			this.lstUsingObject.Name = "lstUsingObject";
			this.lstUsingObject.Size = new System.Drawing.Size(424, 117);
			this.lstUsingObject.SmallImageList = this.imgLst;
			this.lstUsingObject.TabIndex = 0;
			this.lstUsingObject.UseCompatibleStateImageBehavior = false;
			this.lstUsingObject.View = System.Windows.Forms.View.Details;
			this.lstUsingObject.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstUsingObject_KeyDown);
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "사용중인 객체명";
			this.columnHeader4.Width = 356;
			// 
			// mnuStrip
			// 
			this.mnuStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.mnuStrip.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.mnuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.mnuStrip.ImageScalingSize = new System.Drawing.Size(14, 14);
			this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuFrameMode,
            this.mnuObject,
            this.mnuAnimation,
            this.mnuTools,
            this.mnuHelp});
			this.mnuStrip.Location = new System.Drawing.Point(0, 0);
			this.mnuStrip.Name = "mnuStrip";
			this.mnuStrip.Size = new System.Drawing.Size(615, 24);
			this.mnuStrip.TabIndex = 0;
			this.mnuStrip.Text = "menuStrip1";
			// 
			// tStrip
			// 
			this.tStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.tStrip.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.tStrip.ImageScalingSize = new System.Drawing.Size(14, 14);
			this.tStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNew,
            this.tsOpen,
            this.tsSave,
            this.toolStripSeparator1,
            this.tsAddFrameMode,
            this.tsModifyFrameMode,
            this.tsRemoveFrameMode,
            this.toolStripSeparator4,
            this.tsAddFrame,
            this.tsRemoveFrame,
            this.tsAnchorPoint,
            this.toolStripSeparator5,
            this.tsAddObject,
            this.tsModifyObject,
            this.tsRemoveObject,
            this.toolStripSeparator6,
            this.tsUseObject,
            this.toolStripSeparator7,
            this.tsModifyUsingObject,
            this.toolStripSeparator8,
            this.tsAniSpeed,
            this.toolStripSeparator9,
            this.tsPlayWindow,
            this.toolStripSeparator10,
            this.tsHelp});
			this.tStrip.Location = new System.Drawing.Point(3, 24);
			this.tStrip.Name = "tStrip";
			this.tStrip.Size = new System.Drawing.Size(451, 25);
			this.tStrip.TabIndex = 1;
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripSeparator8
			// 
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripSeparator9
			// 
			this.toolStripSeparator9.Name = "toolStripSeparator9";
			this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripSeparator10
			// 
			this.toolStripSeparator10.Name = "toolStripSeparator10";
			this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
			// 
			// picEdit
			// 
			this.picEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.picEdit.BackColor = System.Drawing.Color.White;
			this.picEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picEdit.Location = new System.Drawing.Point(0, 0);
			this.picEdit.Name = "picEdit";
			this.picEdit.Size = new System.Drawing.Size(424, 242);
			this.picEdit.TabIndex = 0;
			this.picEdit.TabStop = false;
			this.picEdit.MouseLeave += new System.EventHandler(this.picEdit_MouseLeave);
			this.picEdit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picEdit_MouseMove);
			this.picEdit.Click += new System.EventHandler(this.picEdit_Click);
			this.picEdit.Resize += new System.EventHandler(this.picEdit_Resize);
			this.picEdit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picEdit_MouseDown);
			this.picEdit.Paint += new System.Windows.Forms.PaintEventHandler(this.picEdit_Paint);
			this.picEdit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picEdit_MouseUp);
			// 
			// mnuFile
			// 
			this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnuOpen,
            this.toolStripMenuItem1,
            this.mnuSave,
            this.mnuSaveAs,
            this.toolStripMenuItem2,
            this.mnuExit});
			this.mnuFile.Image = global::Animator.Properties.Resources.application;
			this.mnuFile.Name = "mnuFile";
			this.mnuFile.Size = new System.Drawing.Size(66, 20);
			this.mnuFile.Text = "파일(&F)";
			// 
			// mnuNew
			// 
			this.mnuNew.Image = global::Animator.Properties.Resources.page;
			this.mnuNew.Name = "mnuNew";
			this.mnuNew.Size = new System.Drawing.Size(172, 22);
			this.mnuNew.Text = "새 애니메이션(&N)";
			this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click);
			// 
			// mnuOpen
			// 
			this.mnuOpen.Image = global::Animator.Properties.Resources.folder;
			this.mnuOpen.Name = "mnuOpen";
			this.mnuOpen.Size = new System.Drawing.Size(172, 22);
			this.mnuOpen.Text = "열기(&O)";
			this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(169, 6);
			// 
			// mnuSave
			// 
			this.mnuSave.Image = global::Animator.Properties.Resources.disk;
			this.mnuSave.Name = "mnuSave";
			this.mnuSave.Size = new System.Drawing.Size(172, 22);
			this.mnuSave.Text = "저장(&S)";
			this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
			// 
			// mnuSaveAs
			// 
			this.mnuSaveAs.Name = "mnuSaveAs";
			this.mnuSaveAs.Size = new System.Drawing.Size(172, 22);
			this.mnuSaveAs.Text = "새 이름으로 저장(&A)";
			this.mnuSaveAs.Click += new System.EventHandler(this.mnuSaveAs_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(169, 6);
			// 
			// mnuExit
			// 
			this.mnuExit.Image = global::Animator.Properties.Resources.door_out;
			this.mnuExit.Name = "mnuExit";
			this.mnuExit.Size = new System.Drawing.Size(172, 22);
			this.mnuExit.Text = "종료(&X)";
			this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
			// 
			// mnuFrameMode
			// 
			this.mnuFrameMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddFrameMode,
            this.mnuModifyFrameMode,
            this.mnuRemoveFrameMode,
            this.toolStripMenuItem4,
            this.mnuAddFrame,
            this.mnuRemoveFrame,
            this.mnuAnchorPoint});
			this.mnuFrameMode.Image = global::Animator.Properties.Resources.film;
			this.mnuFrameMode.Name = "mnuFrameMode";
			this.mnuFrameMode.Size = new System.Drawing.Size(104, 20);
			this.mnuFrameMode.Text = "프레임모드(&M)";
			// 
			// mnuAddFrameMode
			// 
			this.mnuAddFrameMode.Image = global::Animator.Properties.Resources.book_add;
			this.mnuAddFrameMode.Name = "mnuAddFrameMode";
			this.mnuAddFrameMode.Size = new System.Drawing.Size(173, 22);
			this.mnuAddFrameMode.Text = "새 프레임모드(&A)";
			this.mnuAddFrameMode.Click += new System.EventHandler(this.mnuAddFrameMode_Click);
			// 
			// mnuModifyFrameMode
			// 
			this.mnuModifyFrameMode.Image = global::Animator.Properties.Resources.book_edit;
			this.mnuModifyFrameMode.Name = "mnuModifyFrameMode";
			this.mnuModifyFrameMode.Size = new System.Drawing.Size(173, 22);
			this.mnuModifyFrameMode.Text = "프레임모드 수정(&M)";
			this.mnuModifyFrameMode.Click += new System.EventHandler(this.mnuModifyFrameMode_Click);
			// 
			// mnuRemoveFrameMode
			// 
			this.mnuRemoveFrameMode.Image = global::Animator.Properties.Resources.book_delete;
			this.mnuRemoveFrameMode.Name = "mnuRemoveFrameMode";
			this.mnuRemoveFrameMode.Size = new System.Drawing.Size(173, 22);
			this.mnuRemoveFrameMode.Text = "프레임모드 제거(&D)";
			this.mnuRemoveFrameMode.Click += new System.EventHandler(this.mnuRemoveFrameMode_Click);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(170, 6);
			// 
			// mnuAddFrame
			// 
			this.mnuAddFrame.Image = global::Animator.Properties.Resources.film_add;
			this.mnuAddFrame.Name = "mnuAddFrame";
			this.mnuAddFrame.Size = new System.Drawing.Size(173, 22);
			this.mnuAddFrame.Text = "프레임 추가(&P)";
			this.mnuAddFrame.Click += new System.EventHandler(this.mnuAddFrame_Click);
			// 
			// mnuRemoveFrame
			// 
			this.mnuRemoveFrame.Image = global::Animator.Properties.Resources.film_delete;
			this.mnuRemoveFrame.Name = "mnuRemoveFrame";
			this.mnuRemoveFrame.Size = new System.Drawing.Size(173, 22);
			this.mnuRemoveFrame.Text = "프레임 제거(&R)";
			this.mnuRemoveFrame.Click += new System.EventHandler(this.mnuRemoveFrame_Click);
			// 
			// mnuAnchorPoint
			// 
			this.mnuAnchorPoint.Image = global::Animator.Properties.Resources.anchor;
			this.mnuAnchorPoint.Name = "mnuAnchorPoint";
			this.mnuAnchorPoint.Size = new System.Drawing.Size(173, 22);
			this.mnuAnchorPoint.Text = "앵커 포인트 설정(&N)";
			this.mnuAnchorPoint.Click += new System.EventHandler(this.mnuAnchorPoint_Click);
			// 
			// mnuObject
			// 
			this.mnuObject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddObject,
            this.mnuModifyObject,
            this.mnuRemoveObject,
            this.toolStripMenuItem5,
            this.mnuSelUse,
            this.toolStripMenuItem6,
            this.mnuModifyUseObject});
			this.mnuObject.Image = global::Animator.Properties.Resources.plugin;
			this.mnuObject.Name = "mnuObject";
			this.mnuObject.Size = new System.Drawing.Size(70, 20);
			this.mnuObject.Text = "객체(&O)";
			// 
			// mnuAddObject
			// 
			this.mnuAddObject.Image = global::Animator.Properties.Resources.plugin_add;
			this.mnuAddObject.Name = "mnuAddObject";
			this.mnuAddObject.Size = new System.Drawing.Size(173, 22);
			this.mnuAddObject.Text = "객체 추가(&A)";
			this.mnuAddObject.Click += new System.EventHandler(this.mnuAddObject_Click);
			// 
			// mnuModifyObject
			// 
			this.mnuModifyObject.Image = global::Animator.Properties.Resources.plugin_edit;
			this.mnuModifyObject.Name = "mnuModifyObject";
			this.mnuModifyObject.Size = new System.Drawing.Size(173, 22);
			this.mnuModifyObject.Text = "객체 수정(&D)";
			this.mnuModifyObject.Click += new System.EventHandler(this.mnuModifyObject_Click);
			// 
			// mnuRemoveObject
			// 
			this.mnuRemoveObject.Image = global::Animator.Properties.Resources.plugin_delete;
			this.mnuRemoveObject.Name = "mnuRemoveObject";
			this.mnuRemoveObject.Size = new System.Drawing.Size(173, 22);
			this.mnuRemoveObject.Text = "객체 제거(&R)";
			this.mnuRemoveObject.Click += new System.EventHandler(this.mnuRemoveObject_Click);
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(170, 6);
			// 
			// mnuSelUse
			// 
			this.mnuSelUse.Image = global::Animator.Properties.Resources.plugin_go;
			this.mnuSelUse.Name = "mnuSelUse";
			this.mnuSelUse.Size = new System.Drawing.Size(173, 22);
			this.mnuSelUse.Text = "선택한 객체 사용(&U)";
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new System.Drawing.Size(170, 6);
			// 
			// mnuModifyUseObject
			// 
			this.mnuModifyUseObject.Image = global::Animator.Properties.Resources.plugin_error;
			this.mnuModifyUseObject.Name = "mnuModifyUseObject";
			this.mnuModifyUseObject.Size = new System.Drawing.Size(173, 22);
			this.mnuModifyUseObject.Text = "사용 객체 수정(&O)";
			this.mnuModifyUseObject.Click += new System.EventHandler(this.mnuModifyUseObject_Click);
			// 
			// mnuAnimation
			// 
			this.mnuAnimation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAniSpeed,
            this.toolStripMenuItem7,
            this.mnuPlayWindow});
			this.mnuAnimation.Image = global::Animator.Properties.Resources.control_equalizer_blue;
			this.mnuAnimation.Name = "mnuAnimation";
			this.mnuAnimation.Size = new System.Drawing.Size(101, 20);
			this.mnuAnimation.Text = "애니메이션(&A)";
			// 
			// mnuAniSpeed
			// 
			this.mnuAniSpeed.Image = global::Animator.Properties.Resources.control_fastforward;
			this.mnuAniSpeed.Name = "mnuAniSpeed";
			this.mnuAniSpeed.Size = new System.Drawing.Size(194, 22);
			this.mnuAniSpeed.Text = "애니메이션 속도 조절(&A)";
			this.mnuAniSpeed.Click += new System.EventHandler(this.mnuAniSpeed_Click);
			// 
			// toolStripMenuItem7
			// 
			this.toolStripMenuItem7.Name = "toolStripMenuItem7";
			this.toolStripMenuItem7.Size = new System.Drawing.Size(191, 6);
			// 
			// mnuPlayWindow
			// 
			this.mnuPlayWindow.Image = global::Animator.Properties.Resources.control_play_blue;
			this.mnuPlayWindow.Name = "mnuPlayWindow";
			this.mnuPlayWindow.Size = new System.Drawing.Size(194, 22);
			this.mnuPlayWindow.Text = "재생 창(&P)";
			this.mnuPlayWindow.Click += new System.EventHandler(this.mnuPlayWindow_Click);
			// 
			// mnuTools
			// 
			this.mnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOption});
			this.mnuTools.Image = global::Animator.Properties.Resources.wrench;
			this.mnuTools.Name = "mnuTools";
			this.mnuTools.Size = new System.Drawing.Size(67, 20);
			this.mnuTools.Text = "도구(&T)";
			// 
			// mnuOption
			// 
			this.mnuOption.Image = global::Animator.Properties.Resources.cog;
			this.mnuOption.Name = "mnuOption";
			this.mnuOption.Size = new System.Drawing.Size(133, 22);
			this.mnuOption.Text = "환경설정(&O)";
			this.mnuOption.Click += new System.EventHandler(this.mnuOption_Click);
			// 
			// mnuHelp
			// 
			this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuContents,
            this.toolStripMenuItem3,
            this.mnuAbout,
            this.mnuModuleInfo});
			this.mnuHelp.Image = global::Animator.Properties.Resources.help;
			this.mnuHelp.Name = "mnuHelp";
			this.mnuHelp.Size = new System.Drawing.Size(80, 20);
			this.mnuHelp.Text = "도움말(&H)";
			// 
			// mnuContents
			// 
			this.mnuContents.Image = global::Animator.Properties.Resources.help;
			this.mnuContents.Name = "mnuContents";
			this.mnuContents.Size = new System.Drawing.Size(146, 22);
			this.mnuContents.Text = "도움말 항목(&C)";
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(143, 6);
			// 
			// mnuAbout
			// 
			this.mnuAbout.Name = "mnuAbout";
			this.mnuAbout.Size = new System.Drawing.Size(146, 22);
			this.mnuAbout.Text = "버전 정보(&A)";
			this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
			// 
			// mnuModuleInfo
			// 
			this.mnuModuleInfo.Name = "mnuModuleInfo";
			this.mnuModuleInfo.Size = new System.Drawing.Size(146, 22);
			this.mnuModuleInfo.Text = "모듈 정보(&M)";
			this.mnuModuleInfo.Click += new System.EventHandler(this.mnuModuleInfo_Click);
			// 
			// tsNew
			// 
			this.tsNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsNew.Image = global::Animator.Properties.Resources.page;
			this.tsNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsNew.Name = "tsNew";
			this.tsNew.Size = new System.Drawing.Size(23, 22);
			this.tsNew.Text = "새 애니메이션";
			this.tsNew.Click += new System.EventHandler(this.tsNew_Click);
			// 
			// tsOpen
			// 
			this.tsOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsOpen.Image = global::Animator.Properties.Resources.folder;
			this.tsOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsOpen.Name = "tsOpen";
			this.tsOpen.Size = new System.Drawing.Size(23, 22);
			this.tsOpen.Text = "열기";
			this.tsOpen.Click += new System.EventHandler(this.tsOpen_Click);
			// 
			// tsSave
			// 
			this.tsSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsSave.Image = global::Animator.Properties.Resources.disk;
			this.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsSave.Name = "tsSave";
			this.tsSave.Size = new System.Drawing.Size(23, 22);
			this.tsSave.Text = "저장";
			this.tsSave.Click += new System.EventHandler(this.tsSave_Click);
			// 
			// tsAddFrameMode
			// 
			this.tsAddFrameMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsAddFrameMode.Image = global::Animator.Properties.Resources.book_add;
			this.tsAddFrameMode.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsAddFrameMode.Name = "tsAddFrameMode";
			this.tsAddFrameMode.Size = new System.Drawing.Size(23, 22);
			this.tsAddFrameMode.Text = "프레임모드 추가";
			this.tsAddFrameMode.Click += new System.EventHandler(this.tsAddFrameMode_Click);
			// 
			// tsModifyFrameMode
			// 
			this.tsModifyFrameMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsModifyFrameMode.Image = global::Animator.Properties.Resources.book_edit;
			this.tsModifyFrameMode.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsModifyFrameMode.Name = "tsModifyFrameMode";
			this.tsModifyFrameMode.Size = new System.Drawing.Size(23, 22);
			this.tsModifyFrameMode.Text = "프레임모드 수정";
			this.tsModifyFrameMode.Click += new System.EventHandler(this.tsModifyFrameMode_Click);
			// 
			// tsRemoveFrameMode
			// 
			this.tsRemoveFrameMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsRemoveFrameMode.Image = global::Animator.Properties.Resources.book_delete;
			this.tsRemoveFrameMode.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsRemoveFrameMode.Name = "tsRemoveFrameMode";
			this.tsRemoveFrameMode.Size = new System.Drawing.Size(23, 22);
			this.tsRemoveFrameMode.Text = "프레임모드 제거";
			this.tsRemoveFrameMode.Click += new System.EventHandler(this.tsRemoveFrameMode_Click);
			// 
			// tsAddFrame
			// 
			this.tsAddFrame.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsAddFrame.Image = global::Animator.Properties.Resources.film_add;
			this.tsAddFrame.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsAddFrame.Name = "tsAddFrame";
			this.tsAddFrame.Size = new System.Drawing.Size(23, 22);
			this.tsAddFrame.Text = "프레임 추가";
			this.tsAddFrame.Click += new System.EventHandler(this.tsAddFrame_Click);
			// 
			// tsRemoveFrame
			// 
			this.tsRemoveFrame.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsRemoveFrame.Image = global::Animator.Properties.Resources.film_delete;
			this.tsRemoveFrame.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsRemoveFrame.Name = "tsRemoveFrame";
			this.tsRemoveFrame.Size = new System.Drawing.Size(23, 22);
			this.tsRemoveFrame.Text = "프레임 제거";
			this.tsRemoveFrame.Click += new System.EventHandler(this.tsRemoveFrame_Click);
			// 
			// tsAnchorPoint
			// 
			this.tsAnchorPoint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsAnchorPoint.Image = global::Animator.Properties.Resources.anchor;
			this.tsAnchorPoint.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsAnchorPoint.Name = "tsAnchorPoint";
			this.tsAnchorPoint.Size = new System.Drawing.Size(23, 22);
			this.tsAnchorPoint.Text = "앵커 포인트 설정";
			this.tsAnchorPoint.Click += new System.EventHandler(this.tsAnchorPoint_Click);
			// 
			// tsAddObject
			// 
			this.tsAddObject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsAddObject.Image = global::Animator.Properties.Resources.plugin_add;
			this.tsAddObject.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsAddObject.Name = "tsAddObject";
			this.tsAddObject.Size = new System.Drawing.Size(23, 22);
			this.tsAddObject.Text = "객체 추가";
			this.tsAddObject.Click += new System.EventHandler(this.tsAddObject_Click);
			// 
			// tsModifyObject
			// 
			this.tsModifyObject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsModifyObject.Image = global::Animator.Properties.Resources.plugin_edit;
			this.tsModifyObject.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsModifyObject.Name = "tsModifyObject";
			this.tsModifyObject.Size = new System.Drawing.Size(23, 22);
			this.tsModifyObject.Text = "객체 수정";
			this.tsModifyObject.Click += new System.EventHandler(this.tsModifyObject_Click);
			// 
			// tsRemoveObject
			// 
			this.tsRemoveObject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsRemoveObject.Image = global::Animator.Properties.Resources.plugin_delete;
			this.tsRemoveObject.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsRemoveObject.Name = "tsRemoveObject";
			this.tsRemoveObject.Size = new System.Drawing.Size(23, 22);
			this.tsRemoveObject.Text = "객체 제거";
			this.tsRemoveObject.Click += new System.EventHandler(this.tsRemoveObject_Click);
			// 
			// tsUseObject
			// 
			this.tsUseObject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsUseObject.Image = global::Animator.Properties.Resources.plugin_go;
			this.tsUseObject.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsUseObject.Name = "tsUseObject";
			this.tsUseObject.Size = new System.Drawing.Size(23, 22);
			this.tsUseObject.Text = "객체 사용";
			this.tsUseObject.Click += new System.EventHandler(this.tsUseObject_Click);
			// 
			// tsModifyUsingObject
			// 
			this.tsModifyUsingObject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsModifyUsingObject.Image = global::Animator.Properties.Resources.plugin_error;
			this.tsModifyUsingObject.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsModifyUsingObject.Name = "tsModifyUsingObject";
			this.tsModifyUsingObject.Size = new System.Drawing.Size(23, 22);
			this.tsModifyUsingObject.Text = "사용중인 객체 수정";
			this.tsModifyUsingObject.Click += new System.EventHandler(this.tsModifyUsingObject_Click);
			// 
			// tsAniSpeed
			// 
			this.tsAniSpeed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsAniSpeed.Image = global::Animator.Properties.Resources.control_fastforward;
			this.tsAniSpeed.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsAniSpeed.Name = "tsAniSpeed";
			this.tsAniSpeed.Size = new System.Drawing.Size(23, 22);
			this.tsAniSpeed.Text = "애니메이션 속도 조절";
			this.tsAniSpeed.Click += new System.EventHandler(this.tsAniSpeed_Click);
			// 
			// tsPlayWindow
			// 
			this.tsPlayWindow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsPlayWindow.Image = global::Animator.Properties.Resources.control_play_blue;
			this.tsPlayWindow.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsPlayWindow.Name = "tsPlayWindow";
			this.tsPlayWindow.Size = new System.Drawing.Size(23, 22);
			this.tsPlayWindow.Text = "재생 창";
			this.tsPlayWindow.Click += new System.EventHandler(this.tsPlayWindow_Click);
			// 
			// tsHelp
			// 
			this.tsHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsHelp.Image = global::Animator.Properties.Resources.help;
			this.tsHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsHelp.Name = "tsHelp";
			this.tsHelp.Size = new System.Drawing.Size(23, 22);
			this.tsHelp.Text = "도움말";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(615, 488);
			this.Controls.Add(this.toolStripContainer1);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.MainMenuStrip = this.mnuStrip;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Untitled - BitDiary Animator";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
			this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.sttStrip.ResumeLayout(false);
			this.sttStrip.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			this.splitContainer2.ResumeLayout(false);
			this.splitContainer3.Panel1.ResumeLayout(false);
			this.splitContainer3.Panel2.ResumeLayout(false);
			this.splitContainer3.ResumeLayout(false);
			this.splitContainer4.Panel1.ResumeLayout(false);
			this.splitContainer4.Panel1.PerformLayout();
			this.splitContainer4.Panel2.ResumeLayout(false);
			this.splitContainer4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.trkX)).EndInit();
			this.mnuStrip.ResumeLayout(false);
			this.mnuStrip.PerformLayout();
			this.tStrip.ResumeLayout(false);
			this.tStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picEdit)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.StatusStrip sttStrip;
		private System.Windows.Forms.MenuStrip mnuStrip;
		private System.Windows.Forms.ToolStrip tStrip;
		private System.Windows.Forms.ToolStripMenuItem mnuFile;
		private System.Windows.Forms.ToolStripMenuItem mnuNew;
		private System.Windows.Forms.ToolStripMenuItem mnuOpen;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem mnuSave;
		private System.Windows.Forms.ToolStripMenuItem mnuSaveAs;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem mnuExit;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.SplitContainer splitContainer3;
		private System.Windows.Forms.SplitContainer splitContainer4;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ListView lstObject;
		private System.Windows.Forms.ListView lstFrameMode;
		private System.Windows.Forms.ListView lstFrame;
		private System.Windows.Forms.PictureBox picEdit;
		private System.Windows.Forms.ListView lstUsingObject;
		private System.Windows.Forms.ToolStripMenuItem mnuFrameMode;
		private System.Windows.Forms.ToolStripMenuItem mnuObject;
		private System.Windows.Forms.ToolStripMenuItem mnuAnimation;
		private System.Windows.Forms.ToolStripMenuItem mnuTools;
		private System.Windows.Forms.ToolStripMenuItem mnuHelp;
		private System.Windows.Forms.ToolStripMenuItem mnuContents;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem mnuAbout;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ToolStripMenuItem mnuAddFrameMode;
		private System.Windows.Forms.ToolStripMenuItem mnuModifyFrameMode;
		private System.Windows.Forms.ToolStripMenuItem mnuRemoveFrameMode;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem mnuAddFrame;
		private System.Windows.Forms.ToolStripMenuItem mnuRemoveFrame;
		private System.Windows.Forms.ToolStripMenuItem mnuAddObject;
		private System.Windows.Forms.ToolStripMenuItem mnuModifyObject;
		private System.Windows.Forms.ToolStripMenuItem mnuRemoveObject;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem mnuSelUse;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
		private System.Windows.Forms.ToolStripMenuItem mnuModifyUseObject;
		private System.Windows.Forms.ToolStripMenuItem mnuAniSpeed;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
		private System.Windows.Forms.ToolStripMenuItem mnuPlayWindow;
		private System.Windows.Forms.ToolStripButton tsNew;
		private System.Windows.Forms.ToolStripButton tsOpen;
		private System.Windows.Forms.ToolStripButton tsSave;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem mnuOption;
		private System.Windows.Forms.ToolStripButton tsAddFrameMode;
		private System.Windows.Forms.ToolStripButton tsModifyFrameMode;
		private System.Windows.Forms.ToolStripButton tsRemoveFrameMode;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripButton tsAddFrame;
		private System.Windows.Forms.ToolStripButton tsRemoveFrame;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripButton tsAddObject;
		private System.Windows.Forms.ToolStripButton tsModifyObject;
		private System.Windows.Forms.ToolStripButton tsRemoveObject;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripButton tsUseObject;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripButton tsModifyUsingObject;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
		private System.Windows.Forms.ToolStripButton tsAniSpeed;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
		private System.Windows.Forms.ToolStripButton tsPlayWindow;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
		private System.Windows.Forms.ToolStripButton tsHelp;
		private System.Windows.Forms.ImageList imgLst;
		private System.Windows.Forms.ImageList imgFrame;
		private System.Windows.Forms.TrackBar trkX;
		private System.Windows.Forms.ToolStripStatusLabel tssCoor;
		private System.Windows.Forms.ToolStripMenuItem mnuModuleInfo;
		private System.Windows.Forms.ToolStripStatusLabel ttsUObj;
		private System.Windows.Forms.ToolStripMenuItem mnuAnchorPoint;
		private System.Windows.Forms.ToolStripButton tsAnchorPoint;
	}
}

