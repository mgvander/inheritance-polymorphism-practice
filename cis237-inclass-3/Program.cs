/// Author: Michael VanderMyde
/// Course: CIS 237
/// Inclass 3

using System;

namespace cis237_inclass_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make a new instance of the User Interface class
            //Just commented this to use the static one instead
            UserInterface ui = new UserInterface();

            // Here is a new employee being created using the default
            // constructor that we wrote in the Employee class
            // Even though we aren't using it, I want you to see a single instance
            // of one vs an array of them.
            Employee myEmployee = new SalaryEmployee();

            // Let's make an array to hold a bunch of instances of the Employee class
            IEmployee[] employees = new IEmployee[10];

            // Let's add some employees to our array
            employees[0] = new SalaryEmployee("David", "Barnes", 835.00m, 4000m);
            employees[1] = new HourlyEmployee("James", "Kirk", 53.00m, 10m);
            employees[2] = new SalaryEmployee("Jean-Luc", "Picard", 290.00m, 2000m);
            employees[3] = new HourlyEmployee("Benjamin", "Sisko", 87.00m, 15m);
            employees[4] = new SalaryEmployee("Kathryn", "Janeway", 194.00m, 2500m);
            employees[5] = new HourlyEmployee("Johnathan", "Archer", 35.00m, 60m);
            employees[6] = new SalaryEmployee("Gabriel", "Lorca", 870.00m, 4200m);
            employees[7] = new HourlyEmployee("Carol", "Freeman", 115.00m, 59m);

            //Get some input from the user
            int choice = ui.GetUserInput();

            //While the choice they selected is not 2, continue to do work
            while (choice != 2)
            {
                //See if the input they sent is equal to 1.
                if (choice == 1)
                {
                    //Create a string that can be concated to
                    string outputString = "";

                    //Print out the employees in the array
                    foreach (IEmployee employee in employees)
                    {
                        if (employee != null)
                        {
                            //Concat to the outputString
                            outputString += employee.ToString() +
                                " " + employee.FormattedYearlySalary() +
                                Environment.NewLine;
                        }
                    }

                    //Use the UI class to print out the string
                    ui.Output(outputString);
                }

                //re-prompt the user for input
                choice = ui.GetUserInput();
            }
        }
    }
}
