using MessageBoards.Domain.CommandHandlers;

namespace MessageBoards.Domain.CommandIdentifiers
{
    public class ReadingCommandIdentifier : CommandIdentifierBase
    {
        public override CommandType CommandType => CommandType.Reading;
        public override string CommandRegex => @"^(\w*)$";
        public override BaseCommandHandler CommandHandler => new ReadingCommandHandler();
    }
}
