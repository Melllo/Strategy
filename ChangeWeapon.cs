using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class ChangeWeapon: IAction
    {
        List<string> weapons = new List<string>();

        public string Weapon { get; set; }

        Hero hero;
        public ChangeWeapon(String s, Hero hero) {
            weapons.Add("sword");
            weapons.Add("knife");
            weapons.Add("bow");
            this.hero = hero;
            if (weapons.Contains(s))
            {
                this.Weapon = s;
            }
            else {
                weapons.Add(s);
                this.Weapon = s;
            }
        }
        public void Action()
        {
            hero.Weapon = Weapon;
            Console.WriteLine("Change weapon on "+ Weapon);
        }
    }
}
