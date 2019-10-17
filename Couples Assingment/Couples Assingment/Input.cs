using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couples_Assingment
{
    class Input
    {
        public static string  String(string prompt)
        {
            System.Console.WriteLine(prompt);
            return System.Console.ReadLine();
        }
        public static int Integer(string prompt)
        {
            return int.Parse(Input.String(prompt));

        }

    }
}
