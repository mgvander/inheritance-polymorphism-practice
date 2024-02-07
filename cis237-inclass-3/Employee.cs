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
    internal class Employee
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
