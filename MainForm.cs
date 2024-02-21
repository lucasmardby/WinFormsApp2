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

            rbtnUsUnit.Checked = true;
            lblHeight.Text = "Height (feet)";
            lblWeight.Text = "Weight (lbs)";

            txtHeight.Text = string.Empty;
            txtWeight.Text = string.Empty;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool ok = ReadInputBMI();

            if (ok)
            {
                //DisplayResults();
            }
        }

        private bool ReadInputBMI()
        {
            bool heightOK = ReadHeight();
            bool weightOK = ReadWeight();

            return heightOK && weightOK;
        }

        private string ReadName()
        {
            string name = txtName.Text;

            if (name.IsNotNullOrEmpty())
            {
                return name;
            }
            else
            {
                name = "No Name";
                return name;
            }
        }

        private bool ReadHeight()
        {
            bool ok;
            string strHeight = txtHeight.Text;
            strHeight = strHeight.Trim();
            ok = double.TryParse(strHeight, out double height);

            if (ok)
            {
                bmiCalc.SetHeight(height);
            }
            else
            {
                MessageBox.Show("Invalid amount!", "Error!");
            }
            return ok;
        }
        private bool ReadWeight()
        {
            bool ok;
            string strWeight = txtHeight.Text;
            strWeight = strWeight.Trim();
            ok = double.TryParse(strWeight, out double weight);

            if (ok)
            {
                bmiCalc.SetWeight(weight);
            }
            else
            {
                MessageBox.Show("Invalid amount!", "Error!");
            }
            return ok;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
