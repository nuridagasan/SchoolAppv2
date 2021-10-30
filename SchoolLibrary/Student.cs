using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    class Student : Person
    {

        public enum GradeLevels { FirstYear, SecondYear, ThirdYear, ForthYear}
        public GradeLevels GradeLevel { get; set; }

    }
}
