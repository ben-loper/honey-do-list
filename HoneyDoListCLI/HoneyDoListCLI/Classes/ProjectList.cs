using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyDoListCLI.Classes
{
    public class ProjectList
    {
        private List<Project> projects = new List<Project>();

        public Project[] addedProjects
        {
            get { return projects.ToArray(); }
        }

        public void addProject(Project projectToAdd)
        {
            projects.Add(projectToAdd);
        }

    }
}
