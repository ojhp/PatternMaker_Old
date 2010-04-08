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

            // Set change flag
            changed = true;
        }

        private void fileSaveAs_Click(object sender, EventArgs e) {
            // Create and set up save file dialog
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.AddExtension = true;
            sfd.Filter = "Pattern File|*.pat";
            sfd.Title = "Save Pattern";

            // Show dialog and save if a file is chosen
            DialogResult result = sfd.ShowDialog(this);
            if(result == DialogResult.OK) {
                // Save image file
                pattern.Image.Save(sfd.FileName);

                // Clear changed flag and set filename
                changed = false;
                filename = sfd.FileName;

                // Update title
                SetTitle();
            }
        }

        private void fileSave_Click(object sender, EventArgs e) {
            if(filename == null) {
                // If file has not been saved, handle as a save as
                fileSaveAs_Click(sender, e);
            } else {
                // Otherwise save image file
                pattern.Image.Save(filename);

                // Clear changed flag
                changed = false;
            }
        }

        private void fileExit_Click(object sender, EventArgs e) {
            Close();
        }

        private void PatternMakerForm_FormClosing(object sender, FormClosingEventArgs e) {
            if(changed) {
                // If changed since last save ask to save changes
                DialogResult result = MessageBox.Show(this,
                    "Do you want to save changes before exiting?",
                    "Save Changes",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                // Handle response
                switch(result) {
                    case DialogResult.Yes:
                        // Try saving
                        fileSave_Click(sender, e);
                        // If no saved, cancel closing
                        if(changed) e.Cancel = true;
                        break;
                    case DialogResult.Cancel:
                        // Cancel closing
                        e.Cancel = true;
                        break;
                }
            }
        }

        private void fileOpen_Click(object sender, EventArgs e) {
            if(changed) {
                // If changed since last save ask to save changes
                DialogResult result = MessageBox.Show(this,
                    "Do you want to save changes before opening a new file?",
                    "Save Changes",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                // Handle response
                switch(result) {
                    case DialogResult.Yes:
                        // Try saving
                        fileSave_Click(sender, e);
                        // If not saved, cancel open
                        if(changed) return;
                        break;
                    case DialogResult.Cancel:
                        return;
                }
            }

            // Show open file dialog
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Pattern File|*.pat";
            ofd.Multiselect = false;
            ofd.Title = "Open Pattern";
            DialogResult result2 = ofd.ShowDialog(this);

            // If file was chosen, load new image
            if(result2 == DialogResult.OK) {
                // Load image into pattern
                pattern.Image = (Bitmap) Bitmap.FromFile(ofd.FileName);

                // Set filename and changed flag
                filename = ofd.FileName;
                changed = false;
                
                // Refresh control and update form title
                pattern.Refresh();
                SetTitle();
            }
        }

        private void fileNew_Click(object sender, EventArgs e) {
            if(changed) {
                // If changed since last save ask to save changes
                DialogResult result = MessageBox.Show(this,
                    "Do you want to save changes before opening a new file?",
                    "Save Changes",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                // Handle response
                switch(result) {
                    case DialogResult.Yes:
                        // Try saving
                        fileSave_Click(sender, e);
                        // If not saved, cancel open
                        if(changed) return;
                        break;
                    case DialogResult.Cancel:
                        return;
                }
            }

            // Show size dialog and get result
            SizeDialog sd = new SizeDialog();
            sd.Text = "New Pattern";
            DialogResult result2 = sd.ShowDialog(this);

            if(result2 == DialogResult.OK) {
                // Create image for new pattern
                Bitmap bmp = new Bitmap(sd.Width, sd.Height);
                for(int y = 0; y < bmp.Height; y++) {
                    for(int x = 0; x < bmp.Width; x++) {
                        bmp.SetPixel(x, y, Color.White);
                    }
                }

                // Set filename and changed flag
                filename = null;
                changed = false;

                // Set pattern image, refresh control and set form title
                pattern.Image = bmp;
                pattern.Refresh();
                SetTitle();
            }
        }
    }
}
