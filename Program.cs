namespace Kodanalys
{
    class Program
    {
        static void Main(string[] args)
        {
            MenyVal meny = new MenyVal();

            while (true)
            {
                GenereraMeny();
                string menuSelection = Console.ReadLine();

                switch (menuSelection)
                {
                    case "1":
                        meny.AddUser();
                        break;
                    case "2":
                        meny.ListUsers();
                        break;
                    case "3":
                        meny.RemoveUser();
                        break;
                    case "4":
                        meny.SearchUser();
                        break;
                    case "5":
                        meny.ExitProgram();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Ogiltigt val.");
                        Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }

        public static void GenereraMeny()
        {
            Console.WriteLine("Välj ett alternativ:");
            Console.WriteLine("1. Lägg till användare");
            Console.WriteLine("2. Visa alla användare");
            Console.WriteLine("3. Ta bort användare");
            Console.WriteLine("4. Sök användare");
            Console.WriteLine("5. Avsluta");
        }
    }
}