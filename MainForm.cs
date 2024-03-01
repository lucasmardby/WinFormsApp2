namespace WinFormsApp2
{
    public partial class MainForm : Form
    {
        private BMICalculator bmiCalc = new();
        private SavingCalculator savingCalc = new();
        private BMRCalculator bmrCalc = new();

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            InitializeGUIBMI();
            InitializeGUISavings();
            InitializeGUIBMR();
        }

        #region BMICalculator
        private void InitializeGUIBMI()
        {
            rbtnMetric.Checked = true;
            lblHeight.Text = "Height (cm)";
            lblWeight.Text = "Weight (kg)";

            txtName.Text = string.Empty;
            txtHeight.Text = string.Empty;
            txtWeight.Text = string.Empty;

            lblFeet.Visible = false;
            lblInches.Visible = false;
            txtUSInches.Visible = false;

            lblNormalBMI.Text = string.Empty;
            lblNormalWeight.Text = string.Empty;
        }
        private void btnBMICalc_Click(object sender, EventArgs e)
        {
            bool ok = ReadInputBMI();

            if (ok)
            {
                DisplayResultsBMI();
            }
        }
        private void rbtnMetric_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMetric.Checked)
            {
                lblHeight.Text = "Height (cm)";
                lblWeight.Text = "Weight (kg)";

                lblFeet.Visible = false;
                lblInches.Visible = false;
                txtUSInches.Visible = false;
            }
        }
        private void rbtnUsUnit_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnUsUnit.Checked)
            {
                lblHeight.Text = "Height (feet)";
                lblWeight.Text = "Weight (lbs)";

                lblFeet.Visible = true;
                lblInches.Visible = true;
                txtUSInches.Visible = true;
            }
        }

        private bool ReadInputBMI()
        {
            ReadName();
            ReadUnitType();

            bool heightOK = ReadHeight();
            bool weightOK = ReadWeight();


            return heightOK && weightOK;
        }
        private void ReadName()
        {
            txtName.Text = txtName.Text.Trim();
            if (txtName.Text.IsNotNullOrEmpty())
            {
                bmiCalc.SetName(txtName.Text);
            }
            else
            {
                bmiCalc.SetName("No Name");
            }
        }
        private void ReadUnitType()
        {
            if (rbtnMetric.Checked)
            {
                bmiCalc.SetUnit(UnitTypes.Metric);
            }
            else if (rbtnUsUnit.Checked)
            {
                bmiCalc.SetUnit(UnitTypes.Imperial);
            }
        }
        private bool ReadHeight()
        {
            bool ok = double.TryParse(txtHeight.Text.Trim(), out double height);
            double heightInches = 0.00;

            if (bmiCalc.GetUnit() == UnitTypes.Imperial)
            {
                heightInches = double.Parse(txtUSInches.Text.Trim());
            }

            if (height > 0)
            {
                if (bmiCalc.GetUnit() == UnitTypes.Metric)
                {
                    bmiCalc.SetHeight(height / 100.00);
                }
                else
                {
                    bmiCalc.SetHeight(height * 12.00 + heightInches);
                }
            }
            else
            {
                ok = false;
            }

            if (!ok)
            {
                MessageBox.Show("Invalid height value!", "Error!");
            }

            return ok;
        }
        private bool ReadWeight()
        {
            bool ok = double.TryParse(txtWeight.Text.Trim(), out double weight);

            if (weight > 0)
            {
                if (bmiCalc.GetUnit() == UnitTypes.Metric)
                {
                    bmiCalc.SetWeight(weight);
                }
                else
                {
                    bmiCalc.SetWeight(weight * 703.00);
                }
            }
            else
            {
                ok = false;
            }

            if (!ok)
            {
                MessageBox.Show("Invalid weight value!", "Error!");
            }

            return ok;
        }

        private void DisplayResultsBMI()
        {
            lblResultYourBMI.Text = bmiCalc.CalculateBMI(bmiCalc.GetHeight(), bmiCalc.GetWeight()).ToString("0.00");
            lblResultWeightCategory.Text = bmiCalc.BMIWeightCategory();
            grpResults.Text = $"Results for {bmiCalc.GetName()}";
            lblNormalWeight.Text = bmiCalc.CalculateNormalWeight();
            lblNormalBMI.Text = "Normal BMI is between 18.50 and 24.90";
        }
        #endregion

        #region SavingCalculator
        private void InitializeGUISavings()
        {
            txtInitialDeposit.Text = string.Empty;
            txtMonthlyDeposit.Text = string.Empty;
            txtPeriod.Text = string.Empty;
            txtInterest.Text = string.Empty;
            txtFees.Text = string.Empty;

            lblAmountPaid.Text = string.Empty;
            lblAmountEarned.Text = string.Empty;
            lblFinalBalance.Text = string.Empty;
            lblTotalFees.Text = string.Empty;

            txtInitialDeposit.TextAlign = HorizontalAlignment.Left;
            txtMonthlyDeposit.TextAlign = HorizontalAlignment.Left;
            txtPeriod.TextAlign = HorizontalAlignment.Left;
            txtInterest.TextAlign = HorizontalAlignment.Left;
            txtFees.TextAlign = HorizontalAlignment.Left;
        }

        private void btnSavingCalculate_Click(object sender, EventArgs e)
        {
            bool ok = ReadInputSavings();

            if (ok)
            {
                DisplayResultsSavings();
            }
        }
        private void btnSavingsClear_Click(object sender, EventArgs e)
        {
            InitializeGUISavings();
        }
        private bool ReadInputSavings()
        {
            bool initialOK = ReadInitialDeposit();
            bool monthlyOK = ReadMonthlyDeposit();

            ReadPeriod();
            ReadInterestRate();
            ReadFeeRate();

            return initialOK && monthlyOK;
        }


        private bool ReadInitialDeposit()
        {
            bool ok = double.TryParse(txtInitialDeposit.Text.Trim(), out double deposit);

            if (deposit >= 0)
            {
                savingCalc.SetInitialDeposit(deposit);
            }
            else
            {
                ok = false;
            }

            if (!ok)
            {
                MessageBox.Show("Invalid deposit value!", "Error!");
            }

            return ok;
        }
        private bool ReadMonthlyDeposit()
        {
            bool ok = double.TryParse(txtMonthlyDeposit.Text.Trim(), out double deposit);

            if (deposit >= 0)
            {
                savingCalc.SetMonthlyDeposit(deposit);
            }
            else
            {
                ok = false;
            }

            if (!ok)
            {
                MessageBox.Show("Invalid deposit value!", "Error!");
            }

            return ok;
        }
        private bool ReadPeriod()
        {
            bool ok = double.TryParse(txtPeriod.Text.Trim(), out double years);

            if (years >= 0)
            {
                savingCalc.SetPeriod(years);
            }
            else
            {
                ok = false;
            }

            if (!ok)
            {
                MessageBox.Show("Invalid period value!", "Error!");
            }

            return ok;
        }
        private bool ReadInterestRate()
        {
            bool ok = double.TryParse(txtInterest.Text.Trim(), out double rate);

            if (rate >= 0)
            {
                savingCalc.SetInterest(rate);
            }
            else
            {
                ok = false;
            }

            if (!ok)
            {
                MessageBox.Show("Invalid interest rate!", "Error!");
            }

            return ok;
        }
        private bool ReadFeeRate()
        {
            bool ok = double.TryParse(txtFees.Text.Trim(), out double fee);

            if (fee >= 0)
            {
                savingCalc.SetFees(fee);
            }
            else
            {
                ok = false;
            }

            if (!ok)
            {
                MessageBox.Show("Invalid fee rate!", "Error!");
            }

            return ok;
        }

        private void DisplayResultsSavings()
        {
            savingCalc.CalculateSavings();
            DisplaySavingsInput();

            lblAmountPaid.Text = savingCalc.GetAmountPaid().ToString("0.00");
            lblAmountEarned.Text = savingCalc.GetTotalInterest().ToString("0.00");
            lblFinalBalance.Text = savingCalc.GetBalance().ToString("0.00");
            lblTotalFees.Text = savingCalc.GetTotalFees().ToString("0.00");
        }
        private void DisplaySavingsInput()
        {
            txtInitialDeposit.Text = savingCalc.GetInitialDeposit().ToString("0.00");
            txtInitialDeposit.TextAlign = HorizontalAlignment.Right;

            txtMonthlyDeposit.Text = savingCalc.GetMonthlyDeposit().ToString("0.00");
            txtMonthlyDeposit.TextAlign = HorizontalAlignment.Right;

            txtPeriod.Text = savingCalc.GetPeriod().ToString("0.00");
            txtPeriod.TextAlign = HorizontalAlignment.Right;

            txtInterest.Text = savingCalc.GetInterest().ToString("0.00");
            txtInterest.TextAlign = HorizontalAlignment.Right;

            txtFees.Text = savingCalc.GetFees().ToString("0.00");
            txtFees.TextAlign = HorizontalAlignment.Right;
        }
        #endregion


        #region BMRCalculator

        private void InitializeGUIBMR()
        {

        }

        private void ReadAge()
        {
            bool ok = int.TryParse(txtAge.Text.Trim(), out int age);

            if (age > 0)
            {
                bmrCalc.SetAge(age);
            }
            else
            {
                ok = false;
            }

            if (!ok)
            {
                MessageBox.Show("Invalid age value!", "Error!");
            }
        }
        private void ReadGender()
        { 
            if (rbtnMale.Checked)
            {
                bmrCalc.SetActivityLevel(ActivityLevels.Sedentary);
            }
            else if (rbtnFemale.Checked)
            {
                bmrCalc.SetActivityLevel(ActivityLevels.Sedentary);
            }
        }
        private void ReadActivityLevel()
        {
            if (rbtnSedentary.Checked)
            {
                bmrCalc.SetActivityLevel(ActivityLevels.Sedentary);
            }
            else if (rbtnLightlyActive.Checked)
            {
                bmrCalc.SetActivityLevel(ActivityLevels.LightlyActive);
            }
            else if (rbtnModeratelyActive.Checked)
            {
                bmrCalc.SetActivityLevel(ActivityLevels.ModeratelyActive);
            }
            else if (rbtnVeryActive.Checked)
            {
                bmrCalc.SetActivityLevel(ActivityLevels.VeryActive);
            }
            else if (rbtnExtraActive.Checked)
            {
                bmrCalc.SetActivityLevel(ActivityLevels.ExtraActive);
            }
        }

        #endregion
    }
}
