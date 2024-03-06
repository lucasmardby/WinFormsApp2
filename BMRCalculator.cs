using System.Xml.Linq;

namespace WinFormsApp2
{
    internal class BMRCalculator
    {
        private int age = 0;
        private double height = 0;
        private double weight = 0;
        private BMRGender gender;
        private ActivityLevels activityLevels;

        #region Getters and Setters
        public int GetAge()
        {
            return age;
        }
        public void SetAge(int value)
        {
            if(value >= 0)
            { 
                age = value;
            }
        }
        public double GetHeight()
        {
            return height;
        }
        public void SetHeight(double value)
        {
            if (value >= 0)
            {
                height = value;
            }
        }
        public double GetWeight()
        {
            return weight;
        }
        public void SetWeight(double value)
        {
            if (value >= 0)
            {
                weight = value;
            }
        }
        public BMRGender GetGender()
        {
            return gender;
        }
        public void SetGender(BMRGender value)
        {
            gender = value;
        }
        public ActivityLevels GetActivityLevel()
        {
            return activityLevels;
        }
        public void SetActivityLevel(ActivityLevels value)
        {
            activityLevels = value;
        }
        #endregion

        #region Calculators
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
        public double CalculateMaintainWeightBMRs() 
        {
            double maintainWeightBMRs = CalculateBMR() * CalculateActivityFactor();

            return maintainWeightBMRs;

        }
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
