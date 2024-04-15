using System;
using System.Drawing;
using System.Windows.Forms;

#region Allows you to drag a window across the screen by clinging to the header

namespace wardrobe
{
    public class HeaderMouseMove
    {
        private Point _lastPoint;

        public void MoveForm(MouseEventArgs e, Form form)
        {
            if (e.Button == MouseButtons.Left)
            {
                form.Left += e.X - _lastPoint.X;
                form.Top += e.Y - _lastPoint.Y;
            }
        }

        public void SetLastPoint(MouseEventArgs e)
        {
            _lastPoint = new Point(e.X, e.Y);
        }
    }
}

#endregion