namespace Kodanalys
{
    class MenyVal
    {
        static string[] userNames = new string[10];
        static int totalUsers = 0;
        const int maxUsers = 10;

        public void AddUser()
        {
            Console.Clear();
            Console.Write("Ange namn: ");
            string newUserName = Console.ReadLine();
            if (totalUsers < maxUsers)
            {
                userNames[totalUsers] = newUserName;
                totalUsers++;
            }

            if (totalUsers >= maxUsers)
            {
                Console.WriteLine("Max antal användare nått.");
            }
            else
            {
                Console.WriteLine("Användare tillagd: " + newUserName);
                AnyKeyMessage("Tryck på valfri tangent för att fortsätta...");
            }
        }

        public void ListUsers()
        {
            Console.Clear();
            Console.WriteLine("Användare: ");
            for (int i = 0; i < totalUsers; i++)
            {
                Console.WriteLine(userNames[i]);
            }
            AnyKeyMessage("Tryck på valfri tangent för att fortsätta...");
        }

        public void RemoveUser()
        {
            Console.Clear();
            Console.Write("Ange namn att ta bort: ");
            string userNameToRemove = Console.ReadLine();
            int userIndexToRemove = -1;
            for (int i = 0; i < totalUsers; i++)
            {
                if (userNames[i] == userNameToRemove)
                {
                    userIndexToRemove = i;
                    break;
                }
            }

            if (userIndexToRemove != -1)
            {
                for (int i = userIndexToRemove; i < totalUsers - 1; i++)
                {
                    userNames[i] = userNames[i + 1];
                }
                totalUsers--;
            }
            else
            {
                Console.WriteLine("Användaren hittades inte.");
            }
            AnyKeyMessage("Tryck på valfri tangent för att fortsätta...");
        }

        public void SearchUser()
        {
            Console.Clear();
            Console.Write("Ange namn att söka: ");
            string userNameToSearch = Console.ReadLine();
            bool userExists = false;
            for (int i = 0; i < totalUsers; i++)
            {
                if (userNames[i] == userNameToSearch)
                {
                    userExists = true;
                    break;
                }
            }
            if (userExists)
            {
                Console.WriteLine("Användaren finns i listan.");
            }
            else
            {
                Console.WriteLine("Användaren hittades inte.");
            }
            AnyKeyMessage("Tryck på valfri tangent för att fortsätta...");
        }

        public void ExitProgram()
        {
                Environment.Exit(0);
        }

        public void AnyKeyMessage(string meddelande)
        {
            Console.WriteLine(meddelande);
            Console.ReadKey();
            Console.Clear();
        }
    }      
}