using System.Drawing;
using System.Windows.Forms;

namespace PatternMaker {
    public class ColorDisplay : Control {
        private Color main, secondary;

        public ColorDisplay()
            : this(Color.Black, Color.White) {
        }

        public ColorDisplay(Color main, Color secondary) {
            this.main = main;
            this.secondary = secondary;

            Size = new Size(50, 50);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);

            e.Graphics.Clear(BackColor);

            Brush mainBrush = new SolidBrush(main);
            Brush secondaryBrush = new SolidBrush(secondary);
            Pen borderPen = new Pen(Color.DarkGray);

            e.Graphics.FillRectangle(secondaryBrush, 15, 15, 30, 30);
            e.Graphics.DrawRectangle(borderPen, 14, 14, 31, 31);
            e.Graphics.FillRectangle(mainBrush, 5, 5, 30, 30);
            e.Graphics.DrawRectangle(borderPen, 4, 4, 31, 31);
        }

        public Color MainColor {
            get { return main; }
            set { main = value; }
        }

        public Color SecondaryColor {
            get { return secondary; }
            set { secondary = value; }
        }
    }
}