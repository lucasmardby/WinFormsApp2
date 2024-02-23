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
            btnBMICalculate = new Button();
            grpResults = new GroupBox();
            lblNormalWeight = new Label();
            lblNormalBMI = new Label();
            lblResultWeightCategory = new Label();
            lblResultYourBMI = new Label();
            lblWeightCategory = new Label();
            lblYourBMI = new Label();
            txtUSInches = new TextBox();
            lblFeet = new Label();
            lblInches = new Label();
            grpBMICalculator = new GroupBox();
            groupBox1.SuspendLayout();
            grpResults.SuspendLayout();
            grpBMICalculator.SuspendLayout();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(121, 30);
            txtName.Name = "txtName";
            txtName.Size = new Size(225, 23);
            txtName.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(30, 33);
            lblName.Name = "lblName";
            lblName.Size = new Size(66, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Your Name";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(30, 76);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(43, 15);
            lblHeight.TabIndex = 3;
            lblHeight.Text = "Height";
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(121, 73);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(51, 23);
            txtHeight.TabIndex = 2;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(30, 105);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(45, 15);
            lblWeight.TabIndex = 5;
            lblWeight.Text = "Weight";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(121, 102);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(51, 23);
            txtWeight.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnUsUnit);
            groupBox1.Controls.Add(rbtnMetric);
            groupBox1.Location = new Point(395, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(150, 108);
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
            // btnBMICalculate
            // 
            btnBMICalculate.Location = new Point(395, 126);
            btnBMICalculate.Name = "btnBMICalculate";
            btnBMICalculate.Size = new Size(150, 27);
            btnBMICalculate.TabIndex = 7;
            btnBMICalculate.Text = "Calculate";
            btnBMICalculate.UseVisualStyleBackColor = true;
            btnBMICalculate.Click += btnBMICalc_Click;
            // 
            // grpResults
            // 
            grpResults.Controls.Add(lblNormalWeight);
            grpResults.Controls.Add(lblNormalBMI);
            grpResults.Controls.Add(lblResultWeightCategory);
            grpResults.Controls.Add(lblResultYourBMI);
            grpResults.Controls.Add(lblWeightCategory);
            grpResults.Controls.Add(lblYourBMI);
            grpResults.Location = new Point(25, 159);
            grpResults.Name = "grpResults";
            grpResults.Size = new Size(520, 182);
            grpResults.TabIndex = 8;
            grpResults.TabStop = false;
            grpResults.Text = "Results";
            // 
            // lblNormalWeight
            // 
            lblNormalWeight.ForeColor = Color.Green;
            lblNormalWeight.Location = new Point(28, 141);
            lblNormalWeight.Name = "lblNormalWeight";
            lblNormalWeight.Size = new Size(464, 23);
            lblNormalWeight.TabIndex = 5;
            lblNormalWeight.Text = "lblNormalWeight";
            lblNormalWeight.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNormalBMI
            // 
            lblNormalBMI.Location = new Point(244, 104);
            lblNormalBMI.Name = "lblNormalBMI";
            lblNormalBMI.Size = new Size(248, 23);
            lblNormalBMI.TabIndex = 4;
            lblNormalBMI.Text = "lblNormalBMI";
            lblNormalBMI.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblResultWeightCategory
            // 
            lblResultWeightCategory.BorderStyle = BorderStyle.Fixed3D;
            lblResultWeightCategory.Location = new Point(244, 68);
            lblResultWeightCategory.Name = "lblResultWeightCategory";
            lblResultWeightCategory.Size = new Size(248, 23);
            lblResultWeightCategory.TabIndex = 3;
            lblResultWeightCategory.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblResultYourBMI
            // 
            lblResultYourBMI.BorderStyle = BorderStyle.Fixed3D;
            lblResultYourBMI.Location = new Point(426, 32);
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
            // txtUSInches
            // 
            txtUSInches.Location = new Point(201, 73);
            txtUSInches.Name = "txtUSInches";
            txtUSInches.Size = new Size(51, 23);
            txtUSInches.TabIndex = 9;
            // 
            // lblFeet
            // 
            lblFeet.AutoSize = true;
            lblFeet.Location = new Point(178, 77);
            lblFeet.Name = "lblFeet";
            lblFeet.Size = new Size(15, 15);
            lblFeet.TabIndex = 10;
            lblFeet.Text = "ft";
            // 
            // lblInches
            // 
            lblInches.AutoSize = true;
            lblInches.Location = new Point(253, 59);
            lblInches.Name = "lblInches";
            lblInches.Size = new Size(17, 15);
            lblInches.TabIndex = 11;
            lblInches.Text = "in";
            // 
            // grpBMICalculator
            // 
            grpBMICalculator.Controls.Add(lblName);
            grpBMICalculator.Controls.Add(txtName);
            grpBMICalculator.Controls.Add(lblFeet);
            grpBMICalculator.Controls.Add(txtHeight);
            grpBMICalculator.Controls.Add(txtUSInches);
            grpBMICalculator.Controls.Add(lblHeight);
            grpBMICalculator.Controls.Add(txtWeight);
            grpBMICalculator.Controls.Add(lblWeight);
            grpBMICalculator.Location = new Point(25, 12);
            grpBMICalculator.Name = "grpBMICalculator";
            grpBMICalculator.Size = new Size(364, 141);
            grpBMICalculator.TabIndex = 12;
            grpBMICalculator.TabStop = false;
            grpBMICalculator.Text = "BMI Calculator";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 521);
            Controls.Add(grpBMICalculator);
            Controls.Add(lblInches);
            Controls.Add(grpResults);
            Controls.Add(btnBMICalculate);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BMI Calculator, by Lucas Mårdby";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpResults.ResumeLayout(false);
            grpResults.PerformLayout();
            grpBMICalculator.ResumeLayout(false);
            grpBMICalculator.PerformLayout();
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
        private Button btnBMICalculate;
        private GroupBox grpResults;
        private Label lblResultYourBMI;
        private Label lblWeightCategory;
        private Label lblYourBMI;
        private Label lblNormalBMI;
        private Label lblResultWeightCategory;
        private Label lblNormalWeight;
        private TextBox txtUSInches;
        private Label lblFeet;
        private Label lblInches;
        private GroupBox grpBMICalculator;
    }
}
