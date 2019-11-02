using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterBlackboard
{
    class Instructor
    {
        private string FirstName = "Donnie";
        private string LastName= "Santos";
        private string CourseName = "IT-1050";
        Student Ariel = new Student();
        public string SetInstructorName(string First, string Last)
        {
            this.FirstName = First;
            this.LastName = Last;
            return this.FirstName + " " + this.LastName;
        }
        public string SetInstructorCourses(string course)
        {
            this.CourseName = course;
            return CourseName;
        }
        public void SetStudentGrade(Student StudentName, int Grade)
        {
            Grade = StudentName.SetGrade();
        }
        public void GetInstructorInfo(Student StudentName)
        {
            Console.WriteLine(this.SetInstructorName(this.FirstName, this.LastName));
            Console.WriteLine(SetInstructorCourses(this.CourseName));
            StudentName.GetStudentName();
            
            
        }
    }
}
