using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsultMachine
{
    class Person
    {
        private string Name;
        private int Age = 0;
        private bool Alumni;
        private bool Intelligence;
        
       
        public Person()
        {
            setName();
            setAge();
            setAlumni();
            setSmart();
            PersonPrint();
            
            
        }
        public void ExecutePerson()
        {
            PersonPrint();
        }

        public void PersonPrint()
        {
            Console.WriteLine("         User Information");
            Console.WriteLine("==================================");
            Console.WriteLine();
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine("Age: " + this.Age);
            Console.WriteLine("Graduated From High School: " + this.Alumni);
            Console.WriteLine("Is Smart: " + this.Intelligence);
            Console.WriteLine("==================================");
        }
        public void setName()
        {
           this.Name = Input.getName(Name);          
        }
        public string getName()
        {
            return this.Name;
        }
        public void setAge()
        {
            this.Age = Input.getAge(Age);
        }
        public int getAge()
        {
            return this.Age;
        }
        public void setAlumni()
        {
            this.Alumni = Input.getAlumStatus(Alumni);
        }
        public bool GetAlumni()
        {
            return this.Alumni;
        }
        public void setSmart()
        {
            this.Intelligence = Input.getIntelligence(Intelligence);
        }
        public bool GetSmart()
        {
            return this.Intelligence;
        }

    }
}
