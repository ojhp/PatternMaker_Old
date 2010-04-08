using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PatternMaker {
    public partial class PatternMakerForm : Form {
        // The filename of the current pattern
        private string filename = null;
        // Whether the pattern has been changed since the last save
        private bool changed = false;

        // Whether the control is currently highlight
        private bool highlight = false;
        // The last (x, y) coordinates of mouse action on the pattern
        private int lastX, lastY;

        public PatternMakerForm() {
            InitializeComponent();
            SetTitle();
        }

        /// <summary>
        /// Set the title of the form depending on pattern file name and pattern size.
        /// </summary>
        private void SetTitle() {
            Text = "Pattern Maker - " + (filename == null ? "unititled" : filename) +
                " (" + pattern.PatternWidth + "x" + pattern.PatternHeight + ")";
        }

        /// <summary>
        /// Handle mouse down events on the pattern.
        /// </summary>
        private void pattern_MouseDown(object sender, MouseEventArgs e) {
            // Check for handled buttons
            if(e.Button != MouseButtons.Left && e.Button != MouseButtons.Right) return;

            // Select color depending on mouse button pressed
            Color color = colorPalette1.MainColor;
            if(e.Button == MouseButtons.Right) color = colorPalette1.SecondaryColor;

            // Set highlight flag
            highlight = true;

            // Set last (x, y) coordinates
            lastX = e.X;
            lastY = e.Y;

            // Start highlight and update control
            pattern.StartHighlight(e.X, e.Y, color);
            pattern.Refresh();
        }

        /// <summary>
        /// Handle mouse movement.
        /// </summary>
        private void pattern_MouseMove(object sender, MouseEventArgs e) {
            // Check that highlight is enabled and mouse has moved to another cell
            if(!highlight || (e.X == lastX && e.Y == lastY)) return;

            // Set last (x, y) coordinates
            lastX = e.X;
            lastY = e.Y;

            // Update highlight area and refresh control
            pattern.UpdateHighlight(e.X, e.Y);
            pattern.Refresh();
        }

        /// <summary>
        /// Handle mouse up events.
        /// </summary>
        private void pattern_MouseUp(object sender, MouseEventArgs e) {
            // Check that highlight is enabled
            if(!highlight) return;

            // Update position if it has changed
            if(e.X != lastX || e.Y != lastY) {
                pattern.UpdateHighlight(e.X, e.Y);
            }

            // Finish highlight and update control.
            pattern.EndHighlight();
            pattern.Refresh();
        }
    }
}
