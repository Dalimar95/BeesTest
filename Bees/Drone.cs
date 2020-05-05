using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bees
{
    class Drone : Bee
    {
        public Drone(int number) : base(number)
        {
            this.type = "Drone";
        }

        public override void CheckHealth()
        {

            if (this.health < 50)
            {
                this.isAlive = false;
            }

        }
    }
}
