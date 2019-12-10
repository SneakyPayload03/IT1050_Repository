using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsultMachine
{
    class Insult
    {
        
        private int age;
        private bool HSGrad;
        private bool smart;
        Person person;
        public Insult()
        {
            
            GetpersonInfo();
            BigInsult(age, HSGrad, smart);
            Console.Read();
        }

        public void GetpersonInfo()
        {
            person = new Person();
            this.smart = person.GetSmart();
            this.age = person.getAge();
            this.HSGrad = person.GetAlumni();
        }
        public void AgeistInsult()
        {
            
            if (this.age > 25)
            {
                Console.WriteLine("           Execute Ageist Insult!");
                Console.WriteLine("***********************************************");
                Console.WriteLine("    You are too old to be a programmer!!");
                Console.WriteLine("    Stop perving on young kids you weirdo!");
                Console.WriteLine("***********************************************");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("           Execute Ageist Insult!");
                Console.WriteLine("***********************************************");
                Console.WriteLine("You're Barely Old Enough to Buy Alchohol!");
                Console.WriteLine("YOU KNOW NOTHING ABOUT THIS WORLD!");
                Console.WriteLine("***********************************************");
                Console.WriteLine();

            }
        }
        public void DumbInsult()
        {
          if (this.smart == false)
            {
                // -.-
                Console.WriteLine("       Execute Insult on Intelligence!");
                Console.WriteLine("***********************************************");
                Console.WriteLine(" You're just another sheep that can't think on its own.");
                Console.WriteLine("You Suck!");
                Console.WriteLine("Just promise me that the next computer you buy or build wont be from Best Buy...");
                Console.WriteLine("***********************************************");
                Console.WriteLine();

            }
            else
            {
                //LOL
                Console.WriteLine("       Execute Insult on Intelligence!");
                Console.WriteLine("***********************************************");
                Console.WriteLine("Wait, you shop at Micro Center?");
                Console.WriteLine("Great life decision!");
                Console.WriteLine("Make sure you buy warrenties and service plans from the CSRs, they make commision too!");
                Console.WriteLine("Buy them mostly from Ariel if you can....");
                Console.WriteLine("***********************************************");
                Console.WriteLine();

            }
        }
        public void AlumniInsult()
        {
           
            if (this.HSGrad == true)
            {
                Console.WriteLine("Congradulations you did something that literally everyone can do!");
            }
            else
            {
                Console.WriteLine("Just gotta get good son.");
            }
        }
        public void BigInsult(int age, bool smart, bool grad)
        {
            
            AgeistInsult();
            DumbInsult();
            AlumniInsult();
        }
    }
}
