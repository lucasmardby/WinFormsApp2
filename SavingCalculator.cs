namespace WinFormsApp2
{
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

        public double GetInitialDeposit()
        { 
            return initialDeposit;
        }
        public void SetInitialDeposit(double value)
        {
            if (value >= 0)
            {
                initialDeposit = value;
            }
        }

        public double GetMonthlyDeposit()
        {
            return monthlyDeposit;
        }
        public void SetMonthlyDeposit(double value)
        {
            if (value >= 0)
            {
                monthlyDeposit = value;
            }
        }

        public double GetPeriod()
        {
            return yearPeriod;
        }
        public void SetPeriod(double value)
        {
            if (value >= 0)
            {
                yearPeriod = value;
            }
        }

        public double GetInterest()
        {
            return interest;
        }
        public void SetInterest(double value)
        {
            if (value >= 0)
            {
                interest = value;
            }
        }

        public double GetFees()
        {
            return fees;
        }
        public void SetFees(double value)
        {
            if (value >= 0)
            {
                fees = value;
            }
        }

        public double GetBalance()
        {
            return finalBalance;
        }
        public double GetAmountPaid()
        {
            return totalAmountPaid;
        }
        public double GetTotalInterest()
        { 
            return totalInterest;
        }
        public double GetTotalFees()
        { 
            return totalFees; 
        }

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
    }
}
