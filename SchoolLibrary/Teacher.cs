using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class Teacher : Person
    {

        public string Subject { get; set; } 
        public override float ComputeGradeAverage()
        {
            //this will be fixed later
            return 1.0f;
        }
    }
}
