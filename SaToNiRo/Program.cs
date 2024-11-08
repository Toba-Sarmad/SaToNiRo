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
                CustomerView.ChooseVehicle(parkinglot);
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

        
    }
}
