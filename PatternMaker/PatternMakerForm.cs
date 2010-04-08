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

        public PatternMakerForm() {
            InitializeComponent();
            SetTitle();
        }

        private void SetTitle() {
            Text = "Pattern Maker - " + (filename == null ? "unititled" : filename) +
                " (" + pattern.PatternWidth + "x" + pattern.PatternHeight + ")";
        }
    }
}
