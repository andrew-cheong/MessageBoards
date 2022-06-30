using MessageBoards.Domain.CommandPrinters;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoards.Domain.CommandHandlers
{

    public class PostingCommandHandler : BaseCommandHandler
    {
        public override BaseCommandPrinter CommandPrinter => null;

        public override void HandleCommand(string[] commandTokens)
        {
            string user = commandTokens[0];
            string projectName = commandTokens[1];
            string message = commandTokens[2];

            Project project = ProjectsRepository.GetProject(projectName);

            project.PostMessage(user, message);
        }
    }
}
