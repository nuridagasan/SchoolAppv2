using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    //abstract class 
    // it does not instantiate directly from person class
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
