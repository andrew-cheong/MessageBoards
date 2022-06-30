using MessageBoards.Domain.CommandPrinters;

namespace MessageBoards.Domain.CommandHandlers
{
    public abstract class BaseCommandHandler
    {
        public abstract BaseCommandPrinter CommandPrinter { get; }
        public abstract void HandleCommand(string[] commandTokens);
    }
}
