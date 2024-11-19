using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaToNiRo
{
    public abstract class Vehicle
    {
        public string RegNumber { get; set; }
        public string Color { get; set; }
        public int Wheels { get; set; }
        public int ParkingDuration { get; set; }  
        
        public Vehicle()
        {
           Color = ChooseVehicleColor();
           Wheels = 4;
           ParkingDuration = UserParkingDuration();
        }

        public static string GetUserRegNumber(string input)
        {
            return input;
        }

        public static string ChooseVehicleColor()
        {
            Console.WriteLine("Vad har ditt fordon för färg? ");
            string color = Console.ReadLine();
            return color;
        }

        public static int UserParkingDuration()
        {
            Console.WriteLine("Hur länge vill du parkera? (Sekunder)");
            int duration = int.Parse(Console.ReadLine());
            return duration;
        }
    }
}
