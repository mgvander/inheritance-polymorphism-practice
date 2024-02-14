using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Must add a reference to our FilterLibrary before we can use it in here.
// Once that is done, we can add this using statement so we don't have
// to fully qualify it when we go to use it.
using FilterLibrary;

namespace cis237_inclass_3
{
    internal interface IEmployee : IPerson
    {
        // This is a very high level look at what a class that implements
        // this interface MUST do.
        // It only shows public properties and methods.
        // There is no implementation here. Just declaration. Similar to an abstract method.
        // Classes can implement multiple interfaces even though they cannot inherit from
        // multiple classes.
        // Often times refered to as a contract because if the class implements an interface
        // they are required to provide implementations for everything declared in the
        // interface.

        // Notice that I do not have an access modifier. That is because it is all public.

        //*****************************
        //Properties
        //*****************************
        new string FirstName { get; set; }
        new string LastName { get; set; }
        decimal WeeklySalary { get; }
        decimal YearlySalary { get; }

        //*****************************
        //Methods
        //*****************************
        string FirstAndLastName();
        string FormattedWeeklySalary();
        string FormattedYearlySalary();

    }
}
