using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyDoListCLI.Classes
{
    public class Project
    {
        private string projectTitle;
        public string ProjectTitle
        {
            get { return this.projectTitle; }
        }

        private string projectDescription;
        public string ProjectDescription
        {
            get { return this.projectDescription; }
        }

        private bool isCompleted;
        public bool IsCompleted
        {
            get { return this.isCompleted; }
        }

        
        public Project(string projectTitle, string projectDescription, bool isCompleted)
        {
            this.projectTitle = projectTitle;
            this.projectDescription = projectDescription;
            this.isCompleted = isCompleted;
        }
    }
}
