using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PatternMaker {
    public partial class SizeDialog : Form {
        public SizeDialog() {
            InitializeComponent();
        }

        public int Width {
            get { return (int) width.Value; }
            set { width.Value = value; }
        }

        public int Height {
            get { return (int) height.Value; }
            set { height.Value = value; }
        }

        private void okButton_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
