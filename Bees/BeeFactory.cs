using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bees
{
     class BeeFactory
    {

        public Queen CreateQueen(int number)
        {           
            return new Queen(number);
        }
        public Worker CreateWorker(int number)
        {
            return new Worker(number);
        }
        public Drone CreateDrone(int number)
        {
            return new Drone(number);
        }


    }
}
