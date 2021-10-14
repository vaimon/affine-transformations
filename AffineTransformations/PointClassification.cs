using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AffineTransformations
{
    partial class Form1
    {
        // Положение точки относительно направленного ребра
        // yb·xa - xb·ya > 0 => b слева от Oa    
        //               < 0 => b справа от Oa
        private void ClassifyPoint(Point edgeStart, Point edgeEnd, Point p)
        {
            int res = (p.X - edgeStart.X) * (edgeEnd.Y - edgeStart.Y) - (p.Y - edgeStart.Y) * (edgeEnd.X - edgeStart.X);
            if (res > 0)
                labelClassifyPoint.Text = "Точка находится слева от ребра";
            else if (res < 0)
                labelClassifyPoint.Text = "Точка находится справа от ребра";
            else
                labelClassifyPoint.Text = "Точка на отрезочке О_О Очень метко!";
        }

        private void PointInPolygon(Point p)
        {
            bool isConvexPolygon = true;
            bool sign = true, tempSign = true;
            Point ab = new Point(polygonPoints[1].X - polygonPoints[0].X, polygonPoints[1].Y - polygonPoints[0].Y);
            Point bc = new Point(polygonPoints[2].X - polygonPoints[1].X, polygonPoints[2].Y - polygonPoints[1].Y);
            double rot = ab.X * bc.Y - ab.Y * bc.X;
            if (rot < 0)
                sign = false;

            for (int i = 2; i < polygonPoints.Count-1; i++)
            {
                ab = new Point(polygonPoints[i].X - polygonPoints[i - 1].X, polygonPoints[i].Y - polygonPoints[i - 1].Y);
                bc = new Point(polygonPoints[i+1].X - polygonPoints[i].X, polygonPoints[i+1].Y - polygonPoints[i].Y);
                rot = ab.X * bc.Y - ab.Y * bc.X;
                if (rot < 0)
                    tempSign = false;
                if (sign != tempSign)
                    isConvexPolygon = false;
            }
            if (isConvexPolygon)
                labelConvexPolygon.Text = "Выпуклый многоугольник";
            else
                labelConvexPolygon.Text = "Невыпуклый многоугольник";

            bool inPolygon = false;
            int j = polygonPoints.Count() - 1;
            for (int i = 0; i < polygonPoints.Count(); i++)
            {
                if (polygonPoints[i].Y < p.Y && polygonPoints[j].Y >= p.Y || polygonPoints[j].Y < p.Y && polygonPoints[i].Y >= p.Y)
                    if (polygonPoints[i].X + (p.Y - polygonPoints[i].Y) / (polygonPoints[j].Y - polygonPoints[i].Y) * (polygonPoints[j].X - polygonPoints[i].X) < p.X)
                        inPolygon = !inPolygon;
                j = i;
            }
            if (inPolygon)
                labelPointInPolygon.Text = "Точка принадлежит";
            else
                labelPointInPolygon.Text = "Точка не принадлежит";
        }

        private void buttonIsPointInPolygon_Click(object sender, EventArgs e)
        {
            isPointInPolygonMode = true;

        }

        private void buttonClassifyPoint_Click(object sender, EventArgs e)
        {
            isPointClassifyMode = true;
        }
    }
}
