using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyDoListCLI.Classes
{
    class Project
    {
        // Properties
        public string ProjectTitle { get; private set; }
        public string ProjectDesc { get; private set; }
        public bool IsFinished { get; private set; } = false;
        public decimal EstimatedCost { get; private set; }
        public decimal ActualCost { get; private set; }
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
        }
    }
}
