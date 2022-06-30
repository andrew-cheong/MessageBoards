using MessageBoards.Domain.CommandHandlers;

namespace MessageBoards.Domain.CommandIdentifiers
{
    public class FollowingCommandIdentifier : CommandIdentifierBase
    {
        public override CommandType CommandType => CommandType.Following;
        public override string CommandRegex => @"(\w*) follows (\w*)";
        public override BaseCommandHandler CommandHandler => new FollowingCommandHandler();
    }
}
