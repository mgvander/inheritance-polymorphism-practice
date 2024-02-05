using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_inclass_3
{
    internal class HourlyEmployee
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
        private decimal hourlyRate;
        private decimal hoursPerWeek;

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

        public decimal HourlyRate
        {
            get { return hourlyRate; }
            set { hourlyRate = value; }
        }

        public decimal HoursPerWeek
        {
            get { return hoursPerWeek; }
            set { hoursPerWeek = value; }
        }

        public decimal WeeklySalary
        {
            get { return hourlyRate * hoursPerWeek; }
        }        

        public decimal YearlySalary
        {
            get { return (WeeklySalary * WEEKS_PER_YEAR); }
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
            return (WeeklySalary * WEEKS_PER_YEAR).ToString("C");
        }

        //*****************************
        //Constructors
        //*****************************
        public HourlyEmployee(string FirstName,
                              string LastName,
                              decimal HourlyRate,
                              decimal HoursPerWeek)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
            this.hourlyRate = HourlyRate;
            this.hoursPerWeek = HoursPerWeek;
        }

        public HourlyEmployee()
        {
            //Do Nothing
        }
    }
}
