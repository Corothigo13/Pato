using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pato_interface.Q2;

namespace pato_interface
{
    class RubberDuck : Duck, IGrasnar, IFly
    {
        public void grasnar()
        {
            Console.WriteLine("Bip Bip...");
        }
        public void fly()
        {
            Console.WriteLine("Pato de borracha não voa.");
        }
        public override void display()
        {
            Console.WriteLine("Sou um pato de borracha.");
        }

    }
}
