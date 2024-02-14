﻿/// Author: Michael VanderMyde
/// Course: CIS 237
/// Inclass 3

using System;

namespace cis237_inclass_3
{
    class UserInterface
    {
        //No Variables
        //No Properties
        //No Constructors (but we could if we needed to)

        //******************************
        //Methods
        //******************************
        public int GetUserInput()
        {
            //Print out a menu
            this.PrintMenu();

            //Get the input from the user
            String input = Console.ReadLine();

            //While the input is not valid re-get the input
            while (input != "1" && input != "2" && input != "3")
            {
                //Print Error message
                this.PrintErrorMessage();

                //Re-print the menu
                this.PrintMenu();

                //Get the input from the console again.
                input = Console.ReadLine();
            }

            //At this point, I know the input is a valid number of either
            //a 1 or a 2.

            return Int32.Parse(input);
        }

        public void Output(string outputString)
        {
            Console.WriteLine(outputString);
        }

        private void PrintMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Print List");
            Console.WriteLine("2. Print Filtered List");
            Console.WriteLine("3. Exit");
        }

        private void PrintErrorMessage()
        {
            Console.WriteLine("That is not a valid entry");
            Console.WriteLine("Please make a valid choice");
            Console.WriteLine();
        }
    }
}
