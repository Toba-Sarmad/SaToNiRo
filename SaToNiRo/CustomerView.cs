using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaToNiRo
{
    public class CustomerView
    {
        public static void ChooseVehicle(Parkinglot parkinglot)
        {
            Console.WriteLine("Välj fordon \n");
            Console.WriteLine("1: Bil ");
            Console.WriteLine("2: Elbil ");
            Console.WriteLine("3: Mc ");
            Console.WriteLine("4: Buss ");
            Console.WriteLine("5: Tillbaka till menyn ");

            int userInput = int.Parse(Console.ReadLine());
            Console.Clear();


            switch (userInput)
            {

                case 1: // Bil
                    parkinglot.CreateRandomVehicles(userInput);
                    Console.WriteLine("Parkerat ");
                    break;

                case 2: // ElBil
                    parkinglot.CreateRandomVehicles(userInput);
                    Console.WriteLine("Parkerat ");
                    break;

                case 3: // MC
                    parkinglot.CreateRandomVehicles(userInput);
                    Console.WriteLine("Parkerat ");
                    break;

                case 4: // Buss
                    parkinglot.CreateRandomVehicles(userInput);
                    Console.WriteLine("Parkerat ");
                    break;

                case 5:
                    Program.Meny(parkinglot);
                    break;

                default:
                    Console.WriteLine("Ogiltigt val, försök igen");
                    break;
            }
        }

      
    }
}
