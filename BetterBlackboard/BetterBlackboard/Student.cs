using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterBlackboard
{
    class Student
    {
        private string FirstName = "John";
        private string LastName = "Doe";
        private int Grade = 0;

        private Instructor Donnie = new Instructor;
        public int SetGrade()
        {
            return this.Grade;
        }
        public string SetStudentName(string First, string Last)
        {
            this.FirstName = First;
            this.LastName = Last;
            return this.FirstName + " " + this.LastName;
        }
        public void GetStudentName()
        {
            Console.WriteLine(this.FirstName + " " + this.LastName);
        }




    }
}
