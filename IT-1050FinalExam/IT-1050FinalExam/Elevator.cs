using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_1050FinalExam
{
    class Elevator
    {
        private double MaxWeight;
        Passanger[] Occupants;
        private double TotalWeight;
       
        public Elevator(int maxOccupants, double maxWeight)
        {
            
            Occupants = new Passanger[maxOccupants];
            this.MaxWeight = maxWeight;
        }
        public void AddOccupant(Passanger passanger, int Index)
        {
            Occupants[Index] = passanger;
            
        }
        public double GetCurrentWeight()
        {
            
            foreach (Passanger passanger in Occupants)
            {
               
                double PassangerWeight = passanger.GetWeight();
                TotalWeight = PassangerWeight + TotalWeight;
                Console.WriteLine(TotalWeight);

            }
            return TotalWeight;

        }
        public bool IsOverMaxCapacity()
        {
            
            if (TotalWeight <= MaxWeight)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}
