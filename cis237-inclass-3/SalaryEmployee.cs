/// Author: Michael VanderMyde
/// Course: CIS 237
/// Inclass 3

using System;

namespace cis237_inclass_3
{
    public class SalaryEmployee : Employee
    {
        //*****************************
        //Variable / Backing fields
        //*****************************
        private decimal _weeklySalary;
        private decimal _yearlyBonus;

        //*****************************
        //Properties
        //*****************************
        public override decimal WeeklySalary
        {
            get { return _weeklySalary; }
        }

        public decimal YearlyBonus
        {
            get { return _yearlyBonus; }
            set { _yearlyBonus = value; }
        }

        public override decimal YearlySalary
        {
            get { return base.YearlySalary + _yearlyBonus; }
        }

        //******************************
        //Public Methods
        //******************************
        public override string ToString()
        {
            // Ask the parent to do the first and last name part by
            // calling the ToString method in the parent/base class
            return $"{base.ToString()} {WeeklySalary.ToString("C")}";
        }

        public override string FormattedWeeklySalary()
        {
            return WeeklySalary.ToString("C");
        }

        public override string FormattedYearlySalary()
        {
            return ((WeeklySalary * WEEKS_PER_YEAR) + _yearlyBonus).ToString("C");
        }

        //*****************************
        //Constructors
        //*****************************
        public SalaryEmployee(string firstName, 
                              string lastName, 
                              decimal weeklySalary,
                              decimal yearlyBonus)
                                  // Call the parent constructor with the base
                                  // keyword and pass in firstName and lastName
                                  : base(firstName, lastName)
        {
            // No need to set first and last name since they are
            // handled by the work in the parent constructor.
            this._weeklySalary = weeklySalary;
            this._yearlyBonus = yearlyBonus;

        }

        public SalaryEmployee()
        {
            //Do Nothing
        }
    }
}
