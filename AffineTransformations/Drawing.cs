using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AffineTransformations
{
    public partial class Form1
    {
        void drawPolygon(MouseEventArgs e)
        {
            if (polygonPoints.Count > 0)
            {
                if (polygonPoints.Count == 1)
                {
                    g.Clear(Color.White);
                }
                if (Math.Abs(polygonPoints[0].X - e.X) * Math.Abs(polygonPoints[0].Y - e.Y) < 25)
                {
                    g.DrawLine(blackPen, polygonPoints.Last(), polygonPoints[0]);
                    setFlags();
                    return;
                }
                g.DrawLine(blackPen, polygonPoints.Last(), e.Location);
                polygonPoints.Add(e.Location);
            }
            else
            {
                polygonPoints.Add(e.Location);
                g.FillEllipse(blackBrush, e.X - 2, e.Y - 2, 5, 5);
            }
        }

        void drawLine(MouseEventArgs e)
        {
            polygonPoints.Add(e.Location);
            if (polygonPoints.Count > 1)
            {
                g.Clear(Color.White);
                g.DrawLine(blackPen, polygonPoints.First(), e.Location);
                setFlags();
                return;
            }
            else
            {
                g.FillEllipse(blackBrush, e.X, e.Y, 5, 5);
            }
        }

        void drawPoint(MouseEventArgs e)
        {
            polygonPoints.Add(e.Location);
            g.FillEllipse(blackBrush,e.X-3,e.Y-3,7,7);
            setFlags();
        }
    }
}
