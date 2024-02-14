/// Author: Michael VanderMyde
/// Course: CIS 237
/// Inclass 3

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterLibrary
{
    public interface IPerson
    {
        // This could also contain public methods if we needed any

        // A couple of properties that make up a Person
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }

    }
}
