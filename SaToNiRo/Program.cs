namespace SaToNiRo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parkinglot parkinglot = new Parkinglot();


            while (true)
            {
                Meny(parkinglot);
            }
        }

        public static void Meny(Parkinglot parkinglot)
        {
            

            Console.WriteLine("Välkomen till SaToNiRos parkeringshus\n\n ");

            Console.WriteLine("Gör följande val \n");
            Console.WriteLine("1: Parkera fordon ");
            Console.WriteLine("2: Avsluta parkering ");
            Console.WriteLine("3: Se parkerade fordon ");
            Console.WriteLine("4: Avsluta program ");

            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (userInput)
            {
                case 1:
                    ChooseVehicle(parkinglot);
                    break;

                case 2:
                    break;

                case 3:
                    parkinglot.DisplayParkingLot();
                    break;

                case 4:
                    break;

                default:
                    Console.WriteLine("Ogiltigt val, försök igen ");
                    break;
            }
        }

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
                    Meny(parkinglot);
                    break;

                default:
                    Console.WriteLine("Ogiltigt val, försök igen");
                    break;
            }
        }
    }
}
