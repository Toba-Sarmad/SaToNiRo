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

            Vehicle vehicle;

            switch (userInput)
            {

                case 1: // Bil
                    vehicle = new Car 
                    {
                        RegNumber = Vehicle.GetUserRegNumber(Helpers.SetRegNumber()),
                        Color = Vehicle.ChooseVehicleColor(Helpers.GetColor()),
                        ParkingDuration = Vehicle.UserParkingDuration(),
                        Wheels = 4,
                        ElectricCar = false
                    };
                    parkinglot.parkedVehicles.Add(vehicle);
                    parkinglot.CalculateRevenue(vehicle);
                    Console.WriteLine("Tack så mycket!");
                    Console.WriteLine("Detaljer om fordon Bil: ");
                    Console.WriteLine($"Registeringsnummer : {vehicle.RegNumber} ");
                    Console.WriteLine($"Färg: {vehicle.Color} ");
                    Console.WriteLine($"Tid: {vehicle.ParkingDuration} sekunder \n");

                    break;

                case 2: // ElBil
                    vehicle = new Car
                    {
                        RegNumber = Vehicle.GetUserRegNumber(Helpers.SetRegNumber()),
                        Color = Vehicle.ChooseVehicleColor(Helpers.GetColor()),
                        ParkingDuration = Vehicle.UserParkingDuration(),
                        Wheels = 4,
                        ElectricCar = true
                    };
                    parkinglot.parkedVehicles.Add(vehicle);
                    parkinglot.CalculateRevenue(vehicle);
                    Console.WriteLine("Tack så mycket!");
                    Console.WriteLine("Detaljer om fordon ElBil: ");
                    Console.WriteLine($"Registeringsnummer : {vehicle.RegNumber} ");
                    Console.WriteLine($"Färg: {vehicle.Color} ");
                    Console.WriteLine($"Tid: {vehicle.ParkingDuration} sekunder \n");

                    break;

                case 3: // MC
                    Console.WriteLine("Vilket märke har motorcykeln?\n");
                    string brand = Console.ReadLine();
                    vehicle = new MC
                    {
                        RegNumber = Vehicle.GetUserRegNumber(Helpers.SetRegNumber()),
                        Color = Vehicle.ChooseVehicleColor(Helpers.GetColor()),
                        ParkingDuration = Vehicle.UserParkingDuration(),
                        Wheels = 2,
                        Brand = brand
                    };
                    parkinglot.parkedVehicles.Add(vehicle);
                    parkinglot.CalculateRevenue(vehicle);
                    Console.WriteLine("Tack så mycket!");
                    Console.WriteLine("Detaljer om fordon MC: ");
                    Console.WriteLine($"Registeringsnummer : {vehicle.RegNumber} ");
                    Console.WriteLine($"Färg: {vehicle.Color} ");
                    Console.WriteLine($"Tid: {vehicle.ParkingDuration} sekunder \n");

                    break;

                case 4: // Buss
                    Console.WriteLine("Hur många passagerare har bussen?\n");
                    int passangers = int.Parse(Console.ReadLine());
                    vehicle = new Bus
                    {
                        RegNumber = Vehicle.GetUserRegNumber(Helpers.SetRegNumber()),
                        Color = Vehicle.ChooseVehicleColor(Helpers.GetColor()),
                        ParkingDuration = Vehicle.UserParkingDuration(),
                        Wheels = 6,
                        numOfPassangers = passangers
                    };
                    parkinglot.parkedVehicles.Add(vehicle);
                    parkinglot.CalculateRevenue(vehicle);
                    Console.WriteLine("Tack så mycket!");
                    Console.WriteLine("Detaljer om fordon Buss: ");
                    Console.WriteLine($"Registeringsnummer : {vehicle.RegNumber} ");
                    Console.WriteLine($"Färg: {vehicle.Color} ");
                    Console.WriteLine($"Tid: {vehicle.ParkingDuration} sekunder \n");

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