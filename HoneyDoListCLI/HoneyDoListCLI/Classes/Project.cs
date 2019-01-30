using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyDoListCLI.Classes
{
    public class Project
    {
        // Properties
        public string ProjectTitle { get; private set; }
        public string ProjectDesc { get; private set; }
        public bool IsFinished { get; private set; } = false;
        public decimal EstimatedCost { get; private set; }
        public decimal ActualCost { get; private set; }
        private List<string> steps = new List<string>();

        public decimal DifferenceOfEstimateAndActual
        {
            get
            {
                decimal result = 0;
                if (IsFinished)
                {
                    result = EstimatedCost - ActualCost;  
                }
                return result;
            }
        }



        // Constructor
        public Project(string projectTitle, string projectDesc,  decimal estimatedCost)
        {
            ProjectTitle = projectTitle;
            ProjectDesc = projectDesc;
            EstimatedCost = estimatedCost;

        }

        //Methods
        public void FinishProject(decimal actualCost)
        {
            IsFinished = true;
            ActualCost = actualCost;
            ProjectList.FinishProject();
        }

        public void AddStepToProject(string step)
        {
            steps.Add(step);
        }

        public void DisplaySteps()
        {
            Console.WriteLine($"Project titled '{ProjectTitle}' Steps: ");
            Console.WriteLine();

            if (steps.Count == 0)
            {
                Console.WriteLine("No steps have been created for this project");
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < steps.Count; i++)
                {
                    Console.WriteLine($"Step {i + 1}: {steps[i]}");
                }
                Console.WriteLine();
            }
        }
    }
}
