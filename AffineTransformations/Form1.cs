using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AffineTransformations
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool isDrawingMode = false;
        public List<Point> polygonPoints = new List<Point>();
        public SolidBrush blackBrush = new SolidBrush(Color.Black);
        public Pen blackPen = new Pen(Color.Black, 3);
        public Graphics g;

        void setFlags(bool isDrawingMode = false, bool showShapeSelect = false)
        {
            this.isDrawingMode = isDrawingMode;
            comboBoxShape.Visible = showShapeSelect;
        }

        private void buttonPolygon_Click(object sender, EventArgs e)
        {
            canvas.Image = new Bitmap(1300, 900);
            setFlags(true,true);
            comboBoxShape.SelectedIndex = 0;
            polygonPoints.Clear();
            g = canvas.CreateGraphics();
        }

        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (isDrawingMode)
            {
                switch (comboBoxShape.SelectedIndex)
                {
                    case 0: drawPolygon(e); break;
                    case 1: drawLine(e); break;
                    case 2: drawPoint(e); break;
                }
            }
            
        }

        private void comboBoxShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            canvas.Image = new Bitmap(1300, 900);
            polygonPoints.Clear();
        }
    }
}