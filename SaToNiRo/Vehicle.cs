using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SaToNiRo
{
    public abstract class Vehicle
    {
        public string RegNumber { get; set; }
        public string Color { get; set; }
        public int Wheels { get; set; }
        public int ParkingDuration { get; set; }  


        public static string GetUserRegNumber(string input)
        {
            string regnumber = input.ToUpper();
            string pattern = @"^[A-Z]{3}[0-9]{3}$";

           
                if (Regex.IsMatch(regnumber, pattern))
                {

                    return regnumber;
                }
                else
                {
                    return "Ogiltigt registreringsnummer! Försök igen.";
                }
           
        }
            

        public static string ChooseVehicleColor(int input)
        {
            switch (input)
            {
                case 1:
                    return "Röd";
                case 2:
                    return "Blå";
                case 3:
                    return "Gul";
                case 4:
                    return "Svart";
                case 5:
                    return "Silver";
                case 6:
                    return "Grå";
                default:
                    return "Ogiltlig färg! Försök igen";
            }
        }

        public static int UserParkingDuration()
        {
            Console.WriteLine("Hur länge vill du parkera? (Sekunder)");
            int duration = int.Parse(Console.ReadLine());
            return duration;
        }
    }
}
