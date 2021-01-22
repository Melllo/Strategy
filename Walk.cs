using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class Walk : IAction
    {
        int Speed { get; set; }

        public Walk(int speed) {
            this.Speed = speed;
        }

        public void Action()
        {
            if (Speed <= 20 && Speed > 0 )
            {
                Console.WriteLine("Hero is walhing");
            }
            else if(Speed > 20){
                Console.WriteLine("Hero is runnig");
            }
        }
    }
}
