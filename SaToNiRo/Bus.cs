using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaToNiRo
{
    public class Bus : Vehicle
    {
        private int numOfPassangers;

        Random rnd = new Random();


        public Bus()
        {
            RegNumber = Vehicle.GenerateRandomRegNumber();
            numOfPassangers = rnd.Next(1, 36);
        }
    }
}
