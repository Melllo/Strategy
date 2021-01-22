using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class Hero
    {
        public string Weapon{ get; set;}
        public Hero() {
            this.Weapon = "sword";
        }
        public void action(IAction action)
        {
            action.Action();
        }
    }
}
