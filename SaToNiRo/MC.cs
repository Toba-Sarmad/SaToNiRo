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
            Brand = "Yamaha";
        }

       /* public void McInfo()
        {
           
            Console.WriteLine("Hur länge vill du parkera? ");
            int parkeringTime = int.Parse(Console.ReadLine());
        }*/
    }
}
