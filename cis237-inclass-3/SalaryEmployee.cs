/// Author: Michael VanderMyde
/// Course: CIS 237
/// Inclass 3

using System;

namespace cis237_inclass_3
{
    class SalaryEmployee
    {
        //*****************************
        // Constants
        //*****************************
        const int WEEKS_PER_YEAR = 52;

        //*****************************
        //Variable / Backing fields
        //*****************************
        private string firstName;
        private string lastName;
        private decimal weeklySalary;
        private decimal yearlyBonus;

        //*****************************
        //Properties
        //*****************************
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public decimal WeeklySalary
        {
            get { return weeklySalary; }
        }

        public decimal YearlyBonus
        {
            get { return yearlyBonus; }
            set { yearlyBonus = value; }
        }

        public decimal YearlySalary
        {
            get { return (WeeklySalary * WEEKS_PER_YEAR) + yearlyBonus; }
        }

        //******************************
        //Public Methods
        //******************************
        public string FirstAndLastName()
        {
            return firstName + " " + lastName;
        }

        public override string ToString()
        {
            return $"{firstName} {lastName} {WeeklySalary.ToString("C")}";
        }

        public string FormattedWeeklySalary()
        {
            return WeeklySalary.ToString("C");
        }

        public string FormattedYearlySalary()
        {
            return ((WeeklySalary * WEEKS_PER_YEAR) + yearlyBonus).ToString("C");
        }

        //*****************************
        //Constructors
        //*****************************
        public SalaryEmployee(string FirstName, 
                              string LastName, 
                              decimal WeeklySalary,
                              decimal YearlyBonus)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
            this.weeklySalary = WeeklySalary;
            this.yearlyBonus = YearlyBonus;
        }

        public SalaryEmployee()
        {
            //Do Nothing
        }
    }
}
