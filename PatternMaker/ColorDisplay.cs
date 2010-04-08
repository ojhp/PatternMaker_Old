using System.Drawing;
using System.Windows.Forms;

namespace PatternMaker {
    public class ColorDisplay : Control {
        private Color main, secondary;

        /// <summary>
        /// Create a new color display with the default colors of Black and White.
        /// </summary>
        public ColorDisplay()
            : this(Color.Black, Color.White) {
        }

        /// <summary>
        /// Create a new color display with the given main and secondary colors.
        /// </summary>
        /// <param name="main">The main color for the control.</param>
        /// <param name="secondary">The secondary color for the control.</param>
        public ColorDisplay(Color main, Color secondary) {
            // Set colors
            this.main = main;
            this.secondary = secondary;

            // Set control size
            Size = new Size(50, 50);

            // Enable double buffering
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
        }

        /// <summary>
        /// Handle paint events to draw the control.
        /// </summary>
        protected override void OnPaint(PaintEventArgs e) {
            // Call base class OnPaint handler
            base.OnPaint(e);

            // Clear the control to the background color
            e.Graphics.Clear(BackColor);

            // Set up brushes and pens for the colors and borders
            Brush mainBrush = new SolidBrush(main);
            Brush secondaryBrush = new SolidBrush(secondary);
            Pen borderPen = new Pen(Color.DarkGray);

            // Draw secondary color box with border
            e.Graphics.FillRectangle(secondaryBrush, 15, 15, 30, 30);
            e.Graphics.DrawRectangle(borderPen, 14, 14, 31, 31);

            // Draw main color box with border
            e.Graphics.FillRectangle(mainBrush, 5, 5, 30, 30);
            e.Graphics.DrawRectangle(borderPen, 4, 4, 31, 31);
        }

        /// <summary>
        /// Accessor for the main color.
        /// </summary>
        public Color MainColor {
            get { return main; }
            set { main = value; }
        }

        /// <summary>
        /// Accessor for the secondary color.
        /// </summary>
        public Color SecondaryColor {
            get { return secondary; }
            set { secondary = value; }
        }
    }
}