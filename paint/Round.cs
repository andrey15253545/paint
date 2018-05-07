using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace paint
{
    class Round : Chape
    {
        public override void draw(Pen pen, Point x, Point y, PaintEventArgs e)
        {
            int l = Math.Min(Math.Abs(x.X - y.X), Math.Abs(x.Y - y.Y));
            x.X = Math.Max(x.X-l, Math.Min(x.X, y.X));
            x.Y= Math.Max(x.Y-l,Math.Min(x.Y, y.Y)); 
            e.Graphics.DrawEllipse(pen, new System.Drawing.Rectangle(x, new Size(l, l)));            
        }
    }
}
