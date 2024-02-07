﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_inclass_3
{
    internal class HourlyEmployee : Employee
    {
        //*****************************
        //Variable / Backing fields
        //*****************************
        private decimal _hourlyRate;
        private decimal _hoursPerWeek;

        //*****************************
        //Properties
        //*****************************        
        public decimal HourlyRate
        {
            get { return _hourlyRate; }
            set { _hourlyRate = value; }
        }

        public decimal HoursPerWeek
        {
            get { return _hoursPerWeek; }
            set { _hoursPerWeek = value; }
        }

        public decimal WeeklySalary
        {
            get { return _hourlyRate * _hoursPerWeek; }
        }        

        public decimal YearlySalary
        {
            get { return (WeeklySalary * WEEKS_PER_YEAR); }
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
        public HourlyEmployee(string firstName,
                              string lastName,
                              decimal HourlyRate,
                              decimal HoursPerWeek) 
                                  // Call the parent constructor with the base
                                  // keyword and pass in firstName and lastName
                                  : base(firstName, lastName)
        {
            // No need to set first and last name since they are
            // handled by the work in the parent constructor.
            this._hourlyRate = HourlyRate;
            this._hoursPerWeek = HoursPerWeek;

        }

        public HourlyEmployee()
        {
            //Do Nothing
        }
    }
}
