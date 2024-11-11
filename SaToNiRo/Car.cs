using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaToNiRo
{
    public class Car : Vehicle
    {

        bool ElectricCar {  get; set; }

        Random rnd = new Random();
        

        public Car()
        {
            RegNumber = Vehicle.GenerateRandomRegNumber();
            ElectricCar = rnd.Next(0, 2) == 1;
            
        }

       /* public void CarInfo()
        {
           
            Console.WriteLine("Hur länge vill du parkera? ");
            int parkeringTime = int.Parse(Console.ReadLine());
        }*/
    }
}
