using System.Drawing;
using System.Windows.Forms;

namespace PatternMaker {
    public class Pattern : Control {
        // The width and height of the pattern grid
        private int width, height;
        // The width and height of the grid cells
        private int cellWidth, cellHeight;
        // The bitmap image containing the colour of each cell in the grid
        private Bitmap image;

        // The highlight enable/disable flag.
        private bool highlightEnabled = false;
        // The coordinates of the rectangle of the highlight area.
        private Rectangle highlightArea;
        // The color of the highlight area.
        private Color highlightColor;

        /// <summary>
        /// Create a new pattern with the given width and height. The default initial color of
        /// white and cell dimensions of 10x10 will be used.
        /// </summary>
        /// <param name="width">The pattern's width in cells.</param>
        /// <param name="height">The pattern's height in cells.</param>
        public Pattern(int width, int height)
            : this(width, height, Color.White) {
        }

        /// <summary>
        /// Create a new pattern with the given width, height and initial color. The default cell
        /// dimensions of 10x10 will be used.
        /// </summary>
        /// <param name="width">The pattern's width in cells.</param>
        /// <param name="height">The pattern's height in cells.</param>
        /// <param name="color">The initial color for all cells in the pattern.</param>
        public Pattern(int width, int height, Color color)
            : this(width, height, color, 10, 10) {
        }
    
        /// <summary>
        /// Create a new pattern with the given width, height, initial color and cell dimensions.
        /// </summary>
        /// <param name="width">The pattern's width in cells.</param>
        /// <param name="height">The pattern's height in cells.</param>
        /// <param name="color">The initial color for all cells in the pattern.</param>
        /// <param name="cellWidth">The width of each cell in the pattern.</param>
        /// <param name="cellHeight">The height of each cell in the pattern.</param>
        public Pattern(int width, int height, Color color, int cellWidth, int cellHeight) {
            // Copy grid and cell dimensions
            this.width = width;
            this.height = height;
            this.cellWidth = cellWidth;
            this.cellHeight = cellHeight;

            // Create color array and set all cells to initial color
            image = new Bitmap(width, height);
            Graphics.FromImage(image).Clear(color);

            // Calculate control size
            CalculateControlSize();

            // Set component style options for double buffering
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
        }

        private void CalculateControlSize() {
            Width = width * cellWidth + width + 1;
            Height = height * cellHeight + height + 1;
        }

        /// <summary>
        /// Paint the pattern onto the control.
        /// </summary>
        protected override void OnPaint(PaintEventArgs e) {
            // Call base class OnPaint method
            base.OnPaint(e);

            // Paint background color
            Brush background = new SolidBrush(BackColor);
            e.Graphics.FillRectangle(background, 0, 0, Width, Height);

            // Paint cells
            for(int y = 0; y < height; y++) {
                for(int x = 0; x < width; x++) {
                    Brush brush = new SolidBrush(image.GetPixel(x, y));
                    e.Graphics.FillRectangle(brush,
                        x * cellWidth + x + 1,
                        y * cellHeight + y + 1,
                        cellWidth,
                        cellHeight);
                }
            }
        }

        /// <summary>
        /// The width of the pattern in cells.
        /// </summary>
        public int PatternWidth {
            get { return width; }
            set { width = value; CalculateControlSize(); }
        }

        /// <summary>
        /// The height of the pattern in cells.
        /// </summary>
        public int PatternHeight {
            get { return height; }
            set { height = value; CalculateControlSize(); }
        }

        /// <summary>
        /// The width of the cells in the pattern.
        /// </summary>
        public int CellWidth {
            get { return cellWidth; }
            set { cellHeight = value; CalculateControlSize(); }
        }

        /// <summary>
        /// The height of the cells in the pattern.
        /// </summary>
        public int CellHeight {
            get { return cellHeight; }
            set { cellHeight = value; CalculateControlSize(); }
        }

        /// <summary>
        /// The image made up from the color of each cell in the pattern. Each cell is equivalent to
        /// one pixel in the image.
        /// </summary>
        public Bitmap Image {
            get { return image; }
            set {
                // Copy image bitmap
                image = new Bitmap(value);

                // Set width and height of pattern
                width = image.Width;
                height = image.Height;

                // Calculate control size
                CalculateControlSize();
            }
        }

        /// <summary>
        /// Start highlighting an area of the pattern for editing.
        /// </summary>
        /// <param name="x">The starting x coordinate of the highlight.</param>
        /// <param name="y">The starting y coordinate of the highlight.</param>
        /// <param name="color">The color for the highlight.</param>
        public void StartHighlight(int x, int y, Color color) {
            // Set up the highlight rectangle and color
            highlightArea = new Rectangle(x, y, 0, 0);
            highlightColor = color;

            // Enable the highlight
            highlightEnabled = true;
        }

        /// <summary>
        /// Alter the highlight area to form a rectangle from the initial (x, y) coordinates
        /// to the given position.
        /// </summary>
        /// <param name="x">The ending x coordinate for the highlight.</param>
        /// <param name="y">The ending y coordinate for the highlight.</param>
        public void UpdateHighlight(int x, int y) {
            // Update the width and height of the highlight area
            highlightArea.Width = x - highlightArea.X;
            highlightArea.Height = y - highlightArea.Y;
        }

        /// <summary>
        /// Finish editing the highlight and paint the highlight area into the pattern.
        /// </summary>
        public void EndHighlight() {
            // Color all cells within the highlight area
            for(int y = highlightArea.Top; y <= highlightArea.Bottom; y++) {
                for(int x = highlightArea.Left; x <= highlightArea.Right; x++) {
                    image.SetPixel(x, y, highlightColor);
                }
            }

            // Disable the highlight
            highlightEnabled = false;
        }

        /// <summary>
        /// Modified OnMouseDown handler to use pattern coordinates.
        /// </summary>
        protected override void OnMouseDown(MouseEventArgs e) {
            // Calculate coordinates within the pattern
            int x = (e.X - 1) / (cellWidth + 1);
            int y = (e.Y - 1) / (cellHeight + 1);

            // Call base handler with modified coordinates
            base.OnMouseDown(new MouseEventArgs(e.Button, e.Clicks, x, y, e.Delta));
        }

        /// <summary>
        /// Modified OnMouseUp handler to use pattern coordinates.
        /// </summary>
        protected override void OnMouseUp(MouseEventArgs e) {
            // Calculate coordinates within the pattern
            int x = (e.X - 1) / (cellWidth + 1);
            int y = (e.Y - 1) / (cellHeight + 1);

            // Call base handler with modified coordinates
            base.OnMouseUp(new MouseEventArgs(e.Button, e.Clicks, x, y, e.Delta));
        }
    }
}