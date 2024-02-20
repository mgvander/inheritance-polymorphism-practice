/// Author: Michael VanderMyde
/// Course: CIS 237
/// Inclass 3

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_inclass_3
{
    public abstract class Employee : IEmployee
    {
        //*****************************
        // Constants
        //*****************************
        protected const int WEEKS_PER_YEAR = 52;

        //*****************************
        //Variable / Backing fields
        //*****************************
        protected string _firstName;
        protected string _lastName;

        //*****************************
        //Properties
        //*****************************
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public int Age { get; set; }

        // Made this property abstract because we want all sub-classes to implement it,
        // but we don't know how. So we leave the details to the sub-classes.
        // Abstract properties must...
        // 1. Have no body
        // 2. Be overridden in child classes
        // 3. Must be in an abstract class
        public abstract decimal WeeklySalary { get; }

        // Made this property virtual because we know that the YearlySalary can be
        // implemented by taking the WeeklySalary and multiplying it by the weeks in a year.
        // We left it virtual though in case it needs to be overridden in child class, which
        // we did to include a yearly bonus.
        // Virtual properties...
        // 1. Must have a body.
        // 2. Can be overridden in child classes, but don't have to be.
        // 3. Can exist in any class. (Not limited to abstract classes)
        public virtual decimal YearlySalary
        {
            get { return WeeklySalary * WEEKS_PER_YEAR; }
        }

        //******************************
        //Public Methods
        //******************************
        public string FirstAndLastName()
        {
            return _firstName + " " + _lastName;
        }

        public override string ToString()
        {
            return $"{_firstName} {_lastName}";
        }

        // Made this method abstract because we want all sub-classes to implement it,
        // but we don't know how. So we leave the details to the sub-classes.
        // Abstract methods must...
        // 1. Have no body
        // 2. Be overridden in child classes
        // 3. Must be in an abstract class
        public abstract string FormattedWeeklySalary();

        // Made this method virtual because we know that the YearlySalary can be
        // implemented by taking the WeeklySalary and multiplying it by the weeks in a year.
        // We left it virtual though in case it needs to be overridden in child class, which
        // we did to include a yearly bonus.
        // Virtual methods...
        // 1. Must have a body.
        // 2. Can be overridden in child classes, but don't have to be.
        // 3. Can exist in any class. (Not limited to abstract classes)
        public virtual string FormattedYearlySalary()
        {
            return (WeeklySalary * WEEKS_PER_YEAR).ToString("C");

        }

        //*****************************
        //Constructors
        //*****************************
        public Employee(string firstName, string lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
        }

        public Employee()
        {
            //Do Nothing
        }

    }

}
