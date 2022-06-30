using Humanizer;
using System;
using System.Linq;

namespace MessageBoards.Domain.CommandPrinters
{
    public class WallCommandPrinter : BaseCommandPrinter
    {
        public override void Print(params Project[] projects)
        {
            Message[] messages = projects.SelectMany(u => u.GetMessages()).OrderBy(u => u.PostedOn).ToArray();

            foreach (Message message in messages)
                PrintMessage(message);
        }

        public override void PrintMessage(Message message)
        {
            Console.WriteLine($"{message.Project} - {message.User}: {message.Text} ({message.PostedOn.Humanize()})");
        }
    }
}
