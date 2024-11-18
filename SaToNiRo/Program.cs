using System.ComponentModel.Design;
using System.Text.RegularExpressions;

namespace SaToNiRo
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            ParkingLot parkingLot = new ParkingLot();

            Task.Run(() => parkingLot.UpdateParkingDurationsPeriodically());

            while (true)
            {
                await Meny(parkingLot);
            }
        }

        public static async Task Meny(ParkingLot parkingLot)
        {
            Console.Clear();
            Console.WriteLine("Välkommen till SaToNiRos parkeringshus\n");
            Console.WriteLine("Gör följande val:");
            Console.WriteLine("1: Parkera fordon ");
            Console.WriteLine("2: Avsluta parkering ");
            Console.WriteLine("3: Se parkerade fordon ");
            Console.WriteLine("4: Visa intäkter ");
            Console.WriteLine("5: Avsluta program ");

            int userInput = Convert.ToInt32(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    await ChooseVehicle(parkingLot);
                    break;
                case 2:
                    Console.WriteLine("Ange registreringsnummer för att avsluta parkering:");
                    string regNumber = Console.ReadLine();
                    parkingLot.CheckOutVehicle(regNumber);
                    break;
                case 3:
                    await ViewParkedVehicles(parkingLot);
                    break;
                case 4:
                    parkingLot.DisplayEarnings();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Ogiltigt val, försök igen.");
                    break;
            }
        }

        public static async Task ViewParkedVehicles(ParkingLot parkingLot)
        {
            bool continueViewing = true;

            while (continueViewing)
            {
                parkingLot.DisplayParkingLot();

                parkingLot.CheckForFines();

                Console.WriteLine("\nVill du gå tillbaka till huvudmenyn? (1 = Ja, 2 = Uppdatera p-tid)");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    continueViewing = false;
                }
                else if (choice == 2)
                {
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Ogiltigt val, vänligen välj 1 för att gå tillbaka eller 2 för att fortsätta.");
                }

                await Task.Delay(1000);
            }
        }

        public static async Task ChooseVehicle(ParkingLot parkingLot)
        {
            Console.Clear();
            Console.WriteLine("Välj fordon:");
            Console.WriteLine("1: Bil ");
            Console.WriteLine("2: Elbil ");
            Console.WriteLine("3: MC ");
            Console.WriteLine("4: Buss ");
            Console.WriteLine("5: Tillbaka till menyn ");

            int userInput = int.Parse(Console.ReadLine());
            Console.Clear();

            if (userInput >= 1 && userInput <= 4)
            {
                Console.WriteLine("Hur länge vill du parkera? (ange tid i sekunder)");
                int duration = int.Parse(Console.ReadLine());

                Console.WriteLine("Välj färg:");
                string color = ChooseColor();

                bool isLuxury = false;
                bool isChargingStation = false;

                if (userInput == 2)
                {
                    Console.WriteLine("Vill du parkera på en laddstation? (1 = Ja, 2 = Nej)");
                    isChargingStation = int.Parse(Console.ReadLine()) == 1;
                }

                if (!isChargingStation)
                {
                    Console.WriteLine("Vill du ha en lyxplats? (1 = Ja, 2 = Nej)");
                    isLuxury = int.Parse(Console.ReadLine()) == 1;
                }

                switch (userInput)
                {
                    case 3:
                        Console.WriteLine("Ange märke på motorcykeln:");
                        string brand = Console.ReadLine();
                        parkingLot.CreateVehicle(userInput, duration, color, isLuxury, isChargingStation, brand, null);
                        break;

                    case 4:
                        Console.WriteLine("Ange antal passagerare:");
                        int passangers = int.Parse(Console.ReadLine());
                        parkingLot.CreateVehicle(userInput, duration, color, isLuxury, isChargingStation, null, passangers);
                        break;

                    default:
                        parkingLot.CreateVehicle(userInput, duration, color, isLuxury, isChargingStation);
                        break;
                }
            }
            else if (userInput != 5)
            {
                Console.WriteLine("Ogiltigt val, försök igen.");
            }

            await Task.Delay(1000);
        }

        public static string ChooseColor()
        {
            Console.WriteLine("1: Röd");
            Console.WriteLine("2: Blå");
            Console.WriteLine("3: Grön");
            Console.WriteLine("4: Gul");
            Console.WriteLine("5: Svart");

            int colorChoice;
            while (!int.TryParse(Console.ReadLine(), out colorChoice) || colorChoice < 1 || colorChoice > 5)
            {
                Console.WriteLine("Ogiltigt val, försök igen.");
            }

            switch (colorChoice)
            {
                case 1: return "Röd";
                case 2: return "Blå";
                case 3: return "Grön";
                case 4: return "Gul";
                case 5: return "Svart";
                default:
                    return "Borde aldrig gå igenom!";
            }
        }
    }

    public class ParkingLot
    {
        public int totalNumOfParkingSpots = 10;
        public Dictionary<int, Vehicle> parkingSpots = new Dictionary<int, Vehicle>();
        public HashSet<int> luxurySpots = new HashSet<int> { 1, 2 };
        public HashSet<int> chargingStations = new HashSet<int> { 3, 4 };
        public Random rnd = new Random();

        private int totalParkingEarnings = 0;
        private int totalFineEarnings = 0;

        private bool hasDisplayedFines = false;

        public async Task UpdateParkingDurationsPeriodically()
        {
            while (true)
            {
                await Task.Delay(1000);

                UpdateParkingDurations();
            }
        }

        public void CheckForFines()
        {
            if (!hasDisplayedFines)
            {
                foreach (var vehicle in parkingSpots.Values)
                {
                    if (vehicle.Duration <= 0)
                    {
                        int fine = 500;
                        totalFineEarnings += fine;

                        //Console.WriteLine($"Böter på {vehicle.RegNumber}: {fine} kr");
                        Console.WriteLine($"Parkeringstid för {vehicle.RegNumber} har gått ut. Böter kan appliceras.");
                    }
                }

                hasDisplayedFines = true;
            }
        }

        public void UpdateParkingDurations()
        {
            foreach (var vehicle in parkingSpots.Values)
            {
                if (vehicle.Duration > 0) vehicle.Duration--;
             
                if (vehicle.Duration < 0) vehicle.Duration = 0;
            }
        }


        public void DisplayParkingLot()
        {
            Console.WriteLine("Parkerade fordon:\n");

            for (int i = 1; i <= totalNumOfParkingSpots; i++)
            {
                if (parkingSpots.ContainsKey(i))
                {
                    var vehicle = parkingSpots[i];
                    string vehicleType = vehicle is Car ? "Bil" :
                                         vehicle is Bus ? "Buss" :
                                         vehicle is MC ? "MC" : "Fordon";

                    string status = vehicle.Duration > 0 ? $"{vehicle.Duration} sek kvar" : "P-tid har utgått";

                    string specialSpot = luxurySpots.Contains(i) ? " (Lyxplats)" :
                                         chargingStations.Contains(i) ? " (Laddstation)" : "";

                    Console.WriteLine($"Plats {i}: [{vehicleType} - {vehicle.RegNumber}, Färg: {vehicle.Color}, Status: {status}{specialSpot}]");
                }
                else
                {
                    Console.WriteLine($"Plats {i}: [Tom]");
                }
            }

            Console.WriteLine();
        }

        public void DisplayEarnings()
        {
            Console.WriteLine("Intäkter:\n");
            Console.WriteLine($"Totala intäkter från parkering: {totalParkingEarnings} kr");
            Console.WriteLine($"Totala intäkter från böter: {totalFineEarnings} kr");
            Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
            Console.ReadKey();
        }

        public void CreateVehicle(int userInput, int duration, string color, bool isLuxury, bool isChargingStation, string? brand = null, int? passangers = null)
        {
            Vehicle vehicle;
            int parkingSpot;

            switch (userInput)
            {
                case 1:
                    vehicle = new Car { Color = color, Duration = duration, RegNumber = GetValidRegNumber() };
                    break;
                case 2:
                    vehicle = new Car { Color = color, Duration = duration, RegNumber = GetValidRegNumber(), IsElectric = true };
                    break;
                case 3:
                    vehicle = new MC { Color = color, Duration = duration, RegNumber = GetValidRegNumber(), Brand = brand ?? "Okänt märke" };
                    break;
                case 4:
                    vehicle = new Bus { Color = color, Duration = duration, RegNumber = GetValidRegNumber(), Passangers = passangers ?? 0 };
                    break;
                default:
                    throw new InvalidOperationException("Ogiltig typ av fordon");
            }

            if (isChargingStation)
            {
                parkingSpot = GetFreeSpot(isLuxury, true);
            }
            else
            {
                parkingSpot = GetFreeSpot(isLuxury, isChargingStation);
            }

            if (parkingSpot != -1)
            {
                parkingSpots[parkingSpot] = vehicle;
                Console.WriteLine($"{vehicle.GetType().Name} parkerades på plats {parkingSpot} med registreringsnummer {vehicle.RegNumber}. Tid: {duration} sekunder.");
            }
            else
            {
                Console.WriteLine("Ingen ledig parkeringsplats tillgänglig.");
            }
        }

        public string GetValidRegNumber()
        {
            string regNumber;
            string regNumberPattern = @"^[A-Z]{3}[0-9]{3}$";

            while (true)
            {
                Console.WriteLine("Ange registreringsnummer:");
                regNumber = Console.ReadLine().ToUpper();

                if (Regex.IsMatch(regNumber, regNumberPattern))
                {
                    return regNumber;
                }
                else
                {
                    Console.WriteLine("Ogiltigt registreringsnummer! Försök igen.");
                }
            }
        }

        public int GetFreeSpot(bool isLuxury, bool isChargingStation)
        {
            List<int> availableSpots = new List<int>();

            if (isLuxury)
            {
                availableSpots = luxurySpots.ToList();
            }
            else if (isChargingStation)
            {
                availableSpots = chargingStations.ToList();
            }
            else
            {
                availableSpots = Enumerable.Range(1, totalNumOfParkingSpots).Except(parkingSpots.Keys).ToList();
            }

            foreach (int spot in availableSpots)
            {
                if (!parkingSpots.ContainsKey(spot))
                {
                    return spot;
                }
            }

            return -1;
        }

        public void CheckOutVehicle(string regNumber)
        {
            var spotToRemove = parkingSpots.FirstOrDefault(spot => spot.Value.RegNumber == regNumber);
            if (!spotToRemove.Equals(default(KeyValuePair<int, Vehicle>)))
            {
                parkingSpots.Remove(spotToRemove.Key);
                Console.WriteLine($"Fordonet med regnummer {regNumber} har checkat ut.");
            }
            else
            {
                Console.WriteLine($"Fordon med regnummer {regNumber} hittades inte.");
            }
        }
    }

    public class Vehicle
    {
        public required string RegNumber { get; set; }
        public required string Color { get; set; }
        public int Duration { get; set; }
    }

    public class Car : Vehicle
    {
        public bool IsElectric { get; set; }
    }

    public class Bus : Vehicle
    {
        public required int Passangers { get; set; }
    }

    public class MC : Vehicle
    {
        public required string Brand { get; set; }
    }
}
