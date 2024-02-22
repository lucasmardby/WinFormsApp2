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
            this.Text = "The Body Mass Calculator";

            rbtnMetric.Checked = true;
            lblHeight.Text = "Height (cm)";
            lblWeight.Text = "Weight (kg)";

            txtHeight.Text = string.Empty;
            txtWeight.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bmiCalc.SetName(txtName.Text.Trim());
            bool ok = ReadInputBMI();

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
            }
        }
        private void rbtnUsUnit_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnUsUnit.Checked)
            {
                lblHeight.Text = "Height (feet)";
                lblWeight.Text = "Weight (lbs)";
                bmiCalc.SetUnit(UnitTypes.Imperial);
            }
        }

        private bool ReadInputBMI()
        {
            bool heightOK = ReadHeight();
            bool weightOK = ReadWeight();

            return heightOK && weightOK;
        }
        private bool ReadHeight()
        {
            bool ok = double.TryParse(txtHeight.Text.Trim(), out double height);

            if (height > 0)
            {
                if (bmiCalc.GetUnit() == UnitTypes.Metric)
                {
                    bmiCalc.SetHeight(height / 100.00);
                }
                else
                { 
                    bmiCalc.SetHeight(height * 12.00);
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
        }
    }
}
