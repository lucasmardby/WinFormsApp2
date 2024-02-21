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
            radioButton1 = new RadioButton();
            button1 = new Button();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
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
            lblHeight.Size = new Size(26, 15);
            lblHeight.TabIndex = 3;
            lblHeight.Text = "test";
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
            lblWeight.Size = new Size(26, 15);
            lblWeight.TabIndex = 5;
            lblWeight.Text = "test";
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
            groupBox1.Controls.Add(radioButton1);
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
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(14, 23);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(131, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Metric Unit (kg, cm)";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(185, 143);
            button1.Name = "button1";
            button1.Size = new Size(108, 27);
            button1.TabIndex = 7;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(25, 176);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(431, 226);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Results for [name]";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 450);
            Controls.Add(groupBox2);
            Controls.Add(button1);
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
        private RadioButton radioButton1;
        private Button button1;
        private GroupBox groupBox2;
    }
}
