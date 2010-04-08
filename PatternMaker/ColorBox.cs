using System.Drawing;
using System.Windows.Forms;

namespace PatternMaker {
    public class ColorBox : Control {
        private Color color;

        /// <summary>
        /// Create a new color box with the default color of White.
        /// </summary>
        public ColorBox()
            : this(Color.White) {
        }

        /// <summary>
        /// Create a new color box with the given color.
        /// </summary>
        /// <param name="color">The color for the color box.</param>
        public ColorBox(Color color) {
            // Set the color
            this.color = color;

            // Set the control size
            Size = new Size(30, 20);

            // Enable double buffering
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
        }

        /// <summary>
        /// Handle paint events to draw the control to the screen.
        /// </summary>
        protected override void OnPaint(PaintEventArgs e) {
            // Call base class OnPaint handler
            base.OnPaint(e);

            // Clear the control to it's color
            e.Graphics.Clear(color);

            // Draw a border around the control
            Pen borderPen = new Pen(Color.DarkGray);
            e.Graphics.DrawRectangle(borderPen, 0, 0, Width - 1, Height - 1);
        }

        /// <summary>
        /// Accessor for the control's color.
        /// </summary>
        public Color Color {
            get { return color; }
            set { color = value; }
        }
    }
}