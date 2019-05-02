using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial3_P1.Clases;

namespace Parcial3_P1.Clases
{
    class Cat : AnimalData, Interface
    {
        public Cat(string name) : base(name)
        {

        }

        public string talk()
        {
            Sound.sonido();
            return "miau";
        }
    }
}
