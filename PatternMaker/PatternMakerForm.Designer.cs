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
            this.colorPalette1 = new PatternMaker.ColorPalette();
            this.pattern = new PatternMaker.Pattern();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pattern);
            this.panel1.Location = new System.Drawing.Point(78, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 371);
            this.panel1.TabIndex = 1;
            // 
            // colorPalette1
            // 
            this.colorPalette1.Location = new System.Drawing.Point(0, 0);
            this.colorPalette1.Name = "colorPalette1";
            this.colorPalette1.Size = new System.Drawing.Size(72, 185);
            this.colorPalette1.TabIndex = 0;
            // 
            // pattern
            // 
            this.pattern.CellHeight = 10;
            this.pattern.CellWidth = 10;
            this.pattern.Image = ((System.Drawing.Bitmap) (resources.GetObject("pattern.Image")));
            this.pattern.Location = new System.Drawing.Point(-1, -1);
            this.pattern.Name = "pattern";
            this.pattern.PatternHeight = 20;
            this.pattern.PatternWidth = 20;
            this.pattern.Size = new System.Drawing.Size(221, 221);
            this.pattern.TabIndex = 0;
            this.pattern.Text = "pattern1";
            // 
            // PatternMakerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 370);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.colorPalette1);
            this.Name = "PatternMakerForm";
            this.Text = "PatternMakerForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ColorPalette colorPalette1;
        private System.Windows.Forms.Panel panel1;
        private Pattern pattern;
    }
}