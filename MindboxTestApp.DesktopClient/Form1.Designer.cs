namespace MindboxTestApp.DesktopClient
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.triangleOptionsArea = new System.Windows.Forms.GroupBox();
            this.rightTriangleOutput = new System.Windows.Forms.Label();
            this.buttonCheckRightTriangle = new System.Windows.Forms.Button();
            this.triangleSideThreeInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.triangleSideTwoInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.triangleSideOneInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.circleOptionsArea = new System.Windows.Forms.GroupBox();
            this.circleRadiusInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonCreateShape = new System.Windows.Forms.Button();
            this.buttonCalculateSquare = new System.Windows.Forms.Button();
            this.squareOutput = new System.Windows.Forms.Label();
            this.successMessageOutput = new System.Windows.Forms.Label();
            this.triangleOptionsArea.SuspendLayout();
            this.circleOptionsArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Shape:";
            // 
            // triangleOptionsArea
            // 
            this.triangleOptionsArea.Controls.Add(this.rightTriangleOutput);
            this.triangleOptionsArea.Controls.Add(this.buttonCheckRightTriangle);
            this.triangleOptionsArea.Controls.Add(this.triangleSideThreeInput);
            this.triangleOptionsArea.Controls.Add(this.label4);
            this.triangleOptionsArea.Controls.Add(this.triangleSideTwoInput);
            this.triangleOptionsArea.Controls.Add(this.label3);
            this.triangleOptionsArea.Controls.Add(this.triangleSideOneInput);
            this.triangleOptionsArea.Controls.Add(this.label2);
            this.triangleOptionsArea.Location = new System.Drawing.Point(186, 9);
            this.triangleOptionsArea.Name = "triangleOptionsArea";
            this.triangleOptionsArea.Size = new System.Drawing.Size(602, 190);
            this.triangleOptionsArea.TabIndex = 2;
            this.triangleOptionsArea.TabStop = false;
            // 
            // rightTriangleOutput
            // 
            this.rightTriangleOutput.AutoSize = true;
            this.rightTriangleOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rightTriangleOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rightTriangleOutput.Location = new System.Drawing.Point(419, 89);
            this.rightTriangleOutput.MinimumSize = new System.Drawing.Size(96, 28);
            this.rightTriangleOutput.Name = "rightTriangleOutput";
            this.rightTriangleOutput.Size = new System.Drawing.Size(96, 28);
            this.rightTriangleOutput.TabIndex = 11;
            // 
            // buttonCheckRightTriangle
            // 
            this.buttonCheckRightTriangle.Location = new System.Drawing.Point(419, 142);
            this.buttonCheckRightTriangle.Name = "buttonCheckRightTriangle";
            this.buttonCheckRightTriangle.Size = new System.Drawing.Size(177, 29);
            this.buttonCheckRightTriangle.TabIndex = 6;
            this.buttonCheckRightTriangle.Text = "Check if Right";
            this.buttonCheckRightTriangle.UseVisualStyleBackColor = true;
            // 
            // triangleSideThreeInput
            // 
            this.triangleSideThreeInput.Location = new System.Drawing.Point(105, 86);
            this.triangleSideThreeInput.Name = "triangleSideThreeInput";
            this.triangleSideThreeInput.Size = new System.Drawing.Size(125, 27);
            this.triangleSideThreeInput.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Side Three:";
            // 
            // triangleSideTwoInput
            // 
            this.triangleSideTwoInput.Location = new System.Drawing.Point(105, 53);
            this.triangleSideTwoInput.Name = "triangleSideTwoInput";
            this.triangleSideTwoInput.Size = new System.Drawing.Size(125, 27);
            this.triangleSideTwoInput.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Side Two:";
            // 
            // triangleSideOneInput
            // 
            this.triangleSideOneInput.Location = new System.Drawing.Point(105, 20);
            this.triangleSideOneInput.Name = "triangleSideOneInput";
            this.triangleSideOneInput.Size = new System.Drawing.Size(125, 27);
            this.triangleSideOneInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Side One:";
            // 
            // circleOptionsArea
            // 
            this.circleOptionsArea.Controls.Add(this.circleRadiusInput);
            this.circleOptionsArea.Controls.Add(this.label8);
            this.circleOptionsArea.Location = new System.Drawing.Point(180, 12);
            this.circleOptionsArea.Name = "circleOptionsArea";
            this.circleOptionsArea.Size = new System.Drawing.Size(602, 190);
            this.circleOptionsArea.TabIndex = 12;
            this.circleOptionsArea.TabStop = false;
            // 
            // circleRadiusInput
            // 
            this.circleRadiusInput.Location = new System.Drawing.Point(105, 20);
            this.circleRadiusInput.Name = "circleRadiusInput";
            this.circleRadiusInput.Size = new System.Drawing.Size(125, 27);
            this.circleRadiusInput.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Radius:";
            // 
            // buttonCreateShape
            // 
            this.buttonCreateShape.Location = new System.Drawing.Point(186, 246);
            this.buttonCreateShape.Name = "buttonCreateShape";
            this.buttonCreateShape.Size = new System.Drawing.Size(177, 29);
            this.buttonCreateShape.TabIndex = 7;
            this.buttonCreateShape.Text = "Create Shape";
            this.buttonCreateShape.UseVisualStyleBackColor = true;
            // 
            // buttonCalculateSquare
            // 
            this.buttonCalculateSquare.Location = new System.Drawing.Point(388, 246);
            this.buttonCalculateSquare.Name = "buttonCalculateSquare";
            this.buttonCalculateSquare.Size = new System.Drawing.Size(177, 29);
            this.buttonCalculateSquare.TabIndex = 8;
            this.buttonCalculateSquare.Text = "Calculate Square";
            this.buttonCalculateSquare.UseVisualStyleBackColor = true;
            // 
            // squareOutput
            // 
            this.squareOutput.AutoSize = true;
            this.squareOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.squareOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.squareOutput.Location = new System.Drawing.Point(587, 246);
            this.squareOutput.MinimumSize = new System.Drawing.Size(96, 28);
            this.squareOutput.Name = "squareOutput";
            this.squareOutput.Size = new System.Drawing.Size(96, 28);
            this.squareOutput.TabIndex = 9;
            // 
            // successMessageOutput
            // 
            this.successMessageOutput.AutoSize = true;
            this.successMessageOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.successMessageOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.successMessageOutput.ForeColor = System.Drawing.Color.LimeGreen;
            this.successMessageOutput.Location = new System.Drawing.Point(186, 295);
            this.successMessageOutput.MinimumSize = new System.Drawing.Size(320, 28);
            this.successMessageOutput.Name = "successMessageOutput";
            this.successMessageOutput.Size = new System.Drawing.Size(320, 28);
            this.successMessageOutput.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.circleOptionsArea);
            this.Controls.Add(this.successMessageOutput);
            this.Controls.Add(this.squareOutput);
            this.Controls.Add(this.buttonCalculateSquare);
            this.Controls.Add(this.buttonCreateShape);
            this.Controls.Add(this.triangleOptionsArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.triangleOptionsArea.ResumeLayout(false);
            this.triangleOptionsArea.PerformLayout();
            this.circleOptionsArea.ResumeLayout(false);
            this.circleOptionsArea.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal ComboBox comboBox1;
        internal Label label1;
        internal GroupBox triangleOptionsArea;
        internal GroupBox circleOptionsArea;
        internal TextBox circleRadiusInput;
        private Label label8;
        internal Label rightTriangleOutput;
        internal Button buttonCheckRightTriangle;
        internal TextBox triangleSideThreeInput;
        private Label label4;
        internal TextBox triangleSideTwoInput;
        private Label label3;
        internal TextBox triangleSideOneInput;
        private Label label2;
        internal Button buttonCreateShape;
        internal Button buttonCalculateSquare;
        internal Label squareOutput;
        internal Label successMessageOutput;
    }
}