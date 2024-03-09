namespace WinFormsApp2
{
    /// <summary>
    /// BMRCalculator class, for the BMR calculator part of the GUI
    /// Holds instance variables for the user-input values, Getters and Setters, and methods for calculation
    /// </summary>
    internal class BMRCalculator
    {
        private int age = 0;
        private double height = 0;
        private double weight = 0;
        private BMRGender gender;
        private ActivityLevels activityLevels;

        #region Getters and Setters
        /// <summary>
        /// Gets instance variable age
        /// </summary>
        /// <returns>private int age</returns>
        public int GetAge()
        {
            return age;
        }
        /// <summary>
        /// Sets instance variable age
        /// </summary>
        /// <param name="value">int input value, from textbox</param>
        public void SetAge(int value)
        {
            if(value >= 0)
            { 
                age = value;
            }
        }

        /// <summary>
        /// Gets instance variable weight
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
            {
                height = value;
            }
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
            {
                weight = value;
            }
        }

        /// <summary>
        /// Gets enum BMRGender
        /// </summary>
        /// <returns>enum BMRGender gender</returns>
        public BMRGender GetGender()
        {
            return gender;
        }
        /// <summary>
        /// Sets the BMRGender
        /// </summary>
        /// <param name="value">BMRGender gender, from radio buttons</param>
        public void SetGender(BMRGender value)
        {
            gender = value;
        }

        /// <summary>
        /// Gets enum ActivityLevels
        /// </summary>
        /// <returns>enum ActivityLevels activityLevel</returns>
        public ActivityLevels GetActivityLevel()
        {
            return activityLevels;
        }
        /// <summary>
        /// Sets ActivityLevels
        /// </summary>
        /// <param name="value">ActivityLevels activityLevel, from radio buttons</param>
        public void SetActivityLevel(ActivityLevels value)
        {
            activityLevels = value;
        }
        #endregion

        #region Calculators
        /// <summary>
        /// Calculates BMR based on weight, height, age, and gender
        /// </summary>
        /// <returns>double BMR</returns>
        public double CalculateBMR()
        {
            double BMR = 0.00;
            int genderFactor = 0;

            BMR = 10 * weight + 6.25 * height - 5 * age;

            if (GetGender() == BMRGender.Female)
            {
                BMR -= 161;
            }
            else if (GetGender() == BMRGender.Male)
            {
                BMR += 5;
            }

            return BMR;

        }
        /// <summary>
        /// Calculates MaintainWeightBMR based on BMR and ActivityLevel factor
        /// </summary>
        /// <returns>double maintainWeightBMRs</returns>
        public double CalculateMaintainWeightBMRs() 
        {
            double maintainWeightBMRs = CalculateBMR() * CalculateActivityFactor();

            return maintainWeightBMRs;

        }
        /// <summary>
        /// Calculates the activity level factor, based on the activityLevel
        /// </summary>
        /// <returns>double factor, for activity level</returns>
        private double CalculateActivityFactor()
        {
            double factor = 0.00;

            switch (activityLevels)
            {
                case ActivityLevels.Sedentary:
                    factor = 1.2;
                    return factor;
                case ActivityLevels.LightlyActive:
                    factor = 1.375;
                    return factor;
                case ActivityLevels.ModeratelyActive:
                    factor = 1.550;
                    return factor;
                case ActivityLevels.VeryActive:
                    factor = 1.725;
                    return factor;
                case ActivityLevels.ExtraActive:
                    factor = 1.9;
                    return factor;
                default: 
                    return factor;
            }
        }
        #endregion
    }
}
