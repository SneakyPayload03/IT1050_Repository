using System;

namespace BetterBlackboard
{
    class Instructor
    {
        private string FirstName = "";
        private string LastName= "";
        private string CourseName = "";
        Student Ariel = new Student();

        public void SetStudentName(Student StudentName, string First, string Last)
        {
            StudentName.SetStudentName(First, Last);
        }
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
            Ariel = StudentName;
            StudentName.SetGrade(Grade);
        }
        public void PrintInstructorInfo(Student StudentName, Student Other)
        {
            StudentName = Ariel;
            this.GetInstructorName();
            this.GetInstructorCourses();
            StudentName.GetStudentName();
            Other.GetStudentName();
        }
    }
}
