using System;


namespace BetterBlackboard
{
    class Assingment
    {
        //Students:
        Student Jane = new Student("Jane", "Doe", 95);
        Student Joe = new Student("Joe", "Mama", 85);
        Student Melissa = new Student("Melissa", "Pigfat", 90);
        Student Matt = new Student("Matt", "Bratt", 92);

        //Instructors:
        Instructor John = new Instructor("John", "Doe", "English");
        Instructor Mike = new Instructor("Mike", "Bike", "Math");
        //Methods: 
        public void SetAll()
        {
            
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
            
            
            GetAll();
            Console.ReadKey();
        }

        


    }
}
