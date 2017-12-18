using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pato_interface.Q2
{
    class StellDuck : Duck, IGrasnar, IFly
    {
        public void grasnar()
        {
            Console.WriteLine("Pato de metal não faz som");
        }
        public void fly()
        {
            Console.WriteLine("Pato de metal não voa.");
        }
        public override void display()
        {
            Console.WriteLine("Sou um pato de metal.");
        }

    }
}
