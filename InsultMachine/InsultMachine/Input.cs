﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsultMachine
{
    class Input
    {
        public static string getName()
        {
            Console.WriteLine("What is your nickname?");
            return Console.ReadLine();

        }
        public static int getAge()
        {
            Console.WriteLine("How old and decrepit are you?");
            return int.Parse(Console.ReadLine());
        }
        public static bool getAlumStatus()
        {
            Console.WriteLine("Did they let you graduate from high school?");
            return bool.Parse(Console.ReadLine());
        }
        public static bool getIntelligence(bool Intelligence)
        {
            
            int UserInput;
            Console.WriteLine("Where do you go for your computer needs?");
            Console.WriteLine("Enter '1' for Best Buy");
            Console.WriteLine("Enter '2' for Micro Center");
            UserInput = int.Parse(Console.ReadLine());

            if (UserInput == 1)
            {
                Intelligence = false;
            }
            else if (UserInput == 2)
            {
                Intelligence = true;
            }
            else
            {
                Console.WriteLine("Hey dummy that is the wrong input! Close out and try again!");
            }
            return Intelligence;
        }
    }
}
