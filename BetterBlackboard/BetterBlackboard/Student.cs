using System;
namespace BetterBlackboard
{
    class Student
    {
        private string FirstName = "";
        private string LastName = "";
        private int Grade = 0;

        Instructor Donnie = new Instructor();
        public void SetInstructor(Instructor InstructorName, string first, string last)
        {
            InstructorName = Donnie;
            InstructorName.SetInstructorName(first, last);

        }
        public int SetGrade(int Grade)
        {
            this.Grade = Grade;
            return this.Grade;
        }
        public void GetGrade()
        {
            Console.WriteLine("Grade: " + this.Grade);
        }
        public void SetStudentName(string First, string Last)
        {
            this.FirstName = First;
            this.LastName = Last;
        }
        public void GetStudentName()
        {
            Console.WriteLine(this.FirstName + " " + this.LastName);
        }
        public void GetStudentInfo()
        {
            this.GetStudentName();
            this.GetGrade();
            Donnie.GetInstructorName();
            

        }



    }
}
