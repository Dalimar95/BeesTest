using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bees
{
    abstract class Bee 
    {
        public float health { get; protected set; }
        public bool isAlive { get; protected set; }
        public string type { get; protected set; }
        public int number { get; protected set; }

        public Bee(int number)
        {
            this.health = 100;
            this.isAlive = true;
            this.number = number;
        }             

        public void Damage(int value)
        {
            if(this.isAlive)
            {
                int PercentDamageToHealthValue = (int)Math.Round(((double)(this.health/100) * value));
                this.health -= PercentDamageToHealthValue;
            }
            CheckHealth();            
        }

        public abstract void CheckHealth();                           

    }
}
