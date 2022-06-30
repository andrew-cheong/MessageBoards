using MessageBoards.Domain.CommandIdentifiers;
using NUnit.Framework;

namespace MessageBoards.Domain.UnitTests.FollowingCommandIdentifierTests
{
    [TestFixture]
    public class MatchMethod
    {
        [TestCase("Charlie follows Apollo", "Charlie", "Apollo")]
        [TestCase("Charlie follows Moonshot", "Charlie", "Moonshot")]
        public void AllExamplesFromRequirementsDocShouldHaveCorrectGroups(string command, string user, string project)
        {
            // Arrange
            var sut = new FollowingCommandIdentifier();

            // Act
            var result = sut.Match(command);

            // Assert
            Assert.AreEqual(3, result.Groups.Count);
            Assert.AreEqual(user, result.Groups[1].Value, "User does not match");
            Assert.AreEqual(project, result.Groups[2].Value, "Project does not match");
        }
    }
}
