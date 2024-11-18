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

            string color;
            int duration;
            Vehicle vehicle;
            bool isElectric;
            string brand;
            int parkingSpot = 1;

            switch (userInput)
            {

                case 1: // Bil
                    //parkinglot.CreateRandomVehicles(userInput);
                    // duration = Int32.Parse(Console.ReadLine())
                    vehicle = new Car { Color = "Röd", ParkingDuration = 10, Wheels = 4, RegNumber = Vehicle.GenerateRandomRegNumber()};
                    if (parkingSpot != -1)
                    {
                        parkinglot.parkingSpots[parkingSpot] = vehicle;
                    }
                    Console.WriteLine("Hur långt tid vill du parkera din fordon?(i sekunder)");
                    parkinglot.CalculateRevenue(vehicle);
                    isElectric = false;
                    Console.WriteLine("Tack så mycket!");
                    Console.WriteLine("Detaljer om fordon Bil: ");
                    Console.WriteLine($"Registeringsnummer : {vehicle.RegNumber} ");
                    Console.WriteLine($"Färg: {vehicle.Color} ");
                    Console.WriteLine($"Tid: {vehicle.ParkingDuration} sekunder \n");
                    parkinglot.parkedVehicles.Add(vehicle);

                    break;

                case 2: // ElBil
                    // parkinglot.CreateRandomVehicles(userInput);
                    vehicle = new Car();
                    color = "Röd";
                    Console.WriteLine("Hur långt tid vill du parkera din fordon?(i sekunder)");
                    duration = Int32.Parse(Console.ReadLine());
                    vehicle.Color = color;
                    vehicle.Wheels = 4;
                    vehicle.ParkingDuration = duration;
                    parkinglot.parkedVehicles.Add(vehicle);
                    parkinglot.CalculateRevenue(vehicle);
                    isElectric = true;
                    Console.WriteLine("Tack så mycket!");
                    Console.WriteLine("Detaljer om fordon ELBil: ");
                    Console.WriteLine($"Registeringsnummer : {vehicle.RegNumber} ");
                    Console.WriteLine($"Färg: {vehicle.Color} ");
                    Console.WriteLine($"Tid: {vehicle.ParkingDuration} sekunder \n");

                    break;

                case 3: // MC
                        //parkinglot.CreateRandomVehicles(userInput);
                    vehicle = new MC();
                    color = "Svart";
                    Console.WriteLine("Hur långt tid vill du parkera din fordon?(i sekunder)");
                    duration = Int32.Parse(Console.ReadLine());
                    vehicle.Color = color;
                    vehicle.Wheels = 2;
                    vehicle.ParkingDuration = duration;
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
                    color = "Blå";
                    Console.WriteLine("Hur långt tid vill du parkera din fordon?(i sekunder)");
                    duration = Int32.Parse(Console.ReadLine());
                    vehicle.Color = color;
                    vehicle.Wheels = 6;
                    vehicle.ParkingDuration = duration;
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