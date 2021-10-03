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

        bool isDrawingMode = false;
        bool isSomethingOnScreen = false;
        bool isPointChoosingMode = false;
        List<Point> polygonPoints = new List<Point>();
        SolidBrush blackBrush = new SolidBrush(Color.Black);
        Pen blackPen = new Pen(Color.Black, 3);
        Graphics g;

        void setFlags(bool isDrawingMode = false, bool showShapeSelect = false, bool isAffineTransformationsEnabled = false, bool isPointChoosing = false)
        {
            this.isDrawingMode = isDrawingMode;
            comboBoxShape.Enabled = showShapeSelect;

            textShiftX.Enabled = isAffineTransformationsEnabled;
            textShiftY.Enabled = isAffineTransformationsEnabled;
            buttonShift.Enabled = isAffineTransformationsEnabled;
            buttonRotate.Enabled = isAffineTransformationsEnabled;
            textAngle.Enabled = isAffineTransformationsEnabled;
            buttonScale.Enabled = isAffineTransformationsEnabled;
            textScale.Enabled = isAffineTransformationsEnabled;

            buttonRotateLine.Enabled = isAffineTransformationsEnabled && comboBoxShape.SelectedIndex == 1;
            buttonCrossLines.Enabled = isAffineTransformationsEnabled && comboBoxShape.SelectedIndex == 1;

            buttonClassifyPoint.Enabled = isAffineTransformationsEnabled && comboBoxShape.SelectedIndex == 1;
            buttonIsPointInPolygon.Enabled = isAffineTransformationsEnabled && comboBoxShape.SelectedIndex == 0;

            isPointChoosingMode = isPointChoosing;
            buttonСhooseCentre.Visible = isPointChoosing;
            labelChoodePoint.Visible = isPointChoosing;

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

        private void buttonShift_Click(object sender, EventArgs e)
        {

        }

        private void buttonScale_Click(object sender, EventArgs e)
        {

        }

        private void buttonСhooseCentre_Click(object sender, EventArgs e)
        {

        }

        private void buttonRotateLine_Click(object sender, EventArgs e)
        {

        }

        private void buttonCrossLines_Click(object sender, EventArgs e)
        {

        }

        private void buttonIsPointInPolygon_Click(object sender, EventArgs e)
        {

        }

        private void buttonClassifyPoint_Click(object sender, EventArgs e)
        {

        }
    }
}