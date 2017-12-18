using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pato_interface.Q2;

namespace pato_interface
{
    class Teste
    {
        public void teste()
        {
            MallardDuck patomal = new MallardDuck();
            patomal.display();
            patomal.grasnar();
            patomal.fly();
            Console.WriteLine("\n");

            RedHeadDuck patover = new RedHeadDuck();
            patover.display();
            patover.fly();
            patover.grasnar();
            Console.WriteLine("\n");


            RubberDuck patoborra = new RubberDuck();
            patoborra.display();
            patoborra.grasnar();
            patoborra.fly();
            Console.WriteLine("\n");

            StellDuck patomet = new StellDuck();
            patomet.display();
            patomet.grasnar();
            patomet.fly();
            Console.WriteLine("\n");

            WoodDuck patomad = new WoodDuck();
            patomad.display();
            patomad.grasnar();
            patomad.fly();
            Console.WriteLine("\n");

            LetraB b = new LetraB();
            b.resposta();
            Console.WriteLine("\n");

            LetraC c = new LetraC();
            c.resposta();
            Console.WriteLine("\n");


        }

    }
}
