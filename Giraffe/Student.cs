using System;
using System.Collections.Generic;
using System.Text;

namespace Giraffe
{
    class Student
    {
        public string name;
        public string major;
        public double gpa;

        public Student(string aName, string aMajor, double aGpa)
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
        }

        public bool hasHonors()
        {
            if(gpa >= 9.5)
            {
                return true;
            }
            return false;
        }
    }
}
