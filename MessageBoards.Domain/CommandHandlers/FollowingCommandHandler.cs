using MessageBoards.Domain.CommandPrinters;

namespace MessageBoards.Domain.CommandHandlers
{
    public class FollowingCommandHandler : BaseCommandHandler
    {
        public override BaseCommandPrinter CommandPrinter => null;

        public override void HandleCommand(string[] commandTokens)
        {
            string user = commandTokens[0];
            string projectName = commandTokens[1];

            Project project = ProjectsRepository.GetProject(projectName);
            project.AddFollower(user);
        }
    }
}
