using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couples_Assingment
{

    class Person
    {
        public Person Spouse;
        public string FirstName;
        public string LastName;
        public string FullName;
        public int Age;
        public static double SumOfAllAges;
        public static int Count;
        public static double meanAge;
        public string GetFirstName()
        {
            Console.WriteLine("First Name: ");
            this.FirstName = Console.ReadLine();
            return this.FirstName;
        }
        public string GetLastName()
        {
            Console.WriteLine("Last Name: ");
            this.LastName = Console.ReadLine();
            return this.LastName;
        }
        public string GetFullName()
        {
            FullName = this.FirstName + " " + this.LastName;
            return FullName;
        }

        public int GetAge()
        {
            Console.WriteLine("Age: ");
            this.Age = int.Parse(Console.ReadLine());
            addage(Age);
            return this.Age;

        }
        public void GetInfoSpouse()
        {

            Spouse = new Person();
            Spouse.FirstName = Input.String("Spouse Name: ");
            Spouse.LastName = LastName;
            Spouse.Age = Input.Integer("Spouse Age: ");
            //Console.WriteLine("Spouse Age?");
            //Spouse.Age = int.Parse(Console.ReadLine());
            addage(Spouse.Age);
        }
        public void PrintAll()
        {
            Console.WriteLine("Name: " + this.FullName);
            Console.WriteLine("Age: " + this.Age);
            Console.WriteLine("");
            Console.WriteLine("Spouse: " + this.Spouse.FirstName + " " + this.LastName);
            Console.WriteLine("Spouse Age: " + this.Spouse.Age);
            Console.WriteLine("");
            Console.WriteLine("Sum of All Ages: " + SumOfAllAges);
            Console.WriteLine("Average Age: " + meanAge);
        }

        public static void addage(int age)
        {
            Count++;
            SumOfAllAges += age;
            meanAge = SumOfAllAges / Count;


        }
        




    }
}