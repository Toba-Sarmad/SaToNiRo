using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaToNiRo
{
    public class Parkinglot
    {
        public double totalNumOfParkingSpots = 1;
        public List<Vehicle> parkedVehicles = new List<Vehicle>();
        public int totalNumOfChargingStations = 2;
        public Dictionary<int,Vehicle>parkingSpots = new Dictionary<int,Vehicle>();
        public Random rnd = new Random();

        public double TotalRevenue { get; set; } = 0;

        public void CalculateRevenue(Vehicle vehicle)
        {
            double ratePerMinute = 1.5;
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
                    Console.WriteLine($"Plats {i}:  [{vehicleInfo}-{vehicle.RegNumber}  Färg: {vehicle.Color}   Parkerings Tid: {vehicle.ParkingDuration} sekunder.");
                }
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

        public int ParkingDurationCountDown(int input)
        {
            Thread.Sleep(1000);

            return input--;
        }

    }

}

