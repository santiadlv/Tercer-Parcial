using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial3_P1.Clases
{
    class Dog : AnimalData, Interface
    {
        public Dog(string name) : base(name)
        {

        }

        public string talk()
        {
            return "guau";
        }
    }
}
