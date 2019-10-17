using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingSim_med_klasser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a name for player 1");
            string typedName = Console.ReadLine();
            Fighter a = new Fighter(typedName);



            Console.WriteLine("Type a name for player 2");
            typedName = Console.ReadLine();
            Fighter b = new Fighter(typedName);

            Console.WriteLine(a.name + "'s hp is: " + a.GetHp());
            Console.WriteLine(b.name + "'s hp is: " + b.GetHp());


            Console.ReadLine();

            bool playing = true;
            while (playing == true)
            {
                b.Hurt(a.Attack());

                a.Hurt(b.Attack());
                Console.WriteLine(a.name + "'s hp is: " + a.GetHp());
                Console.WriteLine(b.name + "'s hp is: " + b.GetHp());

                if (a.IsAlive() == false || b.IsAlive() == false)
                {
                    playing = false;
                }
                Console.ReadLine();
            }
            if (a.IsAlive() == true)
            {
                Console.WriteLine(a.name + " vann!");
            }
            else if (b.IsAlive() == true)
            {
                Console.WriteLine(b.name + " vann!");
            }
            else
            {
                Console.WriteLine("Båda dog. Gj");
            }
            Console.ReadLine();
        }
    }
}
