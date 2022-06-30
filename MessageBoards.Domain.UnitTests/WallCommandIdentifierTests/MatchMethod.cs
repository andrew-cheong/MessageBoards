using MessageBoards.Domain.CommandIdentifiers;
using NUnit.Framework;

namespace MessageBoards.Domain.UnitTests.WallCommandIdentifierTests
{
    [TestFixture]
    public class MatchMethod
    {
        [TestCase("Charlie wall", "Charlie")]
        [TestCase("Bob wall", "Bob")]
        public void AllExamplesFromRequirementsDocShouldHaveCorrectGroups(string command, string user)
        {
            // Arrange
            var sut = new WallCommandIdentifier();

            // Act
            var result = sut.Match(command);

            // Assert
            Assert.AreEqual(2, result.Groups.Count);
            Assert.AreEqual(user, result.Groups[1].Value, "User does not match");
        }
    }
}
