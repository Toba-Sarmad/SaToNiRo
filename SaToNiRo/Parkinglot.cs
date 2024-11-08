﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaToNiRo
{
    public class Parkinglot
    {
        public double totalNumOfParkingSpots = 10;
        public List<Vehicle> parkedVehicles = new List<Vehicle>();
        public int totalNumOfChargingStations = 2;
        public Dictionary<int,Vehicle>parkingSpots = new Dictionary<int,Vehicle>();
        public Random rnd = new Random();

        public void DisplayParkingLot()
        {
            Console.WriteLine("Parkerade fordon \n");

            for (int i = 1; i <= totalNumOfParkingSpots; i++)
            {
                foreach (Vehicle parkedVehicle in parkedVehicles)
                {
                    var vehicle = parkedVehicle;
                    string vehicleInfo = vehicle is Car ? "Bil " :
                                        vehicle is Bus ? "Buss " :
                                        vehicle is MC ? "Mc " : "Fordon";
                    Console.WriteLine($"Plats {i}:[{vehicleInfo}-{vehicle.RegNumber}]");
                }

              /*  if (parkingSpots.ContainsKey(i))
                {
                    var vehicle = parkingSpots[i];
                    string vehicleInfo = vehicle is Car ? "Bil " :
                                         vehicle is Bus ? "Buss " :
                                         vehicle is MC ? "Mc " : "Fordon";
                    Console.Write($"[{vehicleInfo}-{vehicle.RegNumber}]");
                } */
            }
        }

        public void CreateRandomVehicles(int userInput)
        {
            string color = "Röd ";
            int duration = 10;
            int wheels;
            Vehicle vehicle;


            int vehicleType = userInput;

            switch(vehicleType)
            {
                case 1: // Här skapar vi bilar
                    vehicle = new Car();
                    wheels = 4;
                    parkedVehicles.Add(vehicle);
                    break;

                    // Case 2 kommer bli elbil

                case 3: // Här skapar vi Bussar
                    vehicle = new Bus();
                    wheels = 6;
                    parkedVehicles.Add(vehicle);
                    break;

                case 4: // Här skapar vi MC
                    vehicle = new MC();
                    wheels = 2;
                    parkedVehicles.Add(vehicle);
                    break;



                default: // Vid eventuella fel
                    throw new Exception("Ogiltig fordons typ vid slumpmässigt genererat fordon "); 
            }
        }

    }
}
