using System.ComponentModel.Design;

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

            Console.WriteLine("Välj att logga in som: \n");
            
            Console.WriteLine("1: Kund");
            Console.WriteLine("2: Ägare ");
            Console.WriteLine("3: Parkeringsvakt ");
            Console.WriteLine("4: Avsluta program ");

            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (userInput)
            {
                case 1: 
                   
                    break;

                case 2:
                    break;

                case 3:
                    
                    break;

                case 4:
                    Environment.Exit(0);

                    break;

                default:
                    Console.WriteLine("Ogiltigt val, försök igen ");
                    break;
            }
        }

        public static void UserMenu(Parkinglot parkinglot)
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

        public static void LoginAuth()
        {
            int input = 0;

            string user = "user";
            string userPass = "user";
            string owner = "admin";
            string ownerPass = "admin";
            string guard = "guard";
            string guardPass = "guard";

            Console.WriteLine("Användarnamn: ");

            string username = Console.ReadLine();
            Console.WriteLine("Lösenord: ");
            string password = Console.ReadLine();

            if(username == user && password == userPass)
            {
                input = 1;
            }
            else if(username == owner && password == ownerPass)
            {
                input = 2;
            }
            else if(username == guard && password == guardPass)
            {
                input = 3;
            }

            switch(input)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    break;
                    
            }
        }
    
    }
    
}
