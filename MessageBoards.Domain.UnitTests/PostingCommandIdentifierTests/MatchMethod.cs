using MessageBoards.Domain.CommandIdentifiers;
using NUnit.Framework;

namespace MessageBoards.Domain.UnitTests.PostingCommandIdentifierTests
{
    [TestFixture]
    public class MatchMethod
    {
        [TestCase("Alice -> @Moonshot I'm working on the log on screen", "Alice", "Moonshot", "I'm working on the log on screen")]
        [TestCase("Bob -> @Moonshot Awesome, I'll start on the forgotten password screen", "Bob", "Moonshot", "Awesome, I'll start on the forgotten password screen")]
        [TestCase("Bob -> @Apollo Has anyone thought about the next release demo?", "Bob", "Apollo", "Has anyone thought about the next release demo?")]
        [TestCase("Bob -> @Moonshot I'll give you the link to put on the log on screen shortly Alice", "Bob", "Moonshot", "I'll give you the link to put on the log on screen shortly Alice")]
        public void AllExamplesFromRequirementsDocShouldHaveCorrectGroups(string command, string user, string project, string message)
        {
            // Arrange
            var sut = new PostingCommandIdentifier();

            // Act
            var result = sut.Match(command);

            // Assert
            Assert.AreEqual(4, result.Groups.Count);
            Assert.AreEqual(user, result.Groups[1].Value, "User does not match");
            Assert.AreEqual(project, result.Groups[2].Value, "Project does not match");
            Assert.AreEqual(message, result.Groups[3].Value, "Message does not match");
        }
    }
}
