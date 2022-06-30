using MessageBoards.Domain.CommandHandlers;

namespace MessageBoards.Domain.CommandIdentifiers
{
    public class WallCommandIdentifier : CommandIdentifierBase
    {
        public override CommandType CommandType => CommandType.Wall;
        public override string CommandRegex => @"(\w*) wall";
        public override BaseCommandHandler CommandHandler => new WallCommandHandler();
    }
}
