using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ResizingApp
{
    public class RoundedPictureBox : PictureBox
    {
        public int CornerRadius { get; set; } = 20;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (GraphicsPath path = new GraphicsPath())
            {
                Rectangle bounds = ClientRectangle;
                bounds.Width--;
                bounds.Height--;
                int diameter = CornerRadius * 2;
                path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
                path.AddArc(bounds.X + bounds.Width - diameter, bounds.Y, diameter, diameter, 270, 90);
                path.AddArc(bounds.X + bounds.Width - diameter, bounds.Y + bounds.Height - diameter, diameter, diameter, 0, 90);
                path.AddArc(bounds.X, bounds.Y + bounds.Height - diameter, diameter, diameter, 90, 90);
                path.CloseFigure();
                Region = new Region(path);
            }
        }
    }
}
