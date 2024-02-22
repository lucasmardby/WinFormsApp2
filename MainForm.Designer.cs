namespace WinFormsApp2
{
    partial class MainForm
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
            txtName = new TextBox();
            lblName = new Label();
            lblHeight = new Label();
            txtHeight = new TextBox();
            lblWeight = new Label();
            txtWeight = new TextBox();
            groupBox1 = new GroupBox();
            rbtnUsUnit = new RadioButton();
            rbtnMetric = new RadioButton();
            btnCalculate = new Button();
            grpResults = new GroupBox();
            lblNormalBMI = new Label();
            lblResultWeightCategory = new Label();
            lblResultYourBMI = new Label();
            lblWeightCategory = new Label();
            lblYourBMI = new Label();
            groupBox1.SuspendLayout();
            grpResults.SuspendLayout();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(116, 12);
            txtName.Name = "txtName";
            txtName.Size = new Size(340, 23);
            txtName.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(25, 15);
            lblName.Name = "lblName";
            lblName.Size = new Size(66, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Your Name";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(25, 58);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(43, 15);
            lblHeight.TabIndex = 3;
            lblHeight.Text = "Height";
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(116, 55);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(51, 23);
            txtHeight.TabIndex = 2;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(25, 87);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(45, 15);
            lblWeight.TabIndex = 5;
            lblWeight.Text = "Weight";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(116, 84);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(51, 23);
            txtWeight.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnUsUnit);
            groupBox1.Controls.Add(rbtnMetric);
            groupBox1.Location = new Point(288, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(168, 82);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Unit";
            // 
            // rbtnUsUnit
            // 
            rbtnUsUnit.AutoSize = true;
            rbtnUsUnit.Location = new Point(14, 48);
            rbtnUsUnit.Name = "rbtnUsUnit";
            rbtnUsUnit.Size = new Size(118, 19);
            rbtnUsUnit.TabIndex = 1;
            rbtnUsUnit.TabStop = true;
            rbtnUsUnit.Text = "US Unit (foot, lbs)";
            rbtnUsUnit.UseVisualStyleBackColor = true;
            rbtnUsUnit.CheckedChanged += rbtnUsUnit_CheckedChanged;
            // 
            // rbtnMetric
            // 
            rbtnMetric.AutoSize = true;
            rbtnMetric.Location = new Point(14, 23);
            rbtnMetric.Name = "rbtnMetric";
            rbtnMetric.Size = new Size(131, 19);
            rbtnMetric.TabIndex = 0;
            rbtnMetric.TabStop = true;
            rbtnMetric.Text = "Metric Unit (cm, kg)";
            rbtnMetric.UseVisualStyleBackColor = true;
            rbtnMetric.CheckedChanged += rbtnMetric_CheckedChanged;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(185, 143);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(108, 27);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += button1_Click;
            // 
            // grpResults
            // 
            grpResults.Controls.Add(lblNormalBMI);
            grpResults.Controls.Add(lblResultWeightCategory);
            grpResults.Controls.Add(lblResultYourBMI);
            grpResults.Controls.Add(lblWeightCategory);
            grpResults.Controls.Add(lblYourBMI);
            grpResults.Location = new Point(25, 176);
            grpResults.Name = "grpResults";
            grpResults.Size = new Size(431, 226);
            grpResults.TabIndex = 8;
            grpResults.TabStop = false;
            grpResults.Text = "Results";
            // 
            // lblNormalBMI
            // 
            lblNormalBMI.Location = new Point(216, 104);
            lblNormalBMI.Name = "lblNormalBMI";
            lblNormalBMI.Size = new Size(192, 23);
            lblNormalBMI.TabIndex = 4;
            lblNormalBMI.Text = "label5";
            lblNormalBMI.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblResultWeightCategory
            // 
            lblResultWeightCategory.BorderStyle = BorderStyle.Fixed3D;
            lblResultWeightCategory.Location = new Point(216, 68);
            lblResultWeightCategory.Name = "lblResultWeightCategory";
            lblResultWeightCategory.Size = new Size(192, 23);
            lblResultWeightCategory.TabIndex = 3;
            lblResultWeightCategory.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblResultYourBMI
            // 
            lblResultYourBMI.BorderStyle = BorderStyle.Fixed3D;
            lblResultYourBMI.Location = new Point(342, 32);
            lblResultYourBMI.Name = "lblResultYourBMI";
            lblResultYourBMI.Size = new Size(66, 23);
            lblResultYourBMI.TabIndex = 2;
            lblResultYourBMI.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblWeightCategory
            // 
            lblWeightCategory.AutoSize = true;
            lblWeightCategory.Location = new Point(28, 72);
            lblWeightCategory.Name = "lblWeightCategory";
            lblWeightCategory.Size = new Size(96, 15);
            lblWeightCategory.TabIndex = 1;
            lblWeightCategory.Text = "Weight Category";
            // 
            // lblYourBMI
            // 
            lblYourBMI.AutoSize = true;
            lblYourBMI.Location = new Point(28, 36);
            lblYourBMI.Name = "lblYourBMI";
            lblYourBMI.Size = new Size(55, 15);
            lblYourBMI.TabIndex = 0;
            lblYourBMI.Text = "Your BMI";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 450);
            Controls.Add(grpResults);
            Controls.Add(btnCalculate);
            Controls.Add(groupBox1);
            Controls.Add(lblWeight);
            Controls.Add(txtWeight);
            Controls.Add(lblHeight);
            Controls.Add(txtHeight);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Name = "MainForm";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpResults.ResumeLayout(false);
            grpResults.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label lblName;
        private Label lblHeight;
        private TextBox txtHeight;
        private Label lblWeight;
        private TextBox txtWeight;
        private GroupBox groupBox1;
        private RadioButton rbtnUsUnit;
        private RadioButton rbtnMetric;
        private Button btnCalculate;
        private GroupBox grpResults;
        private Label lblResultYourBMI;
        private Label lblWeightCategory;
        private Label lblYourBMI;
        private Label lblNormalBMI;
        private Label lblResultWeightCategory;
    }
}
