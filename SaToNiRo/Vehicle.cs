using System;
using System.Collections.Generic;
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

        public int ParkeingDuration { get; set; }   
        
        public Vehicle()
        {
           RegNumber = GenerateRandomRegNumber();
           //Color = color;
           //Wheels = wheels;
        }

        public static string GenerateRandomRegNumber()
        {
            Random rnd = new Random();
            return $"{(char)rnd.Next('A', 'Z')}{(char)rnd.Next('A', 'Z')}{(char)rnd.Next('A', 'Z')}{rnd.Next(100, 999)}";
        }
    }
}
