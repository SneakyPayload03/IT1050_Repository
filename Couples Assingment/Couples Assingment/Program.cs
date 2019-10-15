using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couples_Assingment
{


    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();

            person1.GetFirstName();
            person1.GetLastName();
            person1.GetFullName();
            person1.GetAge();
            person1.GetInfoSpouse();
            person1.PrintAll();
            person2.GetFirstName();
            person2.GetLastName();
            person2.GetFullName();
            person2.GetAge();
            person2.GetInfoSpouse();
            person2.PrintAll();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
                }
    }
}
