using MessageBoards.Domain.CommandHandlers;

namespace MessageBoards.Domain.CommandIdentifiers
{
    public class PostingCommandIdentifier : CommandIdentifierBase
    {
        public override CommandType CommandType => CommandType.Posting;
        public override string CommandRegex => @"(\w*) -> @{1}(\w*) (.*)";
        public override BaseCommandHandler CommandHandler => new PostingCommandHandler();
    }
}
