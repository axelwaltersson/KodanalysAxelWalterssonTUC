using System;

namespace Kodanalys
{
    class Program
    {
        static string[] userNames = new string[10];
        static int totalUsers = 0;

        static void Main(string[] args)
        {
            bool programRunning = true;
            while (programRunning)
            {
                Console.WriteLine("Välj ett alternativ:");
                Console.WriteLine("1. Lägg till användare");
                Console.WriteLine("2. Visa alla användare");
                Console.WriteLine("3. Ta bort användare");
                Console.WriteLine("4. Sök användare");
                Console.WriteLine("5. Avsluta");
                string menuSelection = Console.ReadLine();

                if (menuSelection == "1")
                {
                    Console.Write("Ange namn: ");
                    string newUserName = Console.ReadLine();
                    if (totalUsers < 10)
                    {
                        userNames[totalUsers] = newUserName;
                        totalUsers++;
                    }
                    else
                    {
                        Console.WriteLine("Listan är full!");
                    }
                }
                else if (menuSelection == "2")
                {
                    Console.WriteLine("Användare:");
                    for (int i = 0; i < totalUsers; i++)
                    {
                        Console.WriteLine(userNames[i]);
                    }
                }
                else if (menuSelection == "3")
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
                else if (menuSelection == "4")
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
                else if (menuSelection == "5")
                {
                    programRunning = false;
                }
                else
                {
                    Console.WriteLine("Ogiltigt val.");
                }
                Console.WriteLine();
            }
        }
    }
}
