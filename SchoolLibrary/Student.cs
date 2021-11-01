using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class Student : Person
    {

        public enum GradeLevels { FirstYear, SecondYear, ThirdYear, ForthYear}
        public GradeLevels GradeLevel { get; set; }
        public override float ComputeGradeAverage()
        {
            //this will be fixed later
            return 0.0f;
        }

        public override string SendMessage(string message)
        {
            var orgMessage = base.SendMessage(message);
            var sb = new StringBuilder(orgMessage);
            sb.AppendLine("This message is vital");
            return sb.ToString();
        }
    }
}
