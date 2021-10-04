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
        private void buttonPolygon_Click(object sender, EventArgs e)
        {
            canvas.Image = new Bitmap(1300, 900);
            polygonPoints.Clear();
            if (!isSomethingOnScreen)
            {
                setFlags(isDrawingMode:true);
                comboBoxShape.SelectedIndex = 0;
                buttonPolygon.Text = "Очистить";
            }
            else
            {
                buttonPolygon.Text = "Нарисовать что-нибудь";
                setFlags();
            }
            isSomethingOnScreen = !isSomethingOnScreen;
        }
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
                    setFlags(isAffineTransformationsEnabled: true);
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

        void redrawPolygon()
        {
            g.Clear(Color.White);
            if(polygonPoints.Count == 1)
            {
                g.FillEllipse(blackBrush, polygonPoints[0].X - 3, polygonPoints[0].Y - 3, 7, 7);
            }
            for(int i = 1; i < polygonPoints.Count; i++)
            {
                g.DrawLine(blackPen, polygonPoints[i - 1], polygonPoints[i]);
            }
            if(polygonPoints.Count > 2)
            {
                g.DrawLine(blackPen, polygonPoints.First(), polygonPoints.Last());
            }
        }

        void drawLine(MouseEventArgs e)
        {
            polygonPoints.Add(e.Location);
            if (polygonPoints.Count > 1)
            {
                g.DrawLine(blackPen, polygonPoints.First(), e.Location);
                setFlags(isAffineTransformationsEnabled: true);
                return;
            }
            else
            {
                g.FillEllipse(blackBrush, e.X-3, e.Y-3, 7, 7);
            }
        }

        void drawPoint(MouseEventArgs e)
        {
            polygonPoints.Add(e.Location);
            g.FillEllipse(blackBrush,e.X-3,e.Y-3,7,7);
            setFlags(isAffineTransformationsEnabled: true);
        }
    }
}
