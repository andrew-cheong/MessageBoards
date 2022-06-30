using MessageBoards.Domain.CommandPrinters;

namespace MessageBoards.Domain.CommandHandlers
{
    public class ReadingCommandHandler : BaseCommandHandler
    {
        public override BaseCommandPrinter CommandPrinter => new ReadingCommandPrinter();

        public override void HandleCommand(string[] commandTokens)
        {
            string projectName = commandTokens[0];

            Project project = ProjectsRepository.GetProject(projectName);

            if (project != null && CommandPrinter != null)
                CommandPrinter.Print(project);
        }
    }
}
