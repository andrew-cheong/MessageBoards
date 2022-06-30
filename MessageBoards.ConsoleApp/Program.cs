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
                System.Console.Write("> ");
                string command = System.Console.ReadLine();

                // "q" to quit
                if (command.ToLowerInvariant() == "q")
                    break;

                foreach (CommandIdentifierBase commandIdentifier in commandIdentifiers)
                {
                    bool isMatch = commandIdentifier.IsMatch(command);
                    //Match match = commandIdentifier.Match(testCommand);
                    string[] commandTokens = commandIdentifier.GetCommandTokens(command);
                    //CommandType commandType = commandIdentifier.CommandType;
                    BaseCommandHandler handler = commandIdentifier.CommandHandler;

                    if (isMatch)
                    {
                        // Call the handler to execute the command
                        handler.HandleCommand(commandTokens);
                        break;
                    }
                }
            }
        }
    }
}
