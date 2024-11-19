using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaToNiRo
{
    public class Bus : Vehicle
    {
        public int numOfPassangers;

        Random rnd = new Random();


        public Bus()
        {
            numOfPassangers = rnd.Next(1, 36);
        }

       /* public void BusInfo()
        {
          
            Console.WriteLine("Hur länge vill du parkera? ");
            int parkeringTime = int.Parse(Console.ReadLine());
        }*/
    }
}
