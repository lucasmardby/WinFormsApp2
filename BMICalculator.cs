namespace WinFormsApp2
{
    /// <summary>
    /// BMICalculator class, for the BMI calculator part of the GUI
    /// Holds instance variables for the user-input values, Getters and Setters, and methods for calculation
    /// </summary>
    internal class BMICalculator
    {
        private string name = "No Name";
        private double height = 0;
        private double weight = 0;
        private UnitTypes unit;

        #region Getters and Setters

        /// <summary>
        /// Gets instance variable name
        /// </summary>
        /// <returns>private string name</returns>
        public string GetName()
        { 
            return name;
        }
        /// <summary>
        /// Sets instance variable name
        /// </summary>
        /// <param name="value">string input value, from textbox</param>
        public void SetName(string value)
        {
            if (value.IsNotNullOrEmpty())
            {
                name = value;
            }
        }

        /// <summary>
        /// Gets instance variable height
        /// </summary>
        /// <returns>private double height</returns>
        public double GetHeight()
        {
            return height;
        }
        /// <summary>
        /// Sets instance variable height
        /// </summary>
        /// <param name="value">double input value, from textbox</param>
        public void SetHeight(double value)
        {
            if (value >= 0)
                height = value;
        }

        /// <summary>
        /// Gets instance variable weight
        /// </summary>
        /// <returns>private double weight</returns>
        public double GetWeight()
        {
            return weight;
        }
        /// <summary>
        /// Sets instance variable weight
        /// </summary>
        /// <param name="value">double input value, from textbox</param>
        public void SetWeight(double value)
        {
            if (value >= 0)
                weight = value;
        }

        /// <summary>
        /// Gets enum UnitType
        /// </summary>
        /// <returns>enum UnitType unit</returns>
        public UnitTypes GetUnit()
        {
            return unit;
        }
        /// <summary>
        /// Sets the UnitType
        /// </summary>
        /// <param name="value">UnitType unit, from radio buttons</param>
        public void SetUnit(UnitTypes value)
        {
            unit = value;
        }
        #endregion

        #region Calculators
        /// <summary>
        /// Calculates BMI
        /// </summary>
        /// <param name="height">takes height into calculation</param>
        /// <param name="weight">takes weight into calculation</param>
        /// <returns>BMI result in a double amount</returns>
        public double CalculateBMI(double height, double weight)
        {
            double amount = weight / (height * height);
            return amount;
        }

        /// <summary>
        /// Uses GetHeight and GetWeight with CalculateBMI to get a weight category based on the BMI
        /// </summary>
        /// <returns>string textOut as a result</returns>
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

        /// <summary>
        /// Calculates and prints out sentence for NormalWeight, based on the BMI and UnitType 
        /// </summary>
        /// <returns></returns>
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
