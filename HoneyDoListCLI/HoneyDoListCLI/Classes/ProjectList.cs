using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyDoListCLI.Classes
{
    class ProjectList
    {
        public List<Project> ListOfProjects { get; private set; } = new List<Project>();

        public void AddProjectToList(Project projectToAdd)
        {
            ListOfProjects.Add(projectToAdd);
        }

        public void DisplayAllProjects()
        {
            
            foreach(var project in ListOfProjects)
            {
                Console.WriteLine($"Project Title: {project.ProjectTitle}");
                Console.WriteLine($"Project Description: {project.ProjectDesc}");
                Console.WriteLine($"Estimated Cost: {project.EstimatedCost.ToString("C")}");
                Console.WriteLine($"Project Finished: {project.IsFinished}");

                if (project.IsFinished)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Actual Cost: {project.ActualCost}");
                    Console.WriteLine($"Difference Between Actual and Estimated: {project.DifferenceOfEstimateAndActual}");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Actual Cost: N/A");
                    Console.WriteLine("Difference Between Actual and Estimated: N/A");
                }
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine();
            }  
        }

        public void DisplayFinishedProjects()
        {
            foreach(var project in ListOfProjects)
            {
                if (project.IsFinished)
                {
                    Console.WriteLine($"Project Title: {project.ProjectTitle}");
                    Console.WriteLine($"Project Description: {project.ProjectDesc}");
                    Console.WriteLine($"Estimated Cost: {project.EstimatedCost.ToString("C")}");
                    Console.WriteLine($"Project Finsihed: {project.IsFinished}");
                    Console.WriteLine();
                    Console.WriteLine($"Actual Cost: {project.ActualCost.ToString("C")}");
                    Console.WriteLine($"Difference Between Actual and Estimated: {project.DifferenceOfEstimateAndActual.ToString("C")}");
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine();
                }
            }
        }

        public void DisplayUnfinishedProjects()
        {
            foreach (var project in ListOfProjects)
            {
                if (!project.IsFinished)
                {
                    Console.WriteLine($"Project Title: {project.ProjectTitle}");
                    Console.WriteLine($"Project Description: {project.ProjectDesc}");
                    Console.WriteLine($"Estimated Cost: {project.EstimatedCost.ToString("C")}");
                    Console.WriteLine($"Project Finsihed: {project.IsFinished}");
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine();
                }
            }
        }

    }
}
