namespace WinFormsApp2
{
    public partial class MainForm : Form
    {
        private BMICalculator bmiCalc = new();
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
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

            lblNormalBMI.Text = "Normal BMI is between 18.50 and 24.90";
            lblNormalWeight.Text = string.Empty;
        }

        private void btnBMICalc_Click(object sender, EventArgs e)
        {
            bool ok = ReadInput();

            if (ok)
            {
                DisplayResults();
            }
        }
        private void rbtnMetric_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMetric.Checked)
            {
                lblHeight.Text = "Height (cm)";
                lblWeight.Text = "Weight (kg)";
                bmiCalc.SetUnit(UnitTypes.Metric);

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
                bmiCalc.SetUnit(UnitTypes.Imperial);

                lblFeet.Visible = true;
                lblInches.Visible = true;
                txtUSInches.Visible = true;
            }
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

        private bool ReadInput()
        {
            ReadName();
            //ReadUnitType();
            bool heightOK = ReadHeight();
            bool weightOK = ReadWeight();

            return heightOK && weightOK;
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

            if(!ok)
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

        private void DisplayResults()
        {
            lblResultYourBMI.Text = bmiCalc.CalculateBMI().ToString("0.00");
            lblResultWeightCategory.Text = bmiCalc.BMIWeightCategory();
            grpResults.Text = $"Results for {bmiCalc.GetName()}";
            lblNormalWeight.Text = bmiCalc.CalculateNormalWeight();
        }
    }
}
