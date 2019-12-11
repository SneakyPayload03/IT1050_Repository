using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_1050FinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator1;
            elevator1 = new Elevator(2,400);
            Passanger A1 = new Passanger("A1", 180);
            elevator1.AddOccupant(A1, 0);
            Passanger A2 = new Passanger("A2", 135);
            elevator1.AddOccupant(A2, 1);
            elevator1.GetCurrentWeight();
            bool elevator1IsOverMaxCapacity;
            elevator1IsOverMaxCapacity = elevator1.IsOverMaxCapacity();
            Console.WriteLine(elevator1IsOverMaxCapacity);
           

            ////////////////////////////////////////////////////////////////////

            Elevator elevator2;
            elevator2 = new Elevator(3,600);
            Passanger B1 = new Passanger("B1", 200);
            elevator2.AddOccupant(B1, 0);
            Passanger B2 = new Passanger("B2", 200);
            elevator2.AddOccupant(B2, 1);
            Passanger B3 = new Passanger("B3", 800);
            elevator2.AddOccupant(B3, 2);
            bool elevator2IsOverMaxCapacity;
            elevator2.GetCurrentWeight();
            elevator2IsOverMaxCapacity = elevator2.IsOverMaxCapacity();
            Console.WriteLine(elevator2IsOverMaxCapacity);
            Console.Read();




        }
    }
}
