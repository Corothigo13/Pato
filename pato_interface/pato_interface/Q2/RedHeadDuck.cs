using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pato_interface.Q2;

namespace pato_interface
{
    class RedHeadDuck : Duck, IGrasnar, IFly
    {
        public override void display()
        {
            Console.WriteLine("Sou um pato vermelho.");
        }
        public void grasnar()
        {
            Console.WriteLine("quack quack");
        }
        public void fly()
        {
            Console.WriteLine("O pato de cabeça vermelha esta voando...");
        }
    }
}
