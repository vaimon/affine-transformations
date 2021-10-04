using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AffineTransformations
{
    partial class Form1
    {
        bool isShifting = false;
        bool isScaling = false;
        bool isRotating = false;
        private void buttonShift_Click(object sender, EventArgs e)
        {
            isShifting = true;
            setFlags(isPointChoosing: true);
        }

        private void buttonScale_Click(object sender, EventArgs e)
        {
            isScaling = true;
            setFlags(isPointChoosing: true);
        }

        private void buttonRotate_Click(object sender, EventArgs e)
        {
            isRotating = true;
            setFlags(isPointChoosing: true);
        }

        void onPointChosen(Point p)
        {
            if (isRotating)
            {
                rotateAroundPoint(p, canvas.Size);
                redrawPolygon();
            }
            else if (isScaling)
            {

            }
            else if (isShifting)
            {

            }
            setFlags(isAffineTransformationsEnabled: true);
        }

        private void buttonСhooseCentre_Click(object sender, EventArgs e)
        {
            setFlags();
            var center = new Point(0, 0);
            foreach (var p in polygonPoints)
            {
                center.X += p.X;
                center.Y += p.Y;
            }
            center.X /= polygonPoints.Count;
            center.Y /= polygonPoints.Count;
            onPointChosen(center);
        }

        private double degreesToRadians(double angle)
        {
            return Math.PI * angle / 180.0;
        }

        void rotateAroundPoint(Point rpoint, Size screenSize)
        {
            double angle = double.Parse(textAngle.Text);
            for(int i = 0; i < polygonPoints.Count; i++)
            {
                var shift1 = new Matrix(3,3).fillAffine(1, 0, 0, 1,  -rpoint.X, -rpoint.Y);
                var rotation = new Matrix(3, 3).fillAffine(Math.Cos(degreesToRadians(angle)), -Math.Sin(degreesToRadians(angle)), Math.Sin(degreesToRadians(angle)), Math.Cos(degreesToRadians(angle)), 0, 0);
                var shift2 = new Matrix(3, 3).fillAffine(1, 0, 0, 1, rpoint.X, rpoint.Y);
                var vals = new Matrix(1, 3).fill(polygonPoints[i].X, polygonPoints[i].Y, 1);
                var prom = (shift1 * rotation * shift2);
                var res = vals * prom;
                polygonPoints[i] = new Point((int)res[0,0],(int)(res[0,1]));
                
            }
        }
    }
}
