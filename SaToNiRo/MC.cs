using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaToNiRo
{
    public class MC : Vehicle
    {
        public string Brand;

        Random rnd = new Random();


        public MC()
        {
            RegNumber = Vehicle.GenerateRandomRegNumber();
            Brand = "Yamaha ";
        }
    }
}
