using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace paint
{
    class Rectangle : Chape
    {
        public override void draw(Pen pen, Point x, Point y, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(pen, new System.Drawing.Rectangle(Math.Min(x.X, y.X), Math.Min(x.Y, y.Y), Math.Abs(y.X - x.X), Math.Abs(y.Y - x.Y)));
        }
        
    }
}
