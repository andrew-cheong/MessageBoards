using System;

namespace MessageBoards.Domain
{
    public class Message
    {
        public string User { get; private set; }
        public string Text { get; private set; }
        public object Project { get; internal set; }
        public DateTime PostedOn { get; private set; }

        public Message(string user, string text, string project)
        {
            User = user;
            Text = text;
            Project = project;
            PostedOn = DateTime.Now;
        }
    }
}
