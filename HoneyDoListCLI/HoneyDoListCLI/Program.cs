using System;
using System.Collections.Generic;

namespace HoneyDoListCLI
{
    class Program
    {
        public static void Main(string[] args)
        {
            ToMainScreen();
        }

        public static void PrintBanner()
        {
            Console.Clear();
            Console.WriteLine("---------------------");
            Console.WriteLine("- The Honey Do List -");
            Console.WriteLine("---------------------\n");

        }

        public static void PrintOptions()
        {
            Console.WriteLine("A - Future Projects");
            Console.WriteLine("B - Finished Projects");
            Console.WriteLine("Q - Quit");
            Console.Write("\nPlease enter your selection: ");
        }

        public static void ToMainScreen()
        {
            bool isRunning = true;

            PrintBanner();
            PrintOptions();

            List<string> futureProjects = new List<string>();
            futureProjects.Add("Replace electrical recepticals");
            futureProjects.Add("Sand then paint metal pieces for windows and garage door");

            List<string> finishedProjects = new List<string>();
            finishedProjects.Add("Change light fixtures in the kitchen");
            finishedProjects.Add("Replace hose bib for the backyard");
            finishedProjects.Add("Unpack moving boxe");

            while (isRunning)
            {
                String decision = Console.ReadLine();

                if (decision.ToLower() == "a")
                {
                    PrintBanner();
                    Console.WriteLine("Future Projects: ");

                    if (futureProjects.Count == 0)
                    {
                        Console.WriteLine("No future projects planned! Get planning!");
                        Console.WriteLine();
                    }
                    else
                    {
                        for (int i = 0; i < futureProjects.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}: {futureProjects[i]}");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine("R - Return to Main Screen");
                    Console.WriteLine("Q - Quit\n");
                    Console.Write("Please enter a command: ");

                    decision = Console.ReadLine();

                    if (decision.ToLower() == "r")
                    {
                        ToMainScreen();
                    }
                    else if(decision.ToLower() == "q")
                    {
                        isRunning = false;
                        break;
                    }


                }
                else if (decision.ToLower() == "b")
                {
                    PrintBanner();

                    if (finishedProjects.Count == 0)
                    {
                        Console.WriteLine("Finished Projects: ");
                        Console.WriteLine("No finished projects :(");
                    }
                    else
                    {
                        Console.WriteLine("Finished Projects: ");
                        for (int i = 0; i < finishedProjects.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}: {finishedProjects[i]}");
                        }
                    }

                    Console.WriteLine("R - Return to Main Screen");
                    Console.WriteLine("Q - Quit\n");
                    Console.Write("Please enter a command: ");

                    decision = Console.ReadLine();

                    if (decision.ToLower() == "r")
                    {
                        ToMainScreen();
                    } else if(decision.ToLower() == "q")
                    {
                        isRunning = false;
                        break;
                    }
                } else if(decision.ToLower() == "q")
                {
                    isRunning = false;
                }
            }
        }
    }
}
