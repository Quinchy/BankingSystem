using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Utils.Components
{
    internal class RoundedPanel : Panel
    {
        private Color _borderColor = Color.Silver;
        private int _borderThickness = 6;
        private int _borderThicknessByTwo = 3;
        private int _cornerRadius = 10;

        public RoundedPanel()
        {
            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush brush = new SolidBrush(_borderColor);

            // Border
            g.FillRoundedRectangle(brush, 0, 0, Width, Height, _cornerRadius);

            brush.Dispose();
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            Invalidate();
        }

        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                _borderColor = value;
                Invalidate();
            }
        }

        public int CornerRadius
        {
            get => _cornerRadius;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("CornerRadius", "The corner radius cannot be negative.");

                _cornerRadius = value;
                Invalidate();
            }
        }
    }

    // Extension method to draw a rounded rectangle
    public static class GraphicsExtensions
    {
        public static void FillRoundedRectangle(this Graphics graphics, Brush brush, float x, float y, float width, float height, float radius)
        {
            RectangleF rectangle = new RectangleF(x, y, width, height);
            float diameter = radius * 2;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(rectangle.Left, rectangle.Top, diameter, diameter, 180, 90);
            path.AddArc(rectangle.Right - diameter, rectangle.Top, diameter, diameter, 270, 90);
            path.AddArc(rectangle.Right - diameter, rectangle.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rectangle.Left, rectangle.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            graphics.FillPath(brush, path);
            path.Dispose();
        }
    }
}
