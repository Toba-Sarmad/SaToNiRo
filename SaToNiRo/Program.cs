namespace SaToNiRo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parkinglot parkinglot = new Parkinglot();
            
            
            while (true)
            {
                Meny();
            }
        }

        public static void Meny()
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
                    ChooseVehicle();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Ogiltigt val, försök igen ");
                    break;
            }
        }

        public static void ChooseVehicle()
        {
            Console.WriteLine("Välj fordon \n");
            Console.WriteLine("1: Bil ");
            Console.WriteLine("2: Elbil ");
            Console.WriteLine("3: Mc ");
            Console.WriteLine("4: Buss ");
            Console.WriteLine("5: Tillbaka till menyn ");

            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.Clear();


            switch (userInput)
            {
                case 1:
                    Console.WriteLine("Parkerat ");
                    break;
                case 2:
                    Console.WriteLine("Parkerat ");
                    break;
                case 3:
                    Console.WriteLine("Parkerat ");
                    break;
                case 4:
                    Console.WriteLine("Parkerat ");
                    break;
                case 5:
                    Meny();
                    break;
                default:
                    Console.WriteLine("Ogiltigt val, försök igen");
                    break;
            }
        }
    }
}
