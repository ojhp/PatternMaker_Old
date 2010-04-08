﻿namespace PatternMaker {
    partial class ColorPalette {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.colorDisplay1 = new PatternMaker.ColorDisplay();
            this.colorBox1 = new PatternMaker.ColorBox();
            this.colorBox2 = new PatternMaker.ColorBox();
            this.colorBox3 = new PatternMaker.ColorBox();
            this.colorBox4 = new PatternMaker.ColorBox();
            this.colorBox5 = new PatternMaker.ColorBox();
            this.colorBox6 = new PatternMaker.ColorBox();
            this.colorBox7 = new PatternMaker.ColorBox();
            this.colorBox8 = new PatternMaker.ColorBox();
            this.colorBox9 = new PatternMaker.ColorBox();
            this.colorBox10 = new PatternMaker.ColorBox();
            this.SuspendLayout();
            // 
            // colorDisplay1
            // 
            this.colorDisplay1.Location = new System.Drawing.Point(12, 0);
            this.colorDisplay1.MainColor = System.Drawing.Color.Black;
            this.colorDisplay1.Name = "colorDisplay1";
            this.colorDisplay1.SecondaryColor = System.Drawing.Color.White;
            this.colorDisplay1.Size = new System.Drawing.Size(50, 50);
            this.colorDisplay1.TabIndex = 0;
            this.colorDisplay1.Text = "colorDisplay1";
            // 
            // colorBox1
            // 
            this.colorBox1.Color = System.Drawing.Color.Black;
            this.colorBox1.Location = new System.Drawing.Point(3, 56);
            this.colorBox1.Name = "colorBox1";
            this.colorBox1.Size = new System.Drawing.Size(30, 20);
            this.colorBox1.TabIndex = 1;
            this.colorBox1.Text = "colorBox1";
            // 
            // colorBox2
            // 
            this.colorBox2.Color = System.Drawing.Color.White;
            this.colorBox2.Location = new System.Drawing.Point(39, 56);
            this.colorBox2.Name = "colorBox2";
            this.colorBox2.Size = new System.Drawing.Size(30, 20);
            this.colorBox2.TabIndex = 2;
            this.colorBox2.Text = "colorBox2";
            // 
            // colorBox3
            // 
            this.colorBox3.Color = System.Drawing.Color.Red;
            this.colorBox3.Location = new System.Drawing.Point(3, 82);
            this.colorBox3.Name = "colorBox3";
            this.colorBox3.Size = new System.Drawing.Size(30, 20);
            this.colorBox3.TabIndex = 3;
            this.colorBox3.Text = "colorBox3";
            // 
            // colorBox4
            // 
            this.colorBox4.Color = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.colorBox4.Location = new System.Drawing.Point(39, 82);
            this.colorBox4.Name = "colorBox4";
            this.colorBox4.Size = new System.Drawing.Size(30, 20);
            this.colorBox4.TabIndex = 4;
            this.colorBox4.Text = "colorBox4";
            // 
            // colorBox5
            // 
            this.colorBox5.Color = System.Drawing.Color.Yellow;
            this.colorBox5.Location = new System.Drawing.Point(3, 108);
            this.colorBox5.Name = "colorBox5";
            this.colorBox5.Size = new System.Drawing.Size(30, 20);
            this.colorBox5.TabIndex = 5;
            this.colorBox5.Text = "colorBox5";
            // 
            // colorBox6
            // 
            this.colorBox6.Color = System.Drawing.Color.Lime;
            this.colorBox6.Location = new System.Drawing.Point(39, 108);
            this.colorBox6.Name = "colorBox6";
            this.colorBox6.Size = new System.Drawing.Size(30, 20);
            this.colorBox6.TabIndex = 6;
            this.colorBox6.Text = "colorBox6";
            // 
            // colorBox7
            // 
            this.colorBox7.Color = System.Drawing.Color.Cyan;
            this.colorBox7.Location = new System.Drawing.Point(3, 134);
            this.colorBox7.Name = "colorBox7";
            this.colorBox7.Size = new System.Drawing.Size(30, 20);
            this.colorBox7.TabIndex = 7;
            this.colorBox7.Text = "colorBox7";
            // 
            // colorBox8
            // 
            this.colorBox8.Color = System.Drawing.Color.Blue;
            this.colorBox8.Location = new System.Drawing.Point(39, 134);
            this.colorBox8.Name = "colorBox8";
            this.colorBox8.Size = new System.Drawing.Size(30, 20);
            this.colorBox8.TabIndex = 8;
            this.colorBox8.Text = "colorBox8";
            // 
            // colorBox9
            // 
            this.colorBox9.Color = System.Drawing.Color.Fuchsia;
            this.colorBox9.Location = new System.Drawing.Point(3, 160);
            this.colorBox9.Name = "colorBox9";
            this.colorBox9.Size = new System.Drawing.Size(30, 20);
            this.colorBox9.TabIndex = 9;
            this.colorBox9.Text = "colorBox9";
            // 
            // colorBox10
            // 
            this.colorBox10.Color = System.Drawing.Color.Silver;
            this.colorBox10.Location = new System.Drawing.Point(39, 160);
            this.colorBox10.Name = "colorBox10";
            this.colorBox10.Size = new System.Drawing.Size(30, 20);
            this.colorBox10.TabIndex = 10;
            this.colorBox10.Text = "colorBox10";
            // 
            // ColorPalette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.colorBox10);
            this.Controls.Add(this.colorBox9);
            this.Controls.Add(this.colorBox8);
            this.Controls.Add(this.colorBox7);
            this.Controls.Add(this.colorBox6);
            this.Controls.Add(this.colorBox5);
            this.Controls.Add(this.colorBox4);
            this.Controls.Add(this.colorBox3);
            this.Controls.Add(this.colorBox2);
            this.Controls.Add(this.colorBox1);
            this.Controls.Add(this.colorDisplay1);
            this.Name = "ColorPalette";
            this.Size = new System.Drawing.Size(72, 185);
            this.ResumeLayout(false);

        }

        #endregion

        private ColorDisplay colorDisplay1;
        private ColorBox colorBox1;
        private ColorBox colorBox2;
        private ColorBox colorBox3;
        private ColorBox colorBox4;
        private ColorBox colorBox5;
        private ColorBox colorBox6;
        private ColorBox colorBox7;
        private ColorBox colorBox8;
        private ColorBox colorBox9;
        private ColorBox colorBox10;


    }
}
