namespace WinFormsApp2
{
    /// <summary>
    /// MainForm class which takes care of the WinForm. 
    /// Instance variables at the top for each of the classes.
    /// </summary>
    public partial class MainForm : Form
    {
        private BMICalculator bmiCalc = new();
        private SavingCalculator savingCalc = new();
        private BMRCalculator bmrCalc = new();

        /// <summary>
        /// MainForm, Initializing the WinForm and the different GUIs
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        /// <summary>
        /// Initializes the different GUIs, calling one method for each part of the assignment
        /// </summary>
        private void InitializeGUI()
        {
            InitializeGUIBMI();
            InitializeGUISavings();
            InitializeGUIBMR();
        }

        #region Height and Weight, BMI and BMR
        /// <summary>
        /// Reads user input height for the BMI and BMR calculations.
        /// For BMI, it calculates the input into the correct measurement, depending on the unit.
        /// </summary>
        /// <param name="heightBox">Takes the Height Textboxes as params, depending on if you're
        /// calculating BMI or BMR</param>
        /// <returns>True if correct height value is input</returns>
        private bool ReadHeight(TextBox heightBox)
        {
            bool ok = double.TryParse(heightBox.Text.Trim(), out double height);
            double heightInches = 0.00;

            if (bmiCalc.GetUnit() == UnitTypes.Imperial)
            {
                heightInches = double.Parse(txtBMIUSInches.Text.Trim());
            }

            if (height > 0)
            {
                if (bmiCalc.GetUnit() == UnitTypes.Metric)
                {
                    bmiCalc.SetHeight(height / 100.00);
                    bmrCalc.SetHeight(height);
                }
                else if (bmiCalc.GetUnit() == UnitTypes.Imperial)
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
        /// <summary>
        /// Reads user input weight for the BMI and BMR calculations.
        /// For BMI, it calculates the input into the correct measurement, depending on the unit.
        /// </summary>
        /// <param name="weightBox">Takes the Weight Textboxes as params, depending on if you're
        /// calculating BMI or BMR</param>
        /// <returns>True if correct weight value is input</returns>
        private bool ReadWeight(TextBox weightBox)
        {
            bool ok = double.TryParse(weightBox.Text.Trim(), out double weight);

            if (weight > 0)
            {
                if (bmiCalc.GetUnit() == UnitTypes.Metric)
                {
                    bmiCalc.SetWeight(weight);
                    bmrCalc.SetWeight(weight);
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
        #endregion

        #region BMICalculator

        #region BMI Form
        /// <summary>
        /// Initialize the BMI GUI. Setting values, clearing textboxes, and hiding the US units until used.
        /// </summary>
        private void InitializeGUIBMI()
        {
            rbtnMetric.Checked = true;
            lblHeight.Text = "Height (cm)";
            lblWeight.Text = "Weight (kg)";

            txtBMIName.Text = string.Empty;
            txtBMIHeight.Text = string.Empty;
            txtBMIWeight.Text = string.Empty;

            lblFeet.Visible = false;
            lblInches.Visible = false;
            txtBMIUSInches.Visible = false;

            lblNormalBMI.Text = string.Empty;
            lblNormalWeight.Text = string.Empty;
        }

        /// <summary>
        /// BMI button, reading user-input values and displaying BMI results.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBMICalc_Click(object sender, EventArgs e)
        {
            bool ok = ReadInputBMI();

            if (ok)
            {
                DisplayResultsBMI();
            }
        }

        /// <summary>
        /// Metric Radio Button, changing the units on the GUI and the UnitType to Metric.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnMetric_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMetric.Checked)
            {
                lblHeight.Text = "Height (cm)";
                lblWeight.Text = "Weight (kg)";

                lblFeet.Visible = false;
                lblInches.Visible = false;
                txtBMIUSInches.Visible = false;
            }
        }

        /// <summary>
        /// Imperial Radio Button, changing the units on the GUI and the UnitType to Imperial.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnUsUnit_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnUsUnit.Checked)
            {
                lblHeight.Text = "Height (feet)";
                lblWeight.Text = "Weight (lbs)";

                lblFeet.Visible = true;
                lblInches.Visible = true;
                txtBMIUSInches.Visible = true;
            }
        }
        #endregion

        #region Readers
        /// <summary>
        /// Reads all BMI input, and sets all BMI variables: Height, Weight, Name, and UnitType 
        /// </summary>
        /// <returns>True if height and weight are correct values</returns>
        private bool ReadInputBMI()
        {
            ReadName();
            ReadUnitType();

            bool heightOK = ReadHeight(txtBMIHeight);
            bool weightOK = ReadWeight(txtBMIWeight);


            return heightOK && weightOK;
        }

        /// <summary>
        /// Reads user-input Name from textbox, and uses SetName to set its variable.
        /// Uses StringExtentionMethod 'IsNotNullOrEmpty' to check string validity
        /// </summary>
        private void ReadName()
        {
            txtBMIName.Text = txtBMIName.Text.Trim();
            if (txtBMIName.Text.IsNotNullOrEmpty())
            {
                bmiCalc.SetName(txtBMIName.Text);
            }
            else
            {
                bmiCalc.SetName("No Name");
            }
        }

        /// <summary>
        /// Reads which Unit radio button is checked, and sets the UnitType
        /// </summary>
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
        #endregion

        /// <summary>
        /// Display BMI results: BMI, Weight Category, and texts for Name and NormalWeight
        /// </summary>
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

        #region Savings Form
        /// <summary>
        /// Initialize the Savings GUI. Clearing textboxes and lables, and aligns the text.
        /// </summary>
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

        /// <summary>
        /// Savings button, reading user-input values and displaying Savings results.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSavingCalculate_Click(object sender, EventArgs e)
        {
            bool ok = ReadInputSavings();

            if (ok)
            {
                DisplayResultsSavings();
            }
        }

        /// <summary>
        /// Clear button, which clears all text input into the Savings calculator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSavingsClear_Click(object sender, EventArgs e)
        {
            InitializeGUISavings();
        }
        #endregion

        #region Readers
        /// <summary>
        /// Reads all Savings input, and sets all Savings variables
        /// </summary>
        /// <returns>True if initital and monthly deposits are correct values</returns>
        private bool ReadInputSavings()
        {
            bool initialOK = ReadInitialDeposit();
            bool monthlyOK = ReadMonthlyDeposit();

            ReadPeriod();
            ReadInterestRate();
            ReadFeeRate();

            return initialOK && monthlyOK;
        }

        /// <summary>
        /// Reads user input text from Initial Deposit textbox
        /// </summary>
        /// <returns>True if a correct value is input, false if not</returns>
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

        /// <summary>
        /// Reads user input text from Monthly Deposit textbox
        /// </summary>
        /// <returns>True if a correct value is input, false if not</returns>
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

        /// <summary>
        /// Reads user input text from period textbox
        /// </summary>
        /// <returns>True if a correct value is input, false if not</returns>
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

        /// <summary>
        /// Reads user input text from interest rate textbox
        /// </summary>
        /// <returns>True if a correct value is input, false if not</returns>
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

        /// <summary>
        /// Reads user input text from fee rate textbox
        /// </summary>
        /// <returns>True if a correct value is input, false if not</returns>
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
        #endregion

        #region Display
        /// <summary>
        /// Calculates input and displays savings to the corresponding labels
        /// </summary>
        private void DisplayResultsSavings()
        {
            savingCalc.CalculateSavings();
            DisplaySavingsInput();

            lblAmountPaid.Text = savingCalc.GetAmountPaid().ToString("0.00");
            lblAmountEarned.Text = savingCalc.GetTotalInterest().ToString("0.00");
            lblFinalBalance.Text = savingCalc.GetBalance().ToString("0.00");
            lblTotalFees.Text = savingCalc.GetTotalFees().ToString("0.00");
        }

        /// <summary>
        /// Formats and aligns the user input values in their textboxes
        /// </summary>
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

        #endregion

        #region BMRCalculator

        #region BMR Form
        /// <summary>
        /// Initialize the BMR GUI. Setting values, clearing textboxes and the listbox.
        /// </summary>
        private void InitializeGUIBMR()
        {
            txtBMRAge.Text = string.Empty;
            txtBMRHeight.Text = string.Empty;
            txtBMRWeight.Text = string.Empty;

            rbtnFemale.Checked = true;
            rbtnSedentary.Checked = true;

            listboxBMR.Items.Clear();
        }

        /// <summary>
        /// BMR button, sets the UnitType to Metric for the BMR calculation,
        /// and reads user-input values to display BMR results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculateBMR_Click(object sender, EventArgs e)
        {
            bmiCalc.SetUnit(UnitTypes.Metric);

            bool ok = ReadBMRInput();

            if (ok)
            {
                DisplayResultsBMR();
            }
        }
        #endregion

        #region Readers

        /// <summary>
        /// Reads all BMR input, and sets all BMR variables: Height, Weight, Age, Gender, and ActivityLevel
        /// </summary>
        /// <returns>True if height and weight are correct values</returns>
        private bool ReadBMRInput()
        {
            ReadAge();
            ReadGender();
            ReadActivityLevel();

            bool heightOK = ReadHeight(txtBMRHeight);
            bool weightOK = ReadWeight(txtBMRWeight);

            return heightOK && weightOK;
        }

        /// <summary>
        /// Reads user input age from txtAge for the BMR calculation. 
        /// Gives ok if user inputs a correct number.
        /// </summary>
        private void ReadAge()
        {
            bool ok = int.TryParse(txtBMRAge.Text.Trim(), out int age);

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

        /// <summary>
        /// Reads user-input gender from the radio buttons, and sets the Gender
        /// </summary>
        private void ReadGender()
        {
            if (rbtnMale.Checked)
            {
                bmrCalc.SetGender(BMRGender.Female);
            }
            else if (rbtnFemale.Checked)
            {
                bmrCalc.SetGender(BMRGender.Male);
            }
        }

        /// <summary>
        /// Reads user-input ActivityLevel from the radio buttons, and sets the ActivityLevel
        /// </summary>
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

        /// <summary>
        /// Display BMR results, BMR and MaintainWeightBMR in a listbox
        /// </summary>
        private void DisplayResultsBMR()
        { 
            double maintainWeightBMR = bmrCalc.CalculateMaintainWeightBMRs();
            listboxBMR.Items.Clear();
            listboxBMR.Items.Add("BMR RESULTS");
            listboxBMR.Items.Add("");
            listboxBMR.Items.Add($"Your BMR (calories/day){new string (' ',65)}{bmrCalc.CalculateBMR():##000.0}");
            listboxBMR.Items.Add($"Calories to maintain your weight {new string(' ', 49)}{maintainWeightBMR:##000.0}");
            listboxBMR.Items.Add($"Calories to lose 0,5 kg per week {new string(' ', 52)}{(maintainWeightBMR - 500):##000.0}");
            listboxBMR.Items.Add($"Calories to lose 1 kg per week {new string(' ', 55)}{(maintainWeightBMR - 1000):##000.0}");
            listboxBMR.Items.Add($"Calories to gain 0,5 kg per week {new string(' ', 52)}{(maintainWeightBMR + 500):##000.0}");
            listboxBMR.Items.Add($"Calories to gain 1 kg per week {new string(' ', 55)}{(maintainWeightBMR + 1000):##000.0}");
            listboxBMR.Items.Add("");
            listboxBMR.Items.Add("Losing more than 1000 calories per day is to be avoided.");
        }

        #endregion

        
    }
}
