using System;
using System.Collections.Generic;
using System.Linq;

namespace MessageBoards.Domain.CommandPrinters
{
    public abstract class BaseCommandPrinter
    {
        public abstract void PrintMessage(Message message);
        public abstract void Print(params Project[] projects);
        //public void Print(params Project[] projects)
        //{
        //    // Ready will only have one project in the list
        //    Project project = projects.FirstOrDefault();

        //    if (project == null)
        //        throw new Exception("Could not find project when printing read command");

        //    Message[] messages = project.GetMessages().OrderBy(u => u.PostedOn).ToArray();
        //    string prevUser = null;
        //    var buffer = new List<Message>();

        //    for (int i = 0; i < messages.Length; i++)
        //    {
        //        Message message = messages[i];

        //        if (prevUser != null && prevUser != message.User)
        //        {
        //            // New user, print out what we have in the buffer.
        //            PrintBuffer(buffer);

        //            // Clear buffer.
        //            buffer.Clear();
        //        }

        //        // Add next message to buffer.
        //        buffer.Add(message);

        //        // If it's the last message in the list, then print buffer before we exit loop.
        //        if (i == messages.Length - 1 && buffer.Any())
        //            PrintBuffer(buffer);

        //        prevUser = message.User;
        //    }
        //}

        protected void PrintBuffer(List<Message> buffer)
        {
            Message firstMessage = buffer[0];

            // Print user
            Console.WriteLine(firstMessage.User);

            // Print each message's text with timestamp
            foreach (Message message in buffer)
                PrintMessage(message);

            // Print new line to make it a little easier to read
            Console.WriteLine();
        }
    }
}
