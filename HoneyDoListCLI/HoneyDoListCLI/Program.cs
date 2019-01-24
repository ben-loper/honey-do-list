using System;
using System.Collections.Generic;
using HoneyDoListCLI.Classes;

namespace HoneyDoListCLI
{
    class Program
    {
        public static void Main(string[] args)
        {
            Project electrical = new Project("Electrical", "Replace the lights in the kitchen and recepticals", false);
            Project hoseBib = new Project("Hose Bib", "Replace backyard hose bib", true);
            Project replaceCarpet = new Project("Carpets", "Replace all the carpet in each room", false);
            Project replaceCeilingFan = new Project("Ceiling Fan", "Replace the ceiling fan in enterance with a chandelier", false);
            Project fixSlidingGlassDoor = new Project("Sliding Glass Door", "Replace the wheels on the sliding glass door and repair the tracks", true);

            ProjectList listOfProjects = new ProjectList();

            listOfProjects.addProject(electrical);
            listOfProjects.addProject(hoseBib);
            listOfProjects.addProject(replaceCarpet);
            listOfProjects.addProject(replaceCeilingFan);
            listOfProjects.addProject(fixSlidingGlassDoor);

            foreach(Project item in listOfProjects.addedProjects)
            {
                string finished = "No";
                if(item.IsCompleted == true)
                {
                    finished = "Yes";
                }

                Console.WriteLine($"Project Title: {item.ProjectTitle}\n");
                Console.WriteLine($"Project Description: {item.ProjectDescription}\n");
                Console.WriteLine($"Project finished: {finished}\n");
                Console.WriteLine("***********************************\n");
            }

            Console.ReadKey();
        }

    }
}
