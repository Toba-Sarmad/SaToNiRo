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
           RegNumber = GenerateRandomRegNumber();
           Color = ChooseVehicleColor();
           Wheels = Wheels;
           ParkingDuration = UserParkingDuration();
        }

        public static string GenerateRandomRegNumber()
        {
            Random rnd = new Random();
            return $"{(char)rnd.Next('A', 'Z')}{(char)rnd.Next('A', 'Z')}{(char)rnd.Next('A', 'Z')}{rnd.Next(100, 999)}";
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
