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


        public MC(string brand)
        {
            RegNumber = Vehicle.GenerateRandomRegNumber();
            Brand = brand;
        }

        public void McInfo()
        {
            Console.WriteLine("MC Märke: ");
            string brand = Console.ReadLine();

            Console.WriteLine("Hur länge vill du parkera? ");
            int parkeringTime = int.Parse(Console.ReadLine());
        }
    }
}
