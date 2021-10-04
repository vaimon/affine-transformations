
namespace AffineTransformations
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.canvas = new System.Windows.Forms.PictureBox();
            this.buttonPolygon = new System.Windows.Forms.Button();
            this.chooseFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.comboBoxShape = new System.Windows.Forms.ComboBox();
            this.buttonShift = new System.Windows.Forms.Button();
            this.textShiftX = new System.Windows.Forms.TextBox();
            this.textShiftY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRotate = new System.Windows.Forms.Button();
            this.textAngle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonScale = new System.Windows.Forms.Button();
            this.textScale = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonСhooseCentre = new System.Windows.Forms.Button();
            this.labelChoodePoint = new System.Windows.Forms.Label();
            this.buttonRotateLine = new System.Windows.Forms.Button();
            this.buttonCrossLines = new System.Windows.Forms.Button();
            this.buttonIsPointInPolygon = new System.Windows.Forms.Button();
            this.buttonClassifyPoint = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Right;
            this.canvas.Location = new System.Drawing.Point(262, 0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(1300, 900);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseClick);
            // 
            // buttonPolygon
            // 
            this.buttonPolygon.Location = new System.Drawing.Point(21, 156);
            this.buttonPolygon.Name = "buttonPolygon";
            this.buttonPolygon.Size = new System.Drawing.Size(226, 43);
            this.buttonPolygon.TabIndex = 1;
            this.buttonPolygon.Text = "Нарисовать что-нибудь";
            this.buttonPolygon.UseVisualStyleBackColor = true;
            this.buttonPolygon.Click += new System.EventHandler(this.buttonPolygon_Click);
            // 
            // chooseFileDialog
            // 
            this.chooseFileDialog.Filter = "Картинки|*.jpeg;*.jpg";
            this.chooseFileDialog.InitialDirectory = "C:\\Users\\niko1\\Desktop\\images";
            // 
            // colorDialog
            // 
            this.colorDialog.Color = System.Drawing.Color.DarkRed;
            // 
            // comboBoxShape
            // 
            this.comboBoxShape.Enabled = false;
            this.comboBoxShape.FormattingEnabled = true;
            this.comboBoxShape.Items.AddRange(new object[] {
            "Полигон",
            "Отрезок",
            "Точка"});
            this.comboBoxShape.Location = new System.Drawing.Point(21, 205);
            this.comboBoxShape.Name = "comboBoxShape";
            this.comboBoxShape.Size = new System.Drawing.Size(226, 33);
            this.comboBoxShape.TabIndex = 2;
            this.comboBoxShape.SelectedIndexChanged += new System.EventHandler(this.comboBoxShape_SelectedIndexChanged);
            // 
            // buttonShift
            // 
            this.buttonShift.Enabled = false;
            this.buttonShift.Location = new System.Drawing.Point(21, 310);
            this.buttonShift.Name = "buttonShift";
            this.buttonShift.Size = new System.Drawing.Size(226, 43);
            this.buttonShift.TabIndex = 1;
            this.buttonShift.Text = "Сместить";
            this.buttonShift.UseVisualStyleBackColor = true;
            this.buttonShift.Click += new System.EventHandler(this.buttonShift_Click);
            // 
            // textShiftX
            // 
            this.textShiftX.Enabled = false;
            this.textShiftX.Location = new System.Drawing.Point(54, 273);
            this.textShiftX.MaxLength = 5;
            this.textShiftX.Name = "textShiftX";
            this.textShiftX.Size = new System.Drawing.Size(69, 31);
            this.textShiftX.TabIndex = 3;
            // 
            // textShiftY
            // 
            this.textShiftY.Enabled = false;
            this.textShiftY.Location = new System.Drawing.Point(178, 273);
            this.textShiftY.MaxLength = 5;
            this.textShiftY.Name = "textShiftY";
            this.textShiftY.Size = new System.Drawing.Size(69, 31);
            this.textShiftY.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Х:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y:";
            // 
            // buttonRotate
            // 
            this.buttonRotate.Enabled = false;
            this.buttonRotate.Location = new System.Drawing.Point(21, 397);
            this.buttonRotate.Name = "buttonRotate";
            this.buttonRotate.Size = new System.Drawing.Size(226, 43);
            this.buttonRotate.TabIndex = 1;
            this.buttonRotate.Text = "Повернуть";
            this.buttonRotate.UseVisualStyleBackColor = true;
            this.buttonRotate.Click += new System.EventHandler(this.buttonRotate_Click);
            // 
            // textAngle
            // 
            this.textAngle.Enabled = false;
            this.textAngle.Location = new System.Drawing.Point(111, 360);
            this.textAngle.MaxLength = 5;
            this.textAngle.Name = "textAngle";
            this.textAngle.Size = new System.Drawing.Size(136, 31);
            this.textAngle.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Градусы:";
            // 
            // buttonScale
            // 
            this.buttonScale.Enabled = false;
            this.buttonScale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonScale.Location = new System.Drawing.Point(21, 484);
            this.buttonScale.Name = "buttonScale";
            this.buttonScale.Size = new System.Drawing.Size(226, 43);
            this.buttonScale.TabIndex = 1;
            this.buttonScale.Text = "Отмасштабировать";
            this.buttonScale.UseVisualStyleBackColor = true;
            this.buttonScale.Click += new System.EventHandler(this.buttonScale_Click);
            // 
            // textScale
            // 
            this.textScale.Enabled = false;
            this.textScale.Location = new System.Drawing.Point(62, 446);
            this.textScale.MaxLength = 5;
            this.textScale.Name = "textScale";
            this.textScale.Size = new System.Drawing.Size(69, 31);
            this.textScale.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "cХ:";
            // 
            // buttonСhooseCentre
            // 
            this.buttonСhooseCentre.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonСhooseCentre.Enabled = false;
            this.buttonСhooseCentre.Location = new System.Drawing.Point(58, 63);
            this.buttonСhooseCentre.Name = "buttonСhooseCentre";
            this.buttonСhooseCentre.Size = new System.Drawing.Size(146, 43);
            this.buttonСhooseCentre.TabIndex = 1;
            this.buttonСhooseCentre.Text = "Выбрать центр";
            this.buttonСhooseCentre.UseVisualStyleBackColor = false;
            this.buttonСhooseCentre.Visible = false;
            this.buttonСhooseCentre.Click += new System.EventHandler(this.buttonСhooseCentre_Click);
            // 
            // labelChoodePoint
            // 
            this.labelChoodePoint.AutoSize = true;
            this.labelChoodePoint.BackColor = System.Drawing.SystemColors.Control;
            this.labelChoodePoint.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelChoodePoint.Location = new System.Drawing.Point(12, 9);
            this.labelChoodePoint.Name = "labelChoodePoint";
            this.labelChoodePoint.Size = new System.Drawing.Size(239, 38);
            this.labelChoodePoint.TabIndex = 4;
            this.labelChoodePoint.Text = "Выберите точку";
            this.labelChoodePoint.Visible = false;
            // 
            // buttonRotateLine
            // 
            this.buttonRotateLine.Enabled = false;
            this.buttonRotateLine.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRotateLine.Location = new System.Drawing.Point(21, 562);
            this.buttonRotateLine.Name = "buttonRotateLine";
            this.buttonRotateLine.Size = new System.Drawing.Size(226, 43);
            this.buttonRotateLine.TabIndex = 1;
            this.buttonRotateLine.Text = "Повернуть ребро на 90º";
            this.buttonRotateLine.UseVisualStyleBackColor = true;
            this.buttonRotateLine.Click += new System.EventHandler(this.buttonRotateLine_Click);
            // 
            // buttonCrossLines
            // 
            this.buttonCrossLines.Enabled = false;
            this.buttonCrossLines.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCrossLines.Location = new System.Drawing.Point(21, 611);
            this.buttonCrossLines.Name = "buttonCrossLines";
            this.buttonCrossLines.Size = new System.Drawing.Size(226, 43);
            this.buttonCrossLines.TabIndex = 1;
            this.buttonCrossLines.Text = "Пересечь рёбра";
            this.buttonCrossLines.UseVisualStyleBackColor = true;
            this.buttonCrossLines.Click += new System.EventHandler(this.buttonCrossLines_Click);
            // 
            // buttonIsPointInPolygon
            // 
            this.buttonIsPointInPolygon.Enabled = false;
            this.buttonIsPointInPolygon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonIsPointInPolygon.Location = new System.Drawing.Point(21, 693);
            this.buttonIsPointInPolygon.Name = "buttonIsPointInPolygon";
            this.buttonIsPointInPolygon.Size = new System.Drawing.Size(226, 85);
            this.buttonIsPointInPolygon.TabIndex = 1;
            this.buttonIsPointInPolygon.Text = "Проверить принадлежность точки полигону";
            this.buttonIsPointInPolygon.UseVisualStyleBackColor = true;
            this.buttonIsPointInPolygon.Click += new System.EventHandler(this.buttonIsPointInPolygon_Click);
            // 
            // buttonClassifyPoint
            // 
            this.buttonClassifyPoint.Enabled = false;
            this.buttonClassifyPoint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClassifyPoint.Location = new System.Drawing.Point(21, 784);
            this.buttonClassifyPoint.Name = "buttonClassifyPoint";
            this.buttonClassifyPoint.Size = new System.Drawing.Size(226, 85);
            this.buttonClassifyPoint.TabIndex = 1;
            this.buttonClassifyPoint.Text = "Классифицировать положение точки относительно ребра";
            this.buttonClassifyPoint.UseVisualStyleBackColor = true;
            this.buttonClassifyPoint.Click += new System.EventHandler(this.buttonClassifyPoint_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(178, 446);
            this.textBox1.MaxLength = 5;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(69, 31);
            this.textBox1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "cY:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1562, 900);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelChoodePoint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textScale);
            this.Controls.Add(this.textAngle);
            this.Controls.Add(this.textShiftY);
            this.Controls.Add(this.textShiftX);
            this.Controls.Add(this.comboBoxShape);
            this.Controls.Add(this.buttonClassifyPoint);
            this.Controls.Add(this.buttonIsPointInPolygon);
            this.Controls.Add(this.buttonCrossLines);
            this.Controls.Add(this.buttonRotateLine);
            this.Controls.Add(this.buttonScale);
            this.Controls.Add(this.buttonСhooseCentre);
            this.Controls.Add(this.buttonRotate);
            this.Controls.Add(this.buttonShift);
            this.Controls.Add(this.buttonPolygon);
            this.Controls.Add(this.canvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Алгем (на минималках)";
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Button buttonPolygon;
        private System.Windows.Forms.OpenFileDialog chooseFileDialog;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ComboBox comboBoxShape;
        private System.Windows.Forms.Button buttonShift;
        private System.Windows.Forms.TextBox textShiftX;
        private System.Windows.Forms.TextBox textShiftY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRotate;
        private System.Windows.Forms.TextBox textAngle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonScale;
        private System.Windows.Forms.TextBox textScale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonСhooseCentre;
        private System.Windows.Forms.Label labelChoodePoint;
        private System.Windows.Forms.Button buttonRotateLine;
        private System.Windows.Forms.Button buttonCrossLines;
        private System.Windows.Forms.Button buttonIsPointInPolygon;
        private System.Windows.Forms.Button buttonClassifyPoint;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
    }
}

