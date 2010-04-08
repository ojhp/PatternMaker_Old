using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace PatternMaker {
    public partial class ColorPalette : UserControl {
        public ColorPalette() {
            InitializeComponent();
        }

        private void colorBox_MouseClick(object sender, MouseEventArgs e) {
            if(e.Button != MouseButtons.Left && e.Button != MouseButtons.Right) return;
            ColorBox box = (ColorBox) sender;

            if(e.Button == MouseButtons.Left) {
                colorDisplay.MainColor = box.Color;
            } else if(e.Button == MouseButtons.Right) {
                colorDisplay.SecondaryColor = box.Color;
            }

            colorDisplay.Refresh();
        }

        private void colorBox_MouseDoubleClick(object sender, MouseEventArgs e) {
            if(e.Button != MouseButtons.Left && e.Button != MouseButtons.Right) return;
            ColorBox box = (ColorBox) sender;

            DialogResult result = colorDialog.ShowDialog(this);
            if(result == DialogResult.OK) {
                box.Color = colorDialog.Color;

                if(e.Button == MouseButtons.Left) {
                    colorDisplay.MainColor = colorDialog.Color;
                } else if(e.Button == MouseButtons.Right) {
                    colorDisplay.SecondaryColor = colorDialog.Color;
                }

                box.Refresh();
                colorDisplay.Refresh();
            }
        }

        public Color MainColor {
            get { return colorDisplay.MainColor; }
        }

        public Color SecondaryColor {
            get { return colorDisplay.SecondaryColor; }
        }
    }
}
