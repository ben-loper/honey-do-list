using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyDoListCLI.Classes
{
    public class ProjectList
    {

        public List<Project> ListOfProjects { get; set; } = new List<Project>();

        private static int _numOfUnfinishedProjects = 0;
        private static int _numOfFinishedProjects = 0;
        public static int TotalNumOfProjects
        {
            get
            {
                return _numOfUnfinishedProjects + _numOfFinishedProjects;
            }
        }


        public void AddProjectToList(Project projectToAdd)
        {
            ListOfProjects.Add(projectToAdd);
            _numOfUnfinishedProjects++;
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
            Console.WriteLine($"Number of projects: {TotalNumOfProjects}");
            Console.WriteLine();
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
            Console.WriteLine($"Number of finished projects: {_numOfFinishedProjects}");
            Console.WriteLine();

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
                    Console.WriteLine($"Project Status: {ListOfProjects[i].IsFinished}");
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine();
                }  
            }
            Console.WriteLine($"Number of unfinished projects: {_numOfUnfinishedProjects}");
            Console.WriteLine();
        }

        public void DisplayProjectTitlesOnly(bool isFinished)
        {
            string projectStatus = "Unfinished";
            if (isFinished)
            {
                projectStatus = "Finished";
            }
            
            for (int i = 0; i < ListOfProjects.Count; i++)
            {
                if (ListOfProjects[i].IsFinished == isFinished)
                {
                    Console.WriteLine($"Project ID: {i + 1}");
                    Console.WriteLine($"Project Title: {ListOfProjects[i].ProjectTitle}");
                    Console.WriteLine($"Project Status: {projectStatus}");
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
            if (ListOfProjects[projectIndex].IsFinished)
            {
                _numOfFinishedProjects--;
            }
            else
            {
                _numOfUnfinishedProjects--;
            }

            ListOfProjects.RemoveAt(projectIndex);

        }

        public static void FinishProject()
        {
            _numOfFinishedProjects++;
            _numOfUnfinishedProjects--;
        }
        
        public Project GetProject(int projectIndex)
        {
            Project project = ListOfProjects[projectIndex];

            return project;
        }
        
    }
}
