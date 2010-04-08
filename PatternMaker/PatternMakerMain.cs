using System;
using System.Windows.Forms;

namespace PatternMaker {
    public static class PatternMakerMain {
        [STAThread]
        public static void Main(string[] args) {
            Application.Run(new PatternMakerForm());
        }
    }
}