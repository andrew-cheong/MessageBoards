using MessageBoards.Domain.CommandIdentifiers;
using NUnit.Framework;

namespace MessageBoards.Domain.UnitTests.WallCommandIdentifierTests
{
    [TestFixture]
    public class IsMatchMethod
    {
        [TestCase("Charlie wall")]
        [TestCase("Bob wall")]
        public void AllExamplesFromRequirementsDocShouldMatch(string command)
        {
            // Arrange
            var sut = new WallCommandIdentifier();

            // Act
            var result = sut.IsMatch(command);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
