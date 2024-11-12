using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

            string color;
            int duration;
            Vehicle vehicle;
            bool isElectric;
            string brand;


            switch (userInput)
            {

                case 1: // Bil
                    //parkinglot.CreateRandomVehicles(userInput);
                    vehicle = new Car();
                    color = "Röd";
                    duration = 10;
                    vehicle.Color = color;
                    vehicle.ParkingDuration = duration;
                    parkinglot.parkedVehicles.Add(vehicle);
                    parkinglot.CalculateRevenue(vehicle);
                    isElectric = false;
                    Console.WriteLine("Tack så mycket! Du får att parkera din BIL med följände detaljer: ");
                    Console.WriteLine($"Registeringsnummer : {vehicle.RegNumber} ");
                    Console.WriteLine($"Färg: {vehicle.Color} ");
                    Console.WriteLine($"Tid: {vehicle.ParkingDuration} minuter \n");

                    break;

                case 2: // ElBil
                    // parkinglot.CreateRandomVehicles(userInput);
                    vehicle = new Car();
                    color = "Röd";
                    duration = 10;
                    vehicle.Color = color;
                    vehicle.ParkingDuration = duration;
                    parkinglot.parkedVehicles.Add(vehicle);
                    parkinglot.CalculateRevenue(vehicle);
                    isElectric = true;
                    Console.WriteLine("Tack så mycket! Du får att parkera din EL-BIL för 10 minuter.");
                    break;

                case 3: // MC
                        //parkinglot.CreateRandomVehicles(userInput);
                    vehicle = new MC();
                    color = "Svart";
                    duration = 20;
                    vehicle.Color = color;
                    vehicle.ParkingDuration = duration;
                    parkinglot.parkedVehicles.Add(vehicle);
                    parkinglot.CalculateRevenue(vehicle);
                    Console.WriteLine("Tack så mycket! Du får att parkera din MC för 20 minuter.");
                    break;

                case 4: // Buss
                        //parkinglot.CreateRandomVehicles(userInput);
                    vehicle = new Bus();
                    color = "Blå";
                    duration = 15;
                    vehicle.Color = color;
                    vehicle.ParkingDuration = duration;
                    parkinglot.parkedVehicles.Add(vehicle);
                    parkinglot.CalculateRevenue(vehicle);
                    Console.WriteLine("Tack så mycket! Du får att parkera  din Buss för 15 minuter.");
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
