using System;


namespace BetterBlackboard
{
    class Assingment
    {
        //Students:
        Student Jane = new Student();
        Student Joe = new Student();
        Student Melissa = new Student();
        Student Matt = new Student();

        //Instructors:
        Instructor John = new Instructor();
        Instructor Mike = new Instructor();

        //Methods: 
        public void SetAll()
        {
            // Studet information:
            Jane.SetStudentName("Jane", "Doe");
            Jane.SetInstructor(John, "John", "Doe");
            John.SetStudentGrade(Jane, 95);
            // we can establish that Jane Doe and John Doe have a unique realtionship.
            Joe.SetStudentName("Joe", "Mama");
            Joe.SetInstructor(John, "John", "Doe");
            John.SetStudentGrade(Joe, 85);
            Melissa.SetStudentName("Melissa", "Pigfat");
            Melissa.SetInstructor(Mike, "Mike", "Bike");
            Mike.SetStudentGrade(Melissa, 90);
            // Melissa PigFat was made fun of a lot in school :(
            Matt.SetStudentName("Matt", "Bratt");
            Matt.SetInstructor(Mike, "Mike", "Bike");
            Mike.SetStudentGrade(Matt, 92);
            // Professor Information: 
            John.SetInstructorCourses("English");
            Mike.SetInstructorCourses("Math");


        }
        public void GetAll()
        {
            Jane.GetStudentInfo();
            Joe.GetStudentInfo();
            John.PrintInstructorInfo(Joe, Jane);
            Melissa.GetStudentInfo();
            Matt.GetStudentInfo();
            Mike.PrintInstructorInfo(Melissa, Matt);
        }
        public void DoAll()
        {
            
            SetAll();
            GetAll();
            Console.ReadKey();
        }

        


    }
}
