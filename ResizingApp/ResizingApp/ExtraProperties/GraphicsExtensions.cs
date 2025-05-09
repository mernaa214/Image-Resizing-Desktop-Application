using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ResizingApp
{
    public static class GraphicsExtensions
    {
        public static void DrawRoundedRectangle(this Graphics graphics, Pen pen, Rectangle rectangle, int cornerRadius)
        {
            if (graphics == null)
                throw new ArgumentNullException(nameof(graphics));

            if (pen == null)
                throw new ArgumentNullException(nameof(pen));

            int diameter = cornerRadius * 2;

            // Top-left arc
            graphics.DrawArc(pen, rectangle.Left, rectangle.Top, diameter, diameter, 180, 90);
            // Top-right arc
            graphics.DrawArc(pen, rectangle.Right - diameter, rectangle.Top, diameter, diameter, 270, 90);
            // Bottom-right arc
            graphics.DrawArc(pen, rectangle.Right - diameter, rectangle.Bottom - diameter, diameter, diameter, 0, 90);
            // Bottom-left arc
            graphics.DrawArc(pen, rectangle.Left, rectangle.Bottom - diameter, diameter, diameter, 90, 90);

            // Top and bottom lines
            graphics.DrawLine(pen, rectangle.Left + cornerRadius, rectangle.Top, rectangle.Right - cornerRadius, rectangle.Top);
            graphics.DrawLine(pen, rectangle.Left + cornerRadius, rectangle.Bottom, rectangle.Right - cornerRadius, rectangle.Bottom);

            // Left and right lines
            graphics.DrawLine(pen, rectangle.Left, rectangle.Top + cornerRadius, rectangle.Left, rectangle.Bottom - cornerRadius);
            graphics.DrawLine(pen, rectangle.Right, rectangle.Top + cornerRadius, rectangle.Right, rectangle.Bottom - cornerRadius);
        }
    }
}
