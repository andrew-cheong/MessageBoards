using MessageBoards.Domain.CommandHandlers;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MessageBoards.Domain.CommandIdentifiers
{
    public abstract class CommandIdentifierBase
    {
        public abstract CommandType CommandType { get; }
        public abstract string CommandRegex { get; }
        public abstract BaseCommandHandler CommandHandler { get; }

        public bool IsMatch(string commandText)
        {
            return Regex.IsMatch(commandText, CommandRegex);
        }

        public Match Match(string commandText)
        {
            return Regex.Match(commandText, CommandRegex);
        }

        public string[] GetCommandTokens(string commandText)
        {
            Match match = Match(commandText);
            
            // Get list of tokens in command
            List<string> tokens = match.Groups.Values.Select(u => u.Value).ToList();
            
            // Don't need the first one because it's the entire command
            tokens.RemoveAt(0);

            return tokens.ToArray();
        }
    }
}
