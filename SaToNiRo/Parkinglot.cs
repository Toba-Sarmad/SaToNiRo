using System;
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

        public double TotalRevenue { get; set; } = 0;

        public void CalculateRevenue(Vehicle vehicle)
        {
            double ratePerMinute = 10;
            double totalFee = (double)vehicle.ParkingDuration * ratePerMinute;
            TotalRevenue += totalFee;
        }

        public double GetTotalRevenue()
        {
            return TotalRevenue;
        }

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
                    Console.WriteLine($"Plats {i}:[{vehicleInfo}-{vehicle.RegNumber} Färg: {vehicle.Color} Parkerings Tid: {vehicle.ParkingDuration} sekunder.");
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

        public void GetParkedVehicleCategory()
        {
            var orderedList = parkedVehicles.GroupBy(p => p.Wheels).Select(group => new {Category = group.Key, Amount = group.Count()});
            foreach (var vehicle in orderedList)
            {
                Console.WriteLine($"{vehicle.Category} : {vehicle.Amount}");
            }
        }

        public int ParkingDurationCountDown(int duration)
        {
            for (int i = duration; i >= 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
                
            }
            return 10;
        }

       /* public void CreateRandomVehicles(int userInput)
        {
            string color;
            int duration;
            int wheels;
            Vehicle vehicle;


            int vehicleType = userInput;

            switch(vehicleType)
            {
                case 1: // Här skapar vi bilar
                    vehicle = new Car();
                    color = "Röd";
                    wheels = 4;
                    duration = 10;
                    parkedVehicles.Add(vehicle);
                    break;

                    // Case 2 kommer bli elbil

                case 3: // Här skapar vi Bussar
                    vehicle = new Bus();
                    color = "Blå";
                    wheels = 6;
                    duration = 15;
                    parkedVehicles.Add(vehicle);
                    break;

                case 4: // Här skapar vi MC
                    vehicle = new MC();
                    color = "Svart";
                    wheels = 2;
                    duration = 20;
                    parkedVehicles.Add(vehicle);
                    break;



                default: // Vid eventuella fel
                    throw new Exception("Ogiltig fordons typ vid slumpmässigt genererat fordon "); 
            }*/
        }

    }

