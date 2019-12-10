using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetClassAssingment
{
    class PetOwner
    {
        private string Name = "Natsu";
        private int Age = 400;
        Pet[] pets = new Pet [3];
        
        public PetOwner(string name, int age, Pet pet)
        {
            name = getName();
            age = getAge();
            this.pets[0] = pet;
            
        }
        public string getName()
        {
            return this.Name
        }
        public int getAge()
        {
            return this.Age;
        }
        public void printAll()
        {

        }
    }
}
