using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsultMachine
{
    class Person
    {
        private string Name = "User";
        private int Age = 0;
        private bool Alumni;
        private bool IntelligenceFactor;
        public Person()
        {
            this.Name = Input.getName();
            this.Age = Input.getAge();
            this.Alumni = Input.getAlumStatus();
            this.IntelligenceFactor = Input.getIntelligence(IntelligenceFactor);
            
        }
    }
}
