﻿namespace WinFormsApp2
{
    internal class BMICalculator
    {
        private string name = "No Name";
        private double height = 0;
        private double weight = 0;
        private UnitTypes unit;

        #region Getters and Setters
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
        #endregion

        #region Calculators
        public double CalculateBMI(double height, double weight)
        {
            double amount = weight / (height * height);
            return amount;
        }
        public string BMIWeightCategory()
        {
            double bmi = CalculateBMI(GetHeight(), GetWeight());
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
        public string CalculateNormalWeight()
        {
            double factor = 1;
            string measurementUnit = "kg";

            if (GetUnit() == UnitTypes.Imperial)
            {
                factor = 703;
                measurementUnit = "lbs";
            }

            double lowWeight = height * height / factor * 18.50;
            double highWeight = height * height / factor * 24.90;

            string weightValues = $"Normal weight should be between {lowWeight:0.00} and {highWeight:0.00} {measurementUnit}";

            return weightValues;
        }
        #endregion
    }
}
