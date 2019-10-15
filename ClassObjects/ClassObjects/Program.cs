using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 7;
            int sum = x + y;
            // sum = 12
            Student donnie = new Student();
            Student Amber;
            Amber = new Student;
            // what happens when this code is executed is both donnie and Amber are declared as an variable, assinged the reference and instanciated as an object
            // then of course all of the variables that define a Student are declared within donnie and Amber at their referenced location however hold a null value
            // donnie is saved in the program as an address or a reference ( the value donnie tells you where to get more information )
            // this was declaring a variable, or in this case declaring a Student!!!! :)
            //donnie is an empty variable
            // x, y, and sum are primitive variables
            // donnie is a complex variable

            Student smartest;
            smartest = donnie;
            // this assings donnie's reference location to smartest.
            smartest = null;
            donnie = null;

            donnie.Firstname = "Donnie";
            donnie.Lastname = "Santos";
            donnie.SNumber = "S00786518";
            donnie.GPA = 4.0;
            

            


        }
    }
}
