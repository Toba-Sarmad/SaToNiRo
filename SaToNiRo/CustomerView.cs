﻿using System;
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

            int color;
            int duration;
            Vehicle vehicle;
            bool isElectric;
            string regnumber = "";
            string brand;


            switch (userInput)
            {

                case 1: // Bil
                    //parkinglot.CreateRandomVehicles(userInput);
                    Console.WriteLine("Ange regnummer: \n");
                    regnumber = Console.ReadLine();
                    Console.WriteLine("Ange färg: \n 1. Röd \n 2. Blå \n 3. Gul \n 4. Svart \n 5. Silver \n 6. Grå");
                    color = Convert.ToInt32(Console.ReadLine());
                    vehicle = new Car { RegNumber = Vehicle.GetUserRegNumber(regnumber), Color = Vehicle.ChooseVehicleColor(color), ParkingDuration = Vehicle.UserParkingDuration(), Wheels = 4 };
                    parkinglot.parkedVehicles.Add(vehicle);
                    parkinglot.CalculateRevenue(vehicle);
                    isElectric = false;
                    Console.WriteLine("Tack så mycket!");
                    Console.WriteLine("Detaljer om fordon Bil: ");
                    Console.WriteLine($"Registeringsnummer : {vehicle.RegNumber} ");
                    Console.WriteLine($"Färg: {vehicle.Color} ");
                    Console.WriteLine($"Tid: {vehicle.ParkingDuration} sekunder \n");

                    break;

                case 2: // ElBil
                    // parkinglot.CreateRandomVehicles(userInput);
                    vehicle = new Car();
                    vehicle.Wheels = 4;
                    parkinglot.parkedVehicles.Add(vehicle);
                    parkinglot.CalculateRevenue(vehicle);
                    isElectric = true;
                    Console.WriteLine("Tack så mycket!");
                    Console.WriteLine("Detaljer om fordon ElBil: ");
                    Console.WriteLine($"Registeringsnummer : {vehicle.RegNumber} ");
                    Console.WriteLine($"Färg: {vehicle.Color} ");
                    Console.WriteLine($"Tid: {vehicle.ParkingDuration} sekunder \n");

                    break;

                case 3: // MC
                        //parkinglot.CreateRandomVehicles(userInput);
                    vehicle = new MC();
                    vehicle.Wheels = 2;
                    parkinglot.parkedVehicles.Add(vehicle);
                    parkinglot.CalculateRevenue(vehicle);
                    Console.WriteLine("Tack så mycket!");
                    Console.WriteLine("Detaljer om fordon MC: ");
                    Console.WriteLine($"Registeringsnummer : {vehicle.RegNumber} ");
                    Console.WriteLine($"Färg: {vehicle.Color} ");
                    Console.WriteLine($"Tid: {vehicle.ParkingDuration} sekunder \n");

                    break;

                case 4: // Buss
                        //parkinglot.CreateRandomVehicles(userInput);
                    vehicle = new Bus();
                    vehicle.Wheels = 6;
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