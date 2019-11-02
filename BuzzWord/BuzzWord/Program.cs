using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuzzWord
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            while (x >= 100)
                x++; 
                if (x % 2 == 0)
                {
                    Console.WriteLine("Buzz");

                }
                else if (x % 2 != 0)
                {
                    Console.WriteLine("Word");
                }   
            Console.ReadKey();


        }
    }
}
