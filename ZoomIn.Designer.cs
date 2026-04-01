namespace ZoomIn
{
    partial class ZoomIn
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZoomIn));
			this.toolBar = new System.Windows.Forms.ToolStrip();
			this.toolSave = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.toolButtonTop = new System.Windows.Forms.ToolStripButton();
			this.toolRefresh = new System.Windows.Forms.ToolStripButton();
			this.toolDragDrop = new System.Windows.Forms.ToolStripButton();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.checkLogHistogram = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonApply = new System.Windows.Forms.Button();
			this.comboColorspace = new System.Windows.Forms.ComboBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabHistogram = new System.Windows.Forms.TabPage();
			this.pictureHistogram = new System.Windows.Forms.PictureBox();
			this.tabDct = new System.Windows.Forms.TabPage();
			this.pictureDct = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textArea = new System.Windows.Forms.TextBox();
			this.toolBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabHistogram.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureHistogram)).BeginInit();
			this.tabDct.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureDct)).BeginInit();
			this.SuspendLayout();
			// 
			// toolBar
			// 
			this.toolBar.Dock = System.Windows.Forms.DockStyle.None;
			this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSave,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolButtonTop,
            this.toolRefresh,
            this.toolDragDrop});
			this.toolBar.Location = new System.Drawing.Point(3, 0);
			this.toolBar.Name = "toolBar";
			this.toolBar.Size = new System.Drawing.Size(247, 25);
			this.toolBar.TabIndex = 0;
			this.toolBar.Text = "toolStrip1";
			// 
			// toolSave
			// 
			this.toolSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolSave.Image = ((System.Drawing.Image)(resources.GetObject("toolSave.Image")));
			this.toolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolSave.Name = "toolSave";
			this.toolSave.Size = new System.Drawing.Size(23, 22);
			this.toolSave.Text = "toolStripButton3";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton1.Text = "+";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton2.Text = "-";
			this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
			// 
			// toolButtonTop
			// 
			this.toolButtonTop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolButtonTop.Image = ((System.Drawing.Image)(resources.GetObject("toolButtonTop.Image")));
			this.toolButtonTop.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolButtonTop.Name = "toolButtonTop";
			this.toolButtonTop.Size = new System.Drawing.Size(84, 22);
			this.toolButtonTop.Text = "always on top";
			this.toolButtonTop.Click += new System.EventHandler(this.toolStripButton3_Click);
			// 
			// toolRefresh
			// 
			this.toolRefresh.Checked = true;
			this.toolRefresh.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolRefresh.Image = ((System.Drawing.Image)(resources.GetObject("toolRefresh.Image")));
			this.toolRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolRefresh.Name = "toolRefresh";
			this.toolRefresh.Size = new System.Drawing.Size(47, 22);
			this.toolRefresh.Text = "refresh";
			this.toolRefresh.Click += new System.EventHandler(this.toolRefresh_Click);
			// 
			// toolDragDrop
			// 
			this.toolDragDrop.Checked = true;
			this.toolDragDrop.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolDragDrop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolDragDrop.Image = ((System.Drawing.Image)(resources.GetObject("toolDragDrop.Image")));
			this.toolDragDrop.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolDragDrop.Name = "toolDragDrop";
			this.toolDragDrop.Size = new System.Drawing.Size(35, 22);
			this.toolDragDrop.Text = "drag";
			this.toolDragDrop.Click += new System.EventHandler(this.toolDragDrop_Click);
			// 
			// pictureBox
			// 
			this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox.Location = new System.Drawing.Point(0, 0);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(381, 470);
			this.pictureBox.TabIndex = 1;
			this.pictureBox.TabStop = false;
			this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.picture_Paint);
			this.pictureBox.QueryContinueDrag += new System.Windows.Forms.QueryContinueDragEventHandler(this.pictureBox_QueryContinueDrag);
			this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ZoomIn_MouseDown);
			this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
			this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ZoomIn_MouseUp);
			this.pictureBox.Resize += new System.EventHandler(this.ZoomIn_Resize);
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(782, 470);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(782, 495);
			this.toolStripContainer1.TabIndex = 2;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolBar);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.pictureBox);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.checkLogHistogram);
			this.splitContainer1.Panel2.Controls.Add(this.label2);
			this.splitContainer1.Panel2.Controls.Add(this.buttonApply);
			this.splitContainer1.Panel2.Controls.Add(this.comboColorspace);
			this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
			this.splitContainer1.Panel2.Controls.Add(this.label1);
			this.splitContainer1.Panel2.Controls.Add(this.textArea);
			this.splitContainer1.Size = new System.Drawing.Size(782, 470);
			this.splitContainer1.SplitterDistance = 381;
			this.splitContainer1.TabIndex = 0;
			// 
			// checkLogHistogram
			// 
			this.checkLogHistogram.AutoSize = true;
			this.checkLogHistogram.Location = new System.Drawing.Point(78, 58);
			this.checkLogHistogram.Name = "checkLogHistogram";
			this.checkLogHistogram.Size = new System.Drawing.Size(104, 17);
			this.checkLogHistogram.TabIndex = 3;
			this.checkLogHistogram.Text = "logarithmic scale";
			this.checkLogHistogram.UseVisualStyleBackColor = true;
			this.checkLogHistogram.CheckedChanged += new System.EventHandler(this.checkLogHistogram_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "colorspace";
			// 
			// buttonApply
			// 
			this.buttonApply.Location = new System.Drawing.Point(200, 3);
			this.buttonApply.Name = "buttonApply";
			this.buttonApply.Size = new System.Drawing.Size(55, 23);
			this.buttonApply.TabIndex = 6;
			this.buttonApply.Text = "apply";
			this.buttonApply.UseVisualStyleBackColor = true;
			this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
			// 
			// comboColorspace
			// 
			this.comboColorspace.FormattingEnabled = true;
			this.comboColorspace.Location = new System.Drawing.Point(78, 31);
			this.comboColorspace.Name = "comboColorspace";
			this.comboColorspace.Size = new System.Drawing.Size(72, 21);
			this.comboColorspace.TabIndex = 4;
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabHistogram);
			this.tabControl1.Controls.Add(this.tabDct);
			this.tabControl1.Location = new System.Drawing.Point(3, 81);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(394, 389);
			this.tabControl1.TabIndex = 0;
			// 
			// tabHistogram
			// 
			this.tabHistogram.Controls.Add(this.pictureHistogram);
			this.tabHistogram.Location = new System.Drawing.Point(4, 22);
			this.tabHistogram.Name = "tabHistogram";
			this.tabHistogram.Padding = new System.Windows.Forms.Padding(3);
			this.tabHistogram.Size = new System.Drawing.Size(386, 363);
			this.tabHistogram.TabIndex = 0;
			this.tabHistogram.Tag = "histogram";
			this.tabHistogram.Text = "histogram";
			this.tabHistogram.UseVisualStyleBackColor = true;
			// 
			// pictureHistogram
			// 
			this.pictureHistogram.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureHistogram.Location = new System.Drawing.Point(0, 0);
			this.pictureHistogram.Name = "pictureHistogram";
			this.pictureHistogram.Size = new System.Drawing.Size(386, 363);
			this.pictureHistogram.TabIndex = 0;
			this.pictureHistogram.TabStop = false;
			this.pictureHistogram.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureHistogram_Paint);
			// 
			// tabDct
			// 
			this.tabDct.Controls.Add(this.pictureDct);
			this.tabDct.Location = new System.Drawing.Point(4, 22);
			this.tabDct.Name = "tabDct";
			this.tabDct.Padding = new System.Windows.Forms.Padding(3);
			this.tabDct.Size = new System.Drawing.Size(386, 363);
			this.tabDct.TabIndex = 1;
			this.tabDct.Tag = "dct";
			this.tabDct.Text = "dct";
			this.tabDct.UseVisualStyleBackColor = true;
			// 
			// pictureDct
			// 
			this.pictureDct.Location = new System.Drawing.Point(0, 0);
			this.pictureDct.Name = "pictureDct";
			this.pictureDct.Size = new System.Drawing.Size(390, 363);
			this.pictureDct.TabIndex = 0;
			this.pictureDct.TabStop = false;
			this.pictureDct.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureDct_Paint);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(44, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(28, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "area";
			// 
			// textArea
			// 
			this.textArea.Location = new System.Drawing.Point(78, 5);
			this.textArea.Name = "textArea";
			this.textArea.Size = new System.Drawing.Size(116, 20);
			this.textArea.TabIndex = 2;
			// 
			// ZoomIn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(782, 495);
			this.Controls.Add(this.toolStripContainer1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ZoomIn";
			this.Text = "ZoomIn";
			this.Load += new System.EventHandler(this.ZoomIn_Load);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ZoomIn_KeyPress);
			this.toolBar.ResumeLayout(false);
			this.toolBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabHistogram.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureHistogram)).EndInit();
			this.tabDct.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureDct)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolButtonTop;
        private System.Windows.Forms.ToolStripButton toolSave;
        private System.Windows.Forms.ToolStripButton toolRefresh;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHistogram;
        private System.Windows.Forms.TabPage tabDct;
        private System.Windows.Forms.PictureBox pictureHistogram;
        private System.Windows.Forms.TextBox textArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkLogHistogram;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.ToolStripButton toolDragDrop;
        private System.Windows.Forms.ComboBox comboColorspace;
        private System.Windows.Forms.PictureBox pictureDct;
    }
}

