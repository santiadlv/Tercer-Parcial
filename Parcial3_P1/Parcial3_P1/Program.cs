using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial3_P1.Clases;

namespace Parcial3_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog Marley = new Dog("Marley");
            Marley.talk();
            Console.WriteLine("Marley: {0}", Marley.talk());
            Cat Fluffles = new Cat("Fluffles");
            Fluffles.talk();
            Console.WriteLine("Fluffles: {0}", Fluffles.talk());
            Console.ReadKey();
        }
    }
}
