using System;
using System.Collections.Generic;
using System.Linq;

namespace MessageBoards.Domain
{
    public static class ProjectsRepository
    {
        private static readonly List<Project> _projects = new List<Project>();

        public static Project GetProject(string projectName)
        {
            Project project = _projects.FirstOrDefault(u => u.ProjectName == projectName);

            // Project exists, return it.
            if (project != null)
                return project;

            // Project doesn't exist, gotta create a new one and add it to the repo.
            Project newProject = BuildProject(projectName);
            _projects.Add(newProject);

            return newProject;
        }

        public static Project[] GetFollowerProjects(string user)
        {
            return _projects.Where(u => u.GetFollowers().Contains(user)).ToArray();
        }

        private static Project BuildProject(string projectName)
        {
            return new Project(projectName);
        }
    }
}
