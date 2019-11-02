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
        public void SetInstructorName(string First, string Last)
        {
            this.FirstName = First;
            this.LastName = Last;
        }
        public void GetInstructorName()
        {
            Console.WriteLine("Instructor Name: " + this.FirstName + " " + this.LastName);

        }
        public void SetInstructorCourses(string course)
        {
            this.CourseName = course;
        }
        public void GetInstructorCourses()
        {
            Console.WriteLine("Instructor Course: " + this.CourseName);
        }
        public void SetStudentGrade(Student StudentName, int Grade)
        {
            Grade = StudentName.SetGrade();
        }
        public void PrintInstructorInfo(Student StudentName)
        {
            this.GetInstructorName();
            this.GetInstructorCourses();
            StudentName.GetStudentName();
            
            
        }
    }
}
