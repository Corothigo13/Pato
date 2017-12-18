using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pato_interface
{
    class Duck
    {
        public virtual void swim()
        {
            Console.WriteLine("O pato esta nadando.");
        }
        public virtual void display()
        {
            Console.WriteLine("Eu spu um pato.");
        }
    }

}

