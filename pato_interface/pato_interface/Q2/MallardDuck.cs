using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pato_interface.Q2;

namespace pato_interface
{
    class MallardDuck : Duck, IFly, IGrasnar
    {
        public override void display()
        {
            Console.WriteLine("Sou um pato mal.");

        }
        public void grasnar()
        {
            Console.WriteLine("Quack Quack");
        }
        public void fly()
        {
            Console.WriteLine("O pato mal esta voando...");
        }
    }
}
