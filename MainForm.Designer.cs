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
            grpSavingPlan = new GroupBox();
            txtFees = new TextBox();
            label5 = new Label();
            txtInterest = new TextBox();
            label4 = new Label();
            txtPeriod = new TextBox();
            label3 = new Label();
            txtMonthlyDeposit = new TextBox();
            label2 = new Label();
            txtInitialDeposit = new TextBox();
            label1 = new Label();
            btnSavingCalculate = new Button();
            groupBox2 = new GroupBox();
            lblTotalFees = new Label();
            lblFinalBalance = new Label();
            lblAmountEarned = new Label();
            lblAmountPaid = new Label();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            label8 = new Label();
            btnSavingsClear = new Button();
            groupBox1.SuspendLayout();
            grpResults.SuspendLayout();
            grpBMICalculator.SuspendLayout();
            grpSavingPlan.SuspendLayout();
            groupBox2.SuspendLayout();
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
            btnBMICalculate.Text = "Calculate BMI";
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
            // grpSavingPlan
            // 
            grpSavingPlan.Controls.Add(txtFees);
            grpSavingPlan.Controls.Add(label5);
            grpSavingPlan.Controls.Add(txtInterest);
            grpSavingPlan.Controls.Add(label4);
            grpSavingPlan.Controls.Add(txtPeriod);
            grpSavingPlan.Controls.Add(label3);
            grpSavingPlan.Controls.Add(txtMonthlyDeposit);
            grpSavingPlan.Controls.Add(label2);
            grpSavingPlan.Controls.Add(txtInitialDeposit);
            grpSavingPlan.Controls.Add(label1);
            grpSavingPlan.Location = new Point(566, 12);
            grpSavingPlan.Name = "grpSavingPlan";
            grpSavingPlan.Size = new Size(328, 186);
            grpSavingPlan.TabIndex = 13;
            grpSavingPlan.TabStop = false;
            grpSavingPlan.Text = "Saving Plan";
            // 
            // txtFees
            // 
            txtFees.Location = new Point(158, 146);
            txtFees.Name = "txtFees";
            txtFees.Size = new Size(141, 23);
            txtFees.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 149);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 20;
            label5.Text = "Fees in %";
            // 
            // txtInterest
            // 
            txtInterest.Location = new Point(158, 117);
            txtInterest.Name = "txtInterest";
            txtInterest.Size = new Size(141, 23);
            txtInterest.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 120);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 18;
            label4.Text = "Interest in %";
            // 
            // txtPeriod
            // 
            txtPeriod.Location = new Point(158, 88);
            txtPeriod.Name = "txtPeriod";
            txtPeriod.Size = new Size(141, 23);
            txtPeriod.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 91);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 16;
            label3.Text = "Period (Years)";
            // 
            // txtMonthlyDeposit
            // 
            txtMonthlyDeposit.Location = new Point(158, 59);
            txtMonthlyDeposit.Name = "txtMonthlyDeposit";
            txtMonthlyDeposit.Size = new Size(141, 23);
            txtMonthlyDeposit.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 62);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 14;
            label2.Text = "Monthly Deposit";
            // 
            // txtInitialDeposit
            // 
            txtInitialDeposit.Location = new Point(158, 30);
            txtInitialDeposit.Name = "txtInitialDeposit";
            txtInitialDeposit.Size = new Size(141, 23);
            txtInitialDeposit.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 33);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 12;
            label1.Text = "Initial Deposit";
            // 
            // btnSavingCalculate
            // 
            btnSavingCalculate.Location = new Point(581, 204);
            btnSavingCalculate.Name = "btnSavingCalculate";
            btnSavingCalculate.Size = new Size(183, 27);
            btnSavingCalculate.TabIndex = 14;
            btnSavingCalculate.Text = "Calculate Savings";
            btnSavingCalculate.UseVisualStyleBackColor = true;
            btnSavingCalculate.Click += btnSavingCalculate_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblTotalFees);
            groupBox2.Controls.Add(lblFinalBalance);
            groupBox2.Controls.Add(lblAmountEarned);
            groupBox2.Controls.Add(lblAmountPaid);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(566, 237);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(328, 151);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Future Value";
            // 
            // lblTotalFees
            // 
            lblTotalFees.BorderStyle = BorderStyle.Fixed3D;
            lblTotalFees.Location = new Point(158, 108);
            lblTotalFees.Name = "lblTotalFees";
            lblTotalFees.Size = new Size(141, 23);
            lblTotalFees.TabIndex = 16;
            lblTotalFees.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFinalBalance
            // 
            lblFinalBalance.BorderStyle = BorderStyle.Fixed3D;
            lblFinalBalance.Location = new Point(158, 81);
            lblFinalBalance.Name = "lblFinalBalance";
            lblFinalBalance.Size = new Size(141, 23);
            lblFinalBalance.TabIndex = 16;
            lblFinalBalance.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblAmountEarned
            // 
            lblAmountEarned.BorderStyle = BorderStyle.Fixed3D;
            lblAmountEarned.Location = new Point(158, 50);
            lblAmountEarned.Name = "lblAmountEarned";
            lblAmountEarned.Size = new Size(141, 23);
            lblAmountEarned.TabIndex = 25;
            lblAmountEarned.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblAmountPaid
            // 
            lblAmountPaid.BorderStyle = BorderStyle.Fixed3D;
            lblAmountPaid.Location = new Point(158, 21);
            lblAmountPaid.Name = "lblAmountPaid";
            lblAmountPaid.Size = new Size(141, 23);
            lblAmountPaid.TabIndex = 6;
            lblAmountPaid.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 116);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 24;
            label6.Text = "Total Fees";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 87);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 23;
            label7.Text = "Final Balance";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 29);
            label9.Name = "label9";
            label9.Size = new Size(77, 15);
            label9.TabIndex = 21;
            label9.Text = "Amount Paid";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 58);
            label8.Name = "label8";
            label8.Size = new Size(90, 15);
            label8.TabIndex = 22;
            label8.Text = "Amount Earned";
            // 
            // btnSavingsClear
            // 
            btnSavingsClear.Location = new Point(790, 204);
            btnSavingsClear.Name = "btnSavingsClear";
            btnSavingsClear.Size = new Size(75, 27);
            btnSavingsClear.TabIndex = 16;
            btnSavingsClear.Text = "Clear";
            btnSavingsClear.UseVisualStyleBackColor = true;
            btnSavingsClear.Click += btnSavingsClear_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 633);
            Controls.Add(btnSavingsClear);
            Controls.Add(groupBox2);
            Controls.Add(btnSavingCalculate);
            Controls.Add(grpSavingPlan);
            Controls.Add(grpBMICalculator);
            Controls.Add(lblInches);
            Controls.Add(grpResults);
            Controls.Add(btnBMICalculate);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Super Calculator, by Lucas Mårdby";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpResults.ResumeLayout(false);
            grpResults.PerformLayout();
            grpBMICalculator.ResumeLayout(false);
            grpBMICalculator.PerformLayout();
            grpSavingPlan.ResumeLayout(false);
            grpSavingPlan.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private GroupBox grpSavingPlan;
        private TextBox txtFees;
        private Label label5;
        private TextBox txtInterest;
        private Label label4;
        private TextBox txtPeriod;
        private Label label3;
        private TextBox txtMonthlyDeposit;
        private Label label2;
        private TextBox txtInitialDeposit;
        private Label label1;
        private Button btnSavingCalculate;
        private GroupBox groupBox2;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label8;
        private Label lblTotalFees;
        private Label lblFinalBalance;
        private Label lblAmountEarned;
        private Label lblAmountPaid;
        private Button btnSavingsClear;
    }
}
