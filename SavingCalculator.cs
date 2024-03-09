namespace WinFormsApp2
{
    /// <summary>
    /// SavingCalculator class, for the Savings calculator part of the GUI
    /// Holds instance variables for the user-input values, Getters and Setters, and methods for calculation
    /// </summary>
    internal class SavingCalculator
    {
        private double initialDeposit = 0;
        private double monthlyDeposit = 0;
        private double yearPeriod = 0;
        private double interest = 0;
        private double fees = 0;

        private double finalBalance = 0;
        private double totalAmountPaid = 0;
        private double totalInterest = 0;
        private double totalFees = 0;

        #region Getters and Setters
        /// <summary>
        /// Gets instance variable initialDeposit
        /// </summary>
        /// <returns>private double initialDeposit</returns>
        public double GetInitialDeposit()
        { 
            return initialDeposit;
        }
        /// <summary>
        /// Sets instance variable initialDeposit
        /// </summary>
        /// <param name="value">double input value, from textbox</param>
        public void SetInitialDeposit(double value)
        {
            if (value >= 0)
            {
                initialDeposit = value;
            }
        }

        /// <summary>
        /// Gets instance variable monthlyDeposit
        /// </summary>
        /// <returns>private double initialDeposit</returns>
        public double GetMonthlyDeposit()
        {
            return monthlyDeposit;
        }
        /// <summary>
        /// Sets instance variable monthlyDeposit
        /// </summary>
        /// <param name="value">double input value, from textbox</param>
        public void SetMonthlyDeposit(double value)
        {
            if (value >= 0)
            {
                monthlyDeposit = value;
            }
        }

        /// <summary>
        /// Gets instance variable yearPeriod
        /// </summary>
        /// <returns>private double yearPeriod</returns>
        public double GetPeriod()
        {
            return yearPeriod;
        }
        /// <summary>
        /// Sets instance variable yearPeriod
        /// </summary>
        /// <param name="value">double input value, from textbox</param>
        public void SetPeriod(double value)
        {
            if (value >= 0)
            {
                yearPeriod = value;
            }
        }

        /// <summary>
        /// Gets instance variable interest
        /// </summary>
        /// <returns>private double interest</returns>
        public double GetInterest()
        {
            return interest;
        }
        /// <summary>
        /// Sets instance variable interest
        /// </summary>
        /// <param name="value">double input value, from textbox</param>
        public void SetInterest(double value)
        {
            if (value >= 0)
            {
                interest = value;
            }
        }

        /// <summary>
        /// Gets instance variable fees
        /// </summary>
        /// <returns>private double fees</returns>
        public double GetFees()
        {
            return fees;
        }
        /// <summary>
        /// Sets instance variable fees
        /// </summary>
        /// <param name="value">double input value, from textbox</param>
        public void SetFees(double value)
        {
            if (value >= 0)
            {
                fees = value;
            }
        }
        #endregion

        #region Calculate and Display Results
        /// <summary>
        /// Gets instance variable finalBalance, to be displayed
        /// </summary>
        /// <returns>double finalBalance</returns>
        public double GetBalance()
        {
            return finalBalance;
        }
        /// <summary>
        /// Gets instance variable totalAmountPaid, to be displayed
        /// </summary>
        /// <returns>double totalAmountPaid</returns>
        public double GetAmountPaid()
        {
            return totalAmountPaid;
        }
        /// <summary>
        /// Gets instance variable totalInterest, to be displayed
        /// </summary>
        /// <returns>double totalInterest</returns>
        public double GetTotalInterest()
        { 
            return totalInterest;
        }
        /// <summary>
        /// Gets instance variable totalFees, to be displayed
        /// </summary>
        /// <returns>double totalFees</returns>
        public double GetTotalFees()
        { 
            return totalFees; 
        }

        /// <summary>
        /// Calculates savings based on user-input parameters, on a monthly period basis.
        /// </summary>
        public void CalculateSavings()
        {
            finalBalance = initialDeposit + monthlyDeposit;
            double months = yearPeriod * 12;
            double monthlyInterest = interest / 100 / 12;
            double monthlyFees = fees / 100 / 12;

            totalAmountPaid = initialDeposit + (months * monthlyDeposit);

            for (var month = 1; month < months; month++)
            { 
                var newInterest = monthlyInterest * finalBalance;
                var newFees = monthlyFees * finalBalance;

                finalBalance += newInterest - newFees + monthlyDeposit;

                totalInterest += newInterest;
                totalFees += newFees;
            }
        }
        #endregion
    }
}
