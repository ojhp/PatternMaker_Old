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
            this.pattern = new PatternMaker.Pattern();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.colorPalette1 = new PatternMaker.ColorPalette();
            this.panel1.SuspendLayout();
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
            // menu
            // 
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(584, 24);
            this.menu.TabIndex = 2;
            this.menu.Text = "menuStrip1";
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
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColorPalette colorPalette1;
        private System.Windows.Forms.Panel panel1;
        private Pattern pattern;
        private System.Windows.Forms.MenuStrip menu;
    }
}