using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SaToNiRo
{
    public class Helpers
    {
        public static string SetRegNumber()
        {
            string regNumber;
            bool isValid = false;

            while (!isValid)
            {
                Console.WriteLine("Ange regnummer : \n");
                regNumber = Console.ReadLine().ToUpper();

                if (System.Text.RegularExpressions.Regex.IsMatch(regNumber, @"^[A-Z]{3}[0-9]{2}[A-Z0-9]$"))
                {
                    isValid = true;
                    return regNumber;
                }
                else
                {
                    Console.WriteLine("Ogiltigt registreringsnummer! Försök igen.");
                }
            }

            return null;
        }


        public static int GetColor()
        {
            int color;
            Console.WriteLine("Ange färg: \n 1. Röd \n 2. Blå \n 3. Gul \n 4. Svart \n 5. Silver \n 6. Grå");
            return color = Convert.ToInt32(Console.ReadLine()); ;
        }
    }
}
