
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
            this.textScaleX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonСhooseCentre = new System.Windows.Forms.Button();
            this.labelChoodePoint = new System.Windows.Forms.Label();
            this.buttonRotateLine = new System.Windows.Forms.Button();
            this.buttonCrossLines = new System.Windows.Forms.Button();
            this.buttonIsPointInPolygon = new System.Windows.Forms.Button();
            this.buttonClassifyPoint = new System.Windows.Forms.Button();
            this.textScaleY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Right;
            this.canvas.Location = new System.Drawing.Point(210, 0);
            this.canvas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(1040, 720);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseClick);
            // 
            // buttonPolygon
            // 
            this.buttonPolygon.Location = new System.Drawing.Point(17, 125);
            this.buttonPolygon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPolygon.Name = "buttonPolygon";
            this.buttonPolygon.Size = new System.Drawing.Size(181, 34);
            this.buttonPolygon.TabIndex = 1;
            this.buttonPolygon.Text = "Нарисовать что-нибудь";
            this.buttonPolygon.UseVisualStyleBackColor = true;
            this.buttonPolygon.Click += new System.EventHandler(this.buttonPolygon_Click);
            // 
            // comboBoxShape
            // 
            this.comboBoxShape.Enabled = false;
            this.comboBoxShape.FormattingEnabled = true;
            this.comboBoxShape.Items.AddRange(new object[] {
            "Полигон",
            "Отрезок",
            "Точка"});
            this.comboBoxShape.Location = new System.Drawing.Point(17, 164);
            this.comboBoxShape.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxShape.Name = "comboBoxShape";
            this.comboBoxShape.Size = new System.Drawing.Size(182, 28);
            this.comboBoxShape.TabIndex = 2;
            this.comboBoxShape.SelectedIndexChanged += new System.EventHandler(this.comboBoxShape_SelectedIndexChanged);
            // 
            // buttonShift
            // 
            this.buttonShift.Enabled = false;
            this.buttonShift.Location = new System.Drawing.Point(17, 248);
            this.buttonShift.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonShift.Name = "buttonShift";
            this.buttonShift.Size = new System.Drawing.Size(181, 34);
            this.buttonShift.TabIndex = 1;
            this.buttonShift.Text = "Сместить";
            this.buttonShift.UseVisualStyleBackColor = true;
            this.buttonShift.Click += new System.EventHandler(this.buttonShift_Click);
            // 
            // textShiftX
            // 
            this.textShiftX.Enabled = false;
            this.textShiftX.Location = new System.Drawing.Point(43, 218);
            this.textShiftX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textShiftX.MaxLength = 5;
            this.textShiftX.Name = "textShiftX";
            this.textShiftX.Size = new System.Drawing.Size(56, 27);
            this.textShiftX.TabIndex = 3;
            // 
            // textShiftY
            // 
            this.textShiftY.Enabled = false;
            this.textShiftY.Location = new System.Drawing.Point(142, 218);
            this.textShiftY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textShiftY.MaxLength = 5;
            this.textShiftY.Name = "textShiftY";
            this.textShiftY.Size = new System.Drawing.Size(56, 27);
            this.textShiftY.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 221);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Х:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 221);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y:";
            // 
            // buttonRotate
            // 
            this.buttonRotate.Enabled = false;
            this.buttonRotate.Location = new System.Drawing.Point(17, 318);
            this.buttonRotate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRotate.Name = "buttonRotate";
            this.buttonRotate.Size = new System.Drawing.Size(181, 34);
            this.buttonRotate.TabIndex = 1;
            this.buttonRotate.Text = "Повернуть";
            this.buttonRotate.UseVisualStyleBackColor = true;
            this.buttonRotate.Click += new System.EventHandler(this.buttonRotate_Click);
            // 
            // textAngle
            // 
            this.textAngle.Enabled = false;
            this.textAngle.Location = new System.Drawing.Point(89, 288);
            this.textAngle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textAngle.MaxLength = 5;
            this.textAngle.Name = "textAngle";
            this.textAngle.Size = new System.Drawing.Size(110, 27);
            this.textAngle.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 290);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Градусы:";
            // 
            // buttonScale
            // 
            this.buttonScale.Enabled = false;
            this.buttonScale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonScale.Location = new System.Drawing.Point(17, 387);
            this.buttonScale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonScale.Name = "buttonScale";
            this.buttonScale.Size = new System.Drawing.Size(181, 34);
            this.buttonScale.TabIndex = 1;
            this.buttonScale.Text = "Отмасштабировать";
            this.buttonScale.UseVisualStyleBackColor = true;
            this.buttonScale.Click += new System.EventHandler(this.buttonScale_Click);
            // 
            // textScaleX
            // 
            this.textScaleX.Enabled = false;
            this.textScaleX.Location = new System.Drawing.Point(50, 357);
            this.textScaleX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textScaleX.MaxLength = 5;
            this.textScaleX.Name = "textScaleX";
            this.textScaleX.Size = new System.Drawing.Size(56, 27);
            this.textScaleX.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 360);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "cХ:";
            // 
            // buttonСhooseCentre
            // 
            this.buttonСhooseCentre.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonСhooseCentre.Enabled = false;
            this.buttonСhooseCentre.Location = new System.Drawing.Point(46, 50);
            this.buttonСhooseCentre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonСhooseCentre.Name = "buttonСhooseCentre";
            this.buttonСhooseCentre.Size = new System.Drawing.Size(117, 34);
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
            this.labelChoodePoint.Location = new System.Drawing.Point(10, 7);
            this.labelChoodePoint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelChoodePoint.Name = "labelChoodePoint";
            this.labelChoodePoint.Size = new System.Drawing.Size(204, 32);
            this.labelChoodePoint.TabIndex = 4;
            this.labelChoodePoint.Text = "Выберите точку";
            this.labelChoodePoint.Visible = false;
            // 
            // buttonRotateLine
            // 
            this.buttonRotateLine.Enabled = false;
            this.buttonRotateLine.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRotateLine.Location = new System.Drawing.Point(17, 450);
            this.buttonRotateLine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRotateLine.Name = "buttonRotateLine";
            this.buttonRotateLine.Size = new System.Drawing.Size(181, 34);
            this.buttonRotateLine.TabIndex = 1;
            this.buttonRotateLine.Text = "Повернуть ребро на 90º";
            this.buttonRotateLine.UseVisualStyleBackColor = true;
            this.buttonRotateLine.Click += new System.EventHandler(this.buttonRotateLine_Click);
            // 
            // buttonCrossLines
            // 
            this.buttonCrossLines.Enabled = false;
            this.buttonCrossLines.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCrossLines.Location = new System.Drawing.Point(17, 489);
            this.buttonCrossLines.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCrossLines.Name = "buttonCrossLines";
            this.buttonCrossLines.Size = new System.Drawing.Size(181, 34);
            this.buttonCrossLines.TabIndex = 1;
            this.buttonCrossLines.Text = "Пересечь рёбра";
            this.buttonCrossLines.UseVisualStyleBackColor = true;
            this.buttonCrossLines.Click += new System.EventHandler(this.buttonCrossLines_Click);
            // 
            // buttonIsPointInPolygon
            // 
            this.buttonIsPointInPolygon.Enabled = false;
            this.buttonIsPointInPolygon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonIsPointInPolygon.Location = new System.Drawing.Point(17, 554);
            this.buttonIsPointInPolygon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonIsPointInPolygon.Name = "buttonIsPointInPolygon";
            this.buttonIsPointInPolygon.Size = new System.Drawing.Size(181, 68);
            this.buttonIsPointInPolygon.TabIndex = 1;
            this.buttonIsPointInPolygon.Text = "Проверить принадлежность точки полигону";
            this.buttonIsPointInPolygon.UseVisualStyleBackColor = true;
            this.buttonIsPointInPolygon.Click += new System.EventHandler(this.buttonIsPointInPolygon_Click);
            // 
            // buttonClassifyPoint
            // 
            this.buttonClassifyPoint.Enabled = false;
            this.buttonClassifyPoint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClassifyPoint.Location = new System.Drawing.Point(17, 627);
            this.buttonClassifyPoint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClassifyPoint.Name = "buttonClassifyPoint";
            this.buttonClassifyPoint.Size = new System.Drawing.Size(181, 68);
            this.buttonClassifyPoint.TabIndex = 1;
            this.buttonClassifyPoint.Text = "Классифицировать положение точки относительно ребра";
            this.buttonClassifyPoint.UseVisualStyleBackColor = true;
            this.buttonClassifyPoint.Click += new System.EventHandler(this.buttonClassifyPoint_Click);
            // 
            // textScaleY
            // 
            this.textScaleY.Enabled = false;
            this.textScaleY.Location = new System.Drawing.Point(142, 357);
            this.textScaleY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textScaleY.MaxLength = 5;
            this.textScaleY.Name = "textScaleY";
            this.textScaleY.Size = new System.Drawing.Size(56, 27);
            this.textScaleY.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 359);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "cY:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1250, 720);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelChoodePoint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textScaleY);
            this.Controls.Add(this.textScaleX);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.TextBox textScaleX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonСhooseCentre;
        private System.Windows.Forms.Label labelChoodePoint;
        private System.Windows.Forms.Button buttonRotateLine;
        private System.Windows.Forms.Button buttonCrossLines;
        private System.Windows.Forms.Button buttonIsPointInPolygon;
        private System.Windows.Forms.Button buttonClassifyPoint;
        private System.Windows.Forms.TextBox textScaleY;
        private System.Windows.Forms.Label label5;
    }
}

