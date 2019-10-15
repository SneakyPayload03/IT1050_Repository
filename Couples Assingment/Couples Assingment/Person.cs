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
        public string SpouseFirstName;
        public string FirstName;
        public string LastName;
        public string FullName;
        public int Age;
        public string GetFirstName()
        {
            Console.WriteLine("What is your first name?");
            this.FirstName = Console.ReadLine();
            return this.FirstName;
        }
        public string GetLastName()
        {
            Console.WriteLine("What is your last name?");
            this.LastName = Console.ReadLine();
            return this.LastName;
        }
        public string GetFullName()
        {
            FullName = this.FirstName + " " + this.LastName;
            return FullName;
        }
        public void PrintAll()
        {
            Console.WriteLine("Name: " + this.FullName);
            Console.WriteLine("Age: " + this.Age);
            Console.WriteLine("Spouse: " + this.Spouse);
            Console.WriteLine("Spouse Age: " + Spouse.Age);

        }
        public int GetAge()
        {
            Console.WriteLine("How old are you?");
            this.Age = int.Parse(Console.ReadLine());
            return this.Age;
        }
        public Person GetInfoSpouse()
        {

            Spouse = new Person;
            Console.WriteLine("Who is " + this.FullName + "'s spouse?");
            Spouse.FirstName = 
            this.Spouse = SpouseFirstName;
            this.Spouse.LastName = LastName;
            Console.WriteLine("How old is she or he?");
            this.Spouse.Age = int.Parse(Console.ReadLine());
            return this.Spouse;
        }
        

         }

       

    }