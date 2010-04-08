using System.Drawing;
using System.Windows.Forms;

namespace PatternMaker {
    public class ColorBox : Control {
        private Color color;

        public ColorBox()
            : this(Color.White) {
        }

        public ColorBox(Color color) {
            this.color = color;

            Size = new Size(30, 20);
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);

            e.Graphics.Clear(color);

            Pen borderPen = new Pen(Color.DarkGray);
            e.Graphics.DrawRectangle(borderPen, 0, 0, Width - 1, Height - 1);
        }

        public Color Color {
            get { return color; }
            set { color = value; }
        }
    }
}