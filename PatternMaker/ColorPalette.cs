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

        /// <summary>
        /// Handle mouse clicks on the color boxes.
        /// </summary>
        private void colorBox_MouseClick(object sender, MouseEventArgs e) {
            // Check for handled buttons
            if(e.Button != MouseButtons.Left && e.Button != MouseButtons.Right) return;

            // Cast sender object to color box
            ColorBox box = (ColorBox) sender;

            // Set color display color depending on which button was clicked
            if(e.Button == MouseButtons.Left) {
                colorDisplay.MainColor = box.Color;
            } else if(e.Button == MouseButtons.Right) {
                colorDisplay.SecondaryColor = box.Color;
            }

            // Update the color display control
            colorDisplay.Refresh();
        }

        /// <summary>
        /// Handle mouse double clicks on color boxes.
        /// </summary>
        private void colorBox_MouseDoubleClick(object sender, MouseEventArgs e) {
            // Check for handled buttons
            if(e.Button != MouseButtons.Left && e.Button != MouseButtons.Right) return;

            // Cast sender object to color box
            ColorBox box = (ColorBox) sender;

            // Show color chooser dialog box
            DialogResult result = colorDialog.ShowDialog(this);
            if(result == DialogResult.OK) {
                // If a color was chosen, set box color to that color
                box.Color = colorDialog.Color;

                // Set color display color depending on mouse button used
                if(e.Button == MouseButtons.Left) {
                    colorDisplay.MainColor = colorDialog.Color;
                } else if(e.Button == MouseButtons.Right) {
                    colorDisplay.SecondaryColor = colorDialog.Color;
                }

                // Update controls
                box.Refresh();
                colorDisplay.Refresh();
            }
        }

        /// <summary>
        /// Accessor for the main color.
        /// </summary>
        public Color MainColor {
            get { return colorDisplay.MainColor; }
        }

        /// <summary>
        /// Accessor for the secondary color.
        /// </summary>
        public Color SecondaryColor {
            get { return colorDisplay.SecondaryColor; }
        }
    }
}
