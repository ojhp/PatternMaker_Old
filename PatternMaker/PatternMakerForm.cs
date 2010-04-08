using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PatternMaker {
    public partial class PatternMakerForm : Form {
        private string filename = null;
        private bool changed = false;

        private int lastX, lastY;

        public PatternMakerForm() {
            InitializeComponent();
            SetTitle();
        }

        private void SetTitle() {
            Text = "Pattern Maker - " + (filename == null ? "unititled" : filename) +
                " (" + pattern.PatternWidth + "x" + pattern.PatternHeight + ")";
        }

        private void pattern_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button != MouseButtons.Left && e.Button != MouseButtons.Right) return;

            Color color = colorPalette1.MainColor;
            if(e.Button == MouseButtons.Right) color = colorPalette1.SecondaryColor;

            lastX = e.X;
            lastY = e.Y;

            pattern.StartHighlight(e.X, e.Y, color);
            pattern.Refresh();
        }

        private void pattern_MouseMove(object sender, MouseEventArgs e) {
            if(e.X == lastX && e.Y == lastY) return;

            lastX = e.X;
            lastY = e.Y;

            pattern.UpdateHighlight(e.X, e.Y);
            pattern.Refresh();
        }

        private void pattern_MouseUp(object sender, MouseEventArgs e) {
            if(e.X != lastX || e.Y != lastY) {
                pattern.UpdateHighlight(e.X, e.Y);
            }

            pattern.EndHighlight();
            pattern.Refresh();
        }
    }
}
