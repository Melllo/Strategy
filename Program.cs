using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero();
            hero.action(new Attack(hero));
            hero.action(new ChangeWeapon("bow",hero));
            hero.action(new Attack(hero));
            hero.action(new Walk(33));
        }
    }
}
