namespace PatternMaker {
    partial class PatternMakerForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatternMakerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.fileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.fileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.patternMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.patternSize = new System.Windows.Forms.ToolStripMenuItem();
            this.patternCellSize = new System.Windows.Forms.ToolStripMenuItem();
            this.pattern = new PatternMaker.Pattern();
            this.colorPalette1 = new PatternMaker.ColorPalette();
            this.panel1.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pattern);
            this.panel1.Location = new System.Drawing.Point(73, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 344);
            this.panel1.TabIndex = 1;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.patternMenu});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(584, 24);
            this.menu.TabIndex = 2;
            this.menu.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileNew,
            this.fileOpen,
            this.fileSave,
            this.fileSaveAs,
            this.toolStripMenuItem1,
            this.fileExit});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            // 
            // fileNew
            // 
            this.fileNew.Name = "fileNew";
            this.fileNew.Size = new System.Drawing.Size(123, 22);
            this.fileNew.Text = "&New...";
            this.fileNew.Click += new System.EventHandler(this.fileNew_Click);
            // 
            // fileOpen
            // 
            this.fileOpen.Name = "fileOpen";
            this.fileOpen.Size = new System.Drawing.Size(123, 22);
            this.fileOpen.Text = "&Open...";
            this.fileOpen.Click += new System.EventHandler(this.fileOpen_Click);
            // 
            // fileSave
            // 
            this.fileSave.Name = "fileSave";
            this.fileSave.Size = new System.Drawing.Size(123, 22);
            this.fileSave.Text = "&Save";
            this.fileSave.Click += new System.EventHandler(this.fileSave_Click);
            // 
            // fileSaveAs
            // 
            this.fileSaveAs.Name = "fileSaveAs";
            this.fileSaveAs.Size = new System.Drawing.Size(123, 22);
            this.fileSaveAs.Text = "Save &As...";
            this.fileSaveAs.Click += new System.EventHandler(this.fileSaveAs_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(120, 6);
            // 
            // fileExit
            // 
            this.fileExit.Name = "fileExit";
            this.fileExit.Size = new System.Drawing.Size(123, 22);
            this.fileExit.Text = "E&xit";
            this.fileExit.Click += new System.EventHandler(this.fileExit_Click);
            // 
            // patternMenu
            // 
            this.patternMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patternSize,
            this.patternCellSize});
            this.patternMenu.Name = "patternMenu";
            this.patternMenu.Size = new System.Drawing.Size(57, 20);
            this.patternMenu.Text = "&Pattern";
            // 
            // patternSize
            // 
            this.patternSize.Name = "patternSize";
            this.patternSize.Size = new System.Drawing.Size(152, 22);
            this.patternSize.Text = "&Size...";
            this.patternSize.Click += new System.EventHandler(this.patternSize_Click);
            // 
            // patternCellSize
            // 
            this.patternCellSize.Name = "patternCellSize";
            this.patternCellSize.Size = new System.Drawing.Size(152, 22);
            this.patternCellSize.Text = "&Cell Size...";
            this.patternCellSize.Click += new System.EventHandler(this.patternCellSize_Click);
            // 
            // pattern
            // 
            this.pattern.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pattern.CellHeight = 10;
            this.pattern.CellWidth = 10;
            this.pattern.Image = ((System.Drawing.Bitmap) (resources.GetObject("pattern.Image")));
            this.pattern.Location = new System.Drawing.Point(0, 0);
            this.pattern.Name = "pattern";
            this.pattern.PatternHeight = 20;
            this.pattern.PatternWidth = 20;
            this.pattern.Size = new System.Drawing.Size(221, 221);
            this.pattern.TabIndex = 0;
            this.pattern.Text = "pattern1";
            this.pattern.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pattern_MouseMove);
            this.pattern.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pattern_MouseDown);
            this.pattern.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pattern_MouseUp);
            // 
            // colorPalette1
            // 
            this.colorPalette1.Location = new System.Drawing.Point(0, 27);
            this.colorPalette1.Name = "colorPalette1";
            this.colorPalette1.Size = new System.Drawing.Size(72, 185);
            this.colorPalette1.TabIndex = 0;
            // 
            // PatternMakerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 370);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.colorPalette1);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "PatternMakerForm";
            this.Text = "PatternMaker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PatternMakerForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColorPalette colorPalette1;
        private System.Windows.Forms.Panel panel1;
        private Pattern pattern;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem fileNew;
        private System.Windows.Forms.ToolStripMenuItem fileOpen;
        private System.Windows.Forms.ToolStripMenuItem fileSave;
        private System.Windows.Forms.ToolStripMenuItem fileSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileExit;
        private System.Windows.Forms.ToolStripMenuItem patternMenu;
        private System.Windows.Forms.ToolStripMenuItem patternSize;
        private System.Windows.Forms.ToolStripMenuItem patternCellSize;
    }
}