using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyDoListCLI.Classes
{
    class ProjectList
    {
        public List<Project> ListOfProjects { get; } = new List<Project>();

        public int NumOfProjects
        {
            get
            {
                return ListOfProjects.Count;
            }
        }

        public void AddProjectToList(Project projectToAdd)
        {
            ListOfProjects.Add(projectToAdd);
        }

        public void DisplayAllProjects()
        {

            for (int i = 0; i < ListOfProjects.Count; i++)
            {
                Console.WriteLine($"Project ID: {i + 1}");
                Console.WriteLine($"Project Title: {ListOfProjects[i].ProjectTitle}");
                Console.WriteLine($"Project Description: {ListOfProjects[i].ProjectDesc}");
                Console.WriteLine($"Estimated Cost: {ListOfProjects[i].EstimatedCost.ToString("C")}");
                Console.WriteLine($"Project Finished: {ListOfProjects[i].IsFinished}");

                if (ListOfProjects[i].IsFinished)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Actual Cost: {ListOfProjects[i].ActualCost}");
                    Console.WriteLine($"Difference Between Actual and Estimated: {ListOfProjects[i].DifferenceOfEstimateAndActual.ToString("C")}");
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
            for (int i = 0; i < ListOfProjects.Count; i++)
            {
                if (ListOfProjects[i].IsFinished)
                {
                    Console.WriteLine($"Project ID: {i + 1}");
                    Console.WriteLine($"Project Title: {ListOfProjects[i].ProjectTitle}");
                    Console.WriteLine($"Project Description: {ListOfProjects[i].ProjectDesc}");
                    Console.WriteLine($"Estimated Cost: {ListOfProjects[i].EstimatedCost.ToString("C")}");
                    Console.WriteLine($"Project Finsihed: {ListOfProjects[i].IsFinished}");
                    Console.WriteLine();
                    Console.WriteLine($"Actual Cost: {ListOfProjects[i].ActualCost.ToString("C")}");
                    Console.WriteLine($"Difference Between Actual and Estimated: {ListOfProjects[i].DifferenceOfEstimateAndActual.ToString("C")}");
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine();
                }
            }

        }

        public void DisplayUnfinishedProjects()
        {
            for (int i = 0; i < ListOfProjects.Count; i++)
            {
                if (!ListOfProjects[i].IsFinished)
                {
                    Console.WriteLine($"Project ID: {i + 1}");
                    Console.WriteLine($"Project Title: {ListOfProjects[i].ProjectTitle}");
                    Console.WriteLine($"Project Description: {ListOfProjects[i].ProjectDesc}");
                    Console.WriteLine($"Estimated Cost: {ListOfProjects[i].EstimatedCost.ToString("C")}");
                    Console.WriteLine($"Project Finsihed: {ListOfProjects[i].IsFinished}");
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine();
                }
            }
        }

        public void DisplayProjectTitlesOnly(bool isFinished)
        {
            for (int i = 0; i < ListOfProjects.Count; i++)
            {
                if (ListOfProjects[i].IsFinished == isFinished)
                {
                    Console.WriteLine($"Project ID: {i + 1}");
                    Console.WriteLine($"Project Title: {ListOfProjects[i].ProjectTitle}");
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine();
                }
            }
        }
        public void DisplayProjectTitlesOnly()
        {
            for (int i = 0; i < ListOfProjects.Count; i++)
            {
                Console.WriteLine($"Project ID: {i + 1}");
                Console.WriteLine($"Project Title: {ListOfProjects[i].ProjectTitle}");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine();
            }
        }

        public void RemoveProjectFromList(int projectIndex)
        {
            ListOfProjects.RemoveAt(projectIndex);

        }
    }
}
