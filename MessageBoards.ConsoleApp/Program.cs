using MessageBoards.Domain;
using MessageBoards.Domain.CommandHandlers;
using MessageBoards.Domain.CommandIdentifiers;
using System.Text.RegularExpressions;

namespace MessageBoards.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CommandIdentifierBase[] commandIdentifiers = new CommandIdentifierBase[] { new PostingCommandIdentifier(), new ReadingCommandIdentifier(), new FollowingCommandIdentifier(), new WallCommandIdentifier() };

            System.Console.WriteLine("WELCOME TO PROJECT MESSAGE BOARDS");
            System.Console.WriteLine("=================================");
            System.Console.WriteLine();

            while (true)
            {
                // Print nice caret.
                System.Console.Write("> ");

                // Read command from user.
                string command = System.Console.ReadLine();

                // "q" to quit.
                if (command.ToLowerInvariant() == "q")
                    break;

                // Loop over each command identifier to see if it is the one that matches the command.
                foreach (CommandIdentifierBase commandIdentifier in commandIdentifiers)
                {
                    bool isMatch = commandIdentifier.IsMatch(command);
                    string[] commandTokens = commandIdentifier.GetCommandTokens(command);
                    BaseCommandHandler handler = commandIdentifier.CommandHandler;

                    if (isMatch)
                    {
                        // Call the handler to execute the command.
                        handler.HandleCommand(commandTokens);

                        // Command handled, we can wait for the next command.
                        break;
                    }
                }
            }
        }
    }
}
