using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingSim_med_klasser
{
    class Fighter
    {

        private int hp;
        public string name;

        static Random rndNumber = new Random();

        public int Attack()
        {
            return rndNumber.Next(10, 40);
        }

        public void Hurt(int damage)
        {
            hp = hp - damage;
        }

        public bool IsAlive()
        {
            if(hp > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetHp()
        {
            return hp;
        }

        public Fighter(string selectedName)
        {
            hp = rndNumber.Next(75, 150);
            name = selectedName;
        }
            
    }
}
