using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace paint
{
    public partial class Graph : Form
    {
        bool isMouseDown = false;
        Point startcoord, endcoord;
        Color color;
        Chape chape = new Line();
        struct all
        {
            public Chape chape;
            public Pen pen;
            public Point x, y;
        }
        all[] allchape = new all[1000];
        //List<Chape> allchape = new List<Chape> { };
        int countChape = 0;
        Pen pen = new Pen(Color.Black);
        public Graph()
        {
            InitializeComponent();
        }

        private void drawField_MouseDown(object sender, MouseEventArgs e)
        {
            startcoord.X = e.X;
            startcoord.Y = e.Y;
            isMouseDown = true;
        }

        private void drawField_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (isMouseDown)
            {
                endcoord.X = e.X;
                endcoord.Y = e.Y;
                drawField.Invalidate();
                //chape.x = startcoord;
                //chape.y = endcoord;
            }
        }

        private void drawField_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            allchape[countChape].chape = chape;
            allchape[countChape].x = startcoord;
            allchape[countChape].y = endcoord;
            allchape[countChape].pen = pen;
            countChape++;
            //allchape.Add(chape);
        }

        private void drawField_Paint(object sender, PaintEventArgs e)
        {
            chape.draw(pen, startcoord, endcoord, e);
            for (int i = 0; i < countChape; i++)
            {
                allchape[i].chape.draw(allchape[i].pen, allchape[i].x, allchape[i].y, e);
            }
            //foreach (var p in allchape)
            //{
            //    p.draw(p.pen, p.x, p.y,e);
            //}
        }

        private void pictLine_Click(object sender, EventArgs e)
        {
            chape = new Line();
        }

        private void pictSquare_Click(object sender, EventArgs e)
        {
            chape = new Square();
        }

        private void pictEllipse_Click(object sender, EventArgs e)
        {
            chape = new Ellipse();
        }

        private void pictRectangle_Click(object sender, EventArgs e)
        {
            chape = new Rectangle();
        }

        private void Triangle_Click(object sender, EventArgs e)
        {
            chape = new Triangle();
        }

        private void pictRed_Click(object sender, EventArgs e)
        {
            DialogResult dres = colorshow.ShowDialog();
            if (dres == DialogResult.OK)
            {
                color = colorshow.Color;
                pictRed.BackColor = color;
                pen = new Pen(color);
            }
        }

        private void pictRound_Click(object sender, EventArgs e)
        {
            chape = new Round();
        }

    }
}
