using System.Collections.Generic;

namespace MessageBoards.Domain
{
    public class Project
    {
        private List<Message> _messages;
        private List<string> _followers;

        public string ProjectName { get; private set; }

        public Project(string projectName)
        {
            ProjectName = projectName;
            _messages = new List<Message>();
            _followers = new List<string>();
        }

        public void PostMessage(string user, string text)
        {
            var message = new Message(user, text, ProjectName);
            _messages.Add(message);
        }

        public Message[] GetMessages()
        {
            return _messages.ToArray();
        }

        public void AddFollower(string user)
        {
            _followers.Add(user);
        }

        public string[] GetFollowers()
        {
            return _followers.ToArray();
        }
    }
}
