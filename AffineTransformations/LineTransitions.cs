using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AffineTransformations
{
    partial class Form1
    {
        private void buttonRotateLine_Click(object sender, EventArgs e)
        {
           // buttonСhooseCentre.Visible = false;
            textAngle.Text = "90";//по условию, повернуть ребро вокруг центра на 90 градусов
            //координата центра отрезка
            Point p1 = polygonPoints[0];
            Point p2 = polygonPoints[1];
            Point pnew = new Point((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2);//ищем центр отрезка
            rotateAroundPoint(pnew, canvas.Size);//поворачиваем
            g.Clear(Color.White);
            g.DrawLine(blackPen,polygonPoints[0], polygonPoints[1]);
            textAngle.Clear();//для последующей работы


        }

        private void buttonCrossLines_Click(object sender, EventArgs e)
        {

        }

    }
}
