using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace paint
{
    abstract class Chape 
    {
        abstract public void draw(Pen pen, Point x, Point y, PaintEventArgs e);
    }
}
