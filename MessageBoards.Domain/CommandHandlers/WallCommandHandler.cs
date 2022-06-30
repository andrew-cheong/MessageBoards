using MessageBoards.Domain.CommandPrinters;

namespace MessageBoards.Domain.CommandHandlers
{
    public class WallCommandHandler : BaseCommandHandler
    {
        public override BaseCommandPrinter CommandPrinter => new WallCommandPrinter();

        public override void HandleCommand(string[] commandTokens)
        {
            string user = commandTokens[0];

            Project[] projects = ProjectsRepository.GetFollowerProjects(user);

            if (CommandPrinter == null)
                throw new System.Exception("WallCommandHandler printer has not been configured");

            CommandPrinter.Print(projects);
        }
    }
}
