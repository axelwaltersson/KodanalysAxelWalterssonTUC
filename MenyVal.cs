namespace Kodanalys
{
    class MenyVal
    {
        static string[] userNames = new string[10];
        static int totalUsers = 0;
        const int maxUsers = 10;

        public void AddUser()
        {
            Console.Write("Ange namn: ");
            string newUserName = Console.ReadLine();
            if (totalUsers < maxUsers)
            {
                userNames[totalUsers] = newUserName;
                totalUsers++;
            }
            else
            {
                Console.WriteLine("Listan är full!");
            }
        }

        public void ListUsers()
        {
            Console.WriteLine("Användare:");
            for (int i = 0; i < totalUsers; i++)
            {
                Console.WriteLine(userNames[i]);
            }
        }

        public void RemoveUser()
        {
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
        }
        public void SearchUser()
            {
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
        }
        public void ExitProgram()
            {
                Environment.Exit(0);
        }
    }      
}
