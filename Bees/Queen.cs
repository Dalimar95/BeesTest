using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bees
{
    class Queen : Bee
    {
        public Queen(int number): base(number)
        {
            this.type = "Queen";
        }
        

        

        public override void CheckHealth()
        {
            if (this.health < 20)
            {
                this.isAlive = false;
            }
        }
    }
}
