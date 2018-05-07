using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace paint
{
    class Line : Chape  
    {
        public override void draw(Pen pen, Point x, Point y, PaintEventArgs e)
        {
            e.Graphics.DrawLine(pen, x, y);
        }
    }
}
