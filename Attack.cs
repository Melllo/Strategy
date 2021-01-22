using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class Attack : IAction
    {
        string weapon;
        public Attack(Hero hero) {
            weapon = hero.Weapon;
        }
        public void Action()
        {
            Console.WriteLine("Attack with " + weapon);
        }
    }
}
