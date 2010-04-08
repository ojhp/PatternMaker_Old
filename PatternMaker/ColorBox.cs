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
        }

        public Color Color {
            get { return color; }
            set { color = value; }
        }
    }
}