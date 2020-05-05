using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bees
{
    class Worker : Bee
    {
        public Worker(int number) : base(number)
        {
            this.type = "Worker";
        }

        public override void CheckHealth()
        {

            if (this.health < 70)
            {
                this.isAlive = false;
            }

        }

    }
}
