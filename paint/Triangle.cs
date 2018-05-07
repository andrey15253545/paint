using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace paint
{
    class Triangle : Chape
    {
        public override void draw(Pen pen, Point x, Point y, PaintEventArgs e)
        {
            e.Graphics.DrawLine(pen, x, y);
            e.Graphics.DrawLine(pen, x, new Point(x.X - y.X + x.X, y.Y));
            e.Graphics.DrawLine(pen, y, new Point(x.X - y.X + x.X, y.Y));
        }
    }
}
