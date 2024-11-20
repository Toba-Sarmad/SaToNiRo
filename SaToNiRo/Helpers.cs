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
            Console.WriteLine("Ange regnummer: \n");
            return regNumber = Console.ReadLine();
        }

        public static int GetColor()
        {
            int color;
            Console.WriteLine("Ange färg: \n 1. Röd \n 2. Blå \n 3. Gul \n 4. Svart \n 5. Silver \n 6. Grå");
            return color = Convert.ToInt32(Console.ReadLine()); ;
        }
    }
}
