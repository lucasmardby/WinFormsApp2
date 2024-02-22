namespace WinFormsApp2
{
    internal class BMICalculator
    {
        private string name = "No Name";
        private double height = 0;
        private double weight = 0;
        private UnitTypes unit;

        public string GetName()
        { 
            return name;
        }
        public void SetName(string value)
        {
            if (value.IsNotNullOrEmpty())
            {
                name = value;
            }
        }

        public double GetHeight()
        {
            return height;
        }
        public void SetHeight(double value)
        {
            if (value >= 0)
                height = value;
        }

        public double GetWeight()
        {
            return weight;
        }
        public void SetWeight(double value)
        {
            if (value >= 0)
                weight = value;
        }

        public UnitTypes GetUnit()
        {
            return unit;
        }
        public void SetUnit(UnitTypes value)
        {
            unit = value;
        }

        public double CalculateBMI()
        {
            double amount = weight / (height * height);
            return amount;
        }
        public string BMIWeightCategory()
        {
            double bmi = CalculateBMI();
            string textOut = string.Empty;

            if (bmi < 18.5)
                textOut = "Underweight";
            else if (bmi <= 24.9)
                textOut = "Normal weight";
            else if (bmi <= 29.9)
                textOut = "Overweight (Pre-obesity)";
            else if (bmi <= 34.9)
                textOut = "Overweight (Obesity class I)";
            else if (bmi <= 34.9)
                textOut = "Overweight (Obesity class II)";
            else if (bmi <= 34.9)
                textOut = "Overweight (Obesity class III)";

            return textOut;
        }
    }
}
