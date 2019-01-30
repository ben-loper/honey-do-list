
using HoneyDoListCLI.Classes;
using System;

namespace HoneyDoListCLI
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool isRunning = true;

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            Project electrical = new Project("Electrical", "Replace the lits in the kitchen and all recepticals in house", 50.00m);
            Project hoseBib = new Project("Hose Bib", "Replace backyard hose bib", 30.00m);
            Project carpets = new Project("Carpets", "Replace all the carpet in each room", 200.00m);
            Project ceilingFan = new Project("Ceiling Fan", "Replace the ceiling the fan in entrance with a chandlier", 100.00m);
            Project slidingGlassDoor = new Project("Sliding Glass Door", "Replace the wheels on the sliding glass door and repair the tracks", 30.00m);

            ProjectList projectList = new ProjectList();

            projectList.AddProjectToList(electrical);
            projectList.AddProjectToList(hoseBib);
            projectList.AddProjectToList(carpets);
            projectList.AddProjectToList(ceilingFan);
            projectList.AddProjectToList(slidingGlassDoor);

            while (isRunning)
            {  

                NewScreen();

                Console.WriteLine("A - Display all projects");
                Console.WriteLine("B - Display finished projects");
                Console.WriteLine("C - Display unfinished projects");
                Console.WriteLine("D - Create a new project");
                Console.WriteLine("F - Finish a project");
                Console.WriteLine("G - Delete a project");
                Console.WriteLine("I - Display steps in a project");
                Console.WriteLine("H - Logo");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();
                Console.Write("Please enter a letter for the corresponding screen and press enter: ");

                string userChoice = Console.ReadLine();
                
                if(userChoice.ToLower() == "a")
                {
                    NewScreen();

                    projectList.DisplayAllProjects();
                    Console.WriteLine("Press any key to return to the main menu...");
                    Console.ReadKey();
                } else if(userChoice.ToLower() == "b")
                {
                    NewScreen();

                    projectList.DisplayFinishedProjects();
                    Console.WriteLine("Press any key to return to the main menu...");
                    Console.ReadKey();
                } else if(userChoice.ToLower() == "c")
                {
                    NewScreen();
                    
                    projectList.DisplayUnfinishedProjects();

                    Console.WriteLine("Press any key to return to the main menu...");
                    Console.ReadKey();
                }
                
                //Create a new project
                else if (userChoice.ToLower() == "d")
                {
                    NewScreen();

                    Console.Write("Please enter a title for your project: ");

                    string projectName = Console.ReadLine();

                    NewScreen();

                    Console.Write("Please enter a description for your project: ");

                    string projectDesc = Console.ReadLine();

                    NewScreen();

                    Console.Write("Please enter an estimated cost for the project: ");

                    decimal estimatedCost = decimal.Parse(Console.ReadLine());

                    Project project = new Project(projectName, projectDesc, estimatedCost);

                    projectList.AddProjectToList(project);

                    NewScreen();
                    Console.WriteLine("Created new project and added to list of unfinished projects");
                    Console.WriteLine();
                    Console.Write("Press any key to return to the main menu...");
                    Console.ReadKey();
                    
                }
                else if(userChoice.ToLower() == "f")
                {
                    NewScreen();
                    int selectedProject;
                    int indexValue;

                    projectList.DisplayProjectTitlesOnly(false);

                    Console.Write("Please enter the project ID for the project to finish: ");
                    selectedProject = int.Parse(Console.ReadLine());
                    indexValue = selectedProject - 1;

                    if(indexValue >= ProjectList.TotalNumOfProjects || indexValue < 0)
                    {
                        NewScreen();
                        Console.WriteLine("Project does not exist in the list!");
                        Console.Write("Press any key to return back to the main menu...");
                        Console.ReadKey();
                    }
                    else
                    {
                        string projectTitle = projectList.ListOfProjects[indexValue].ProjectTitle;

                        NewScreen();

                        Console.Write("Please enter how much it cost to complete the project: ");
                        decimal actualCost = decimal.Parse(Console.ReadLine());

                        NewScreen();

                        projectList.ListOfProjects[indexValue].FinishProject(actualCost);

                        Console.WriteLine($"Project titled '{projectTitle}' has been updated to finished");
                        Console.Write("Press any key to return to the main menu...");
                        Console.ReadKey();
                    }


                }
                else if (userChoice.ToLower() == "g")
                {
                    NewScreen();
                    int selectedProject;
                    int indexValue;

                    projectList.DisplayProjectTitlesOnly();

                    Console.Write("Please enter the project ID for the project you wish to delete: ");
                    selectedProject = int.Parse(Console.ReadLine());
                    indexValue = selectedProject - 1;

                    if (selectedProject > ProjectList.TotalNumOfProjects + 1 ^ selectedProject < 0)
                    {
                        NewScreen();
                        Console.WriteLine("Project does not exist in the list!");
                        Console.Write("Press any key to return back to the main menu...");
                        Console.ReadKey();
                    }
                    else
                    {
                        string projectTitle = projectList.ListOfProjects[indexValue].ProjectTitle;

                        NewScreen();

                        projectList.RemoveProjectFromList(indexValue);

                        Console.WriteLine($"Project titled '{projectTitle}' has been removed");
                        Console.Write("Press any key to return to the main menu...");
                        Console.ReadKey();
                    }
                }
                else if (userChoice.ToLower() == "h")
                {
                    DisplayLogo();
                    Console.WriteLine();
                    Console.Write("Press any key to return to the main menu...");
                    Console.ReadKey();
                }
                else if (userChoice.ToLower() == "i")
                {
                    NewScreen();

                    projectList.DisplayProjectTitlesOnly();

                    Console.Write("Enter the project ID of the project you wish to view the steps for: ");
                    int projectId = int.Parse(Console.ReadLine());
                    int projectIndex = projectId - 1;

                    if (projectIndex < 0 ^ projectIndex >= ProjectList.TotalNumOfProjects)
                    {
                        NewScreen();
                        Console.WriteLine("Project ID does not exist");
                        Console.WriteLine();
                        Console.Write("Press any key to return to the main menu...");
                        Console.ReadKey();
                    } else
                    {
                        NewScreen();
                        Project project = projectList.GetProject(projectIndex);
                        project.DisplaySteps();

                        Console.WriteLine("A - Add new step to project");
                        Console.WriteLine("B - Return to main menu");
                        Console.WriteLine();
                        Console.Write("Please enter a letter for the corresponding screen and press enter: ");

                        userChoice = Console.ReadLine().ToLower();

                        while(userChoice == "a")
                        {
                            NewScreen();
                            Console.Write("Please enter the step and press enter: ");
                            project.AddStepToProject(Console.ReadLine());

                            NewScreen();
                            project.DisplaySteps();

                            Console.WriteLine("A - Add new step to project");
                            Console.WriteLine("R - Return to main menu");
                            Console.WriteLine();
                            Console.Write("Please enter a letter for the corresponding screen and press enter: ");
                            userChoice = Console.ReadLine().ToLower();
                        }
                        
                    }
                }
                else if(userChoice.ToLower() == "q")
                {
                    isRunning = false;
                }
                
            }
        }


        public static void NewScreen()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Honey Do List");
            Console.WriteLine("-------------");
            Console.WriteLine();
        }



        public static void DisplayLogo()
        {
            Console.Clear();
            Console.WriteLine("******************************************************");
            Console.WriteLine("******************************************************");
            Console.WriteLine("******************************************************");
            Console.WriteLine();
            Console.WriteLine("HHH   HHH    OOOOOOO    NNNN   NNN  EEEEEEE  YY     YY");
            Console.WriteLine("HHH   HHH   OO     OO   NNNN   NNN  EEEEEEE   YY   YY");
            Console.WriteLine("HHHHHHHHH  OO       OO  NNNNNN NNN  EE         YY YY");
            Console.WriteLine("HHHHHHHHH  OO       OO  NNN NN NNN  EEEEEEE     YYY");
            Console.WriteLine("HHH   HHH   OO     OO   NNN  NNNNN  EE          YYY");
            Console.WriteLine("HHH   HHH    OOOOOOO    NNN   NNNN  EEEEEEE     YYY");

            Console.WriteLine();
            Console.WriteLine("              DDDDDDD      OOOOOOO");
            Console.WriteLine("              DDD   DDD   OO     OO");
            Console.WriteLine("              DDD    DDD OO       OO");
            Console.WriteLine("              DDD    DDD OO       OO");
            Console.WriteLine("              DDD   DDD   OO     OO");
            Console.WriteLine("              DDDDDDD      OOOOOOO ");

            Console.WriteLine();
            Console.WriteLine("       LLLL      IIIIIII   SSSSSSS   TTTTTTTTT");
            Console.WriteLine("       LLLL        III    SSSS       TTTTTTTTT");
            Console.WriteLine("       LLLL        III      SSSSS       TTT");
            Console.WriteLine("       LLLL        III        SSSSS     TTT");
            Console.WriteLine("       LLLLLLLL    III         SSSS     TTT");
            Console.WriteLine("       LLLLLLLL  IIIIIII  SSSSSSSS      TTT");
            Console.WriteLine();
            Console.WriteLine("******************************************************");
            Console.WriteLine("******************************************************");
            Console.WriteLine("******************************************************");
            Console.WriteLine();
        }
    }
}
