using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Utils.Components
{
    internal class RoundedBorderPanel : Panel
    {
        private Color BorderColor = Color.Silver;
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            int cornerRadius = 20; // Change this value to adjust the corner radius
            Rectangle bounds = new Rectangle(0, 0, Width - 1, Height - 1); // Adjusted bounds
            using (GraphicsPath path = RoundedRect(bounds, cornerRadius))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.FillPath(new SolidBrush(BackColor), path);
                e.Graphics.DrawPath(new Pen(BorderColor, 1), path); // Set BorderColor to the color of your choice
            }
        }

        public static GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            // Top left arc  
            path.AddArc(arc, 180, 90);

            // Top right arc  
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // Bottom right arc  
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // Bottom left arc 
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }
    }
}
