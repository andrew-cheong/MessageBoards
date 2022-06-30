using MessageBoards.Domain.CommandIdentifiers;
using NUnit.Framework;

namespace MessageBoards.Domain.UnitTests.ReadingCommandIdentifierTests
{
    [TestFixture]
    public class MatchMethod
    {
        [TestCase("Moonshot", "Moonshot")]
        [TestCase("Apollo", "Apollo")]
        public void AllExamplesFromRequirementsDocShouldHaveCorrectGroups(string command, string project)
        {
            // Arrange
            var sut = new ReadingCommandIdentifier();

            // Act
            var result = sut.Match(command);

            // Assert
            Assert.AreEqual(2, result.Groups.Count);
            Assert.AreEqual(project, result.Groups[1].Value, "Project does not match");
        }
    }
}
