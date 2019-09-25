using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voter_Elligibility_Check
{
    class Program
    {
        static void Main(string[] args)
        {

            const double multiplier = 2.54;

            string firstName;
            string middleName;
            string lastName;
            string fullName;
            int age;
            bool isCitizen;
            int heightFeet;
            double heightInches;
            double totalHeightCM;


            Console.WriteLine("Official OHIO Voter Eligibility and Citizen Verification Software");
            Console.WriteLine("===================================================================");
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine("To get started you need to provide some personal information");
            Console.WriteLine("Please Enter Your First Name Below.");
            firstName = Console.ReadLine();
            Console.WriteLine("What is your Middle Name?");
            middleName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();
            fullName = firstName + " " + middleName + " " + lastName;
            Console.WriteLine();

            Console.WriteLine(fullName + " how tall are you in feet?");
            heightFeet = int.Parse(Console.ReadLine());
            
            
            int inches = heightFeet * 12;
            double heightCM = multiplier * inches;

            Console.WriteLine(fullName + " you are " + heightCM + " CMs tall.");
            Console.ReadKey();
            Console.WriteLine("Are you a citizen?");
            isCitizen = bool.Parse(Console.ReadLine());
            
            Console.WriteLine(fullName + " how old are you?");
            age = int.Parse(Console.ReadLine());
            bool canVote = age >=18 && isCitizen;



            Console.WriteLine("VOTER ELIGIBILITY:");
            Console.WriteLine(canVote);

            Console.ReadKey();

         
                
            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
