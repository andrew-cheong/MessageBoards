using MessageBoards.Domain.CommandIdentifiers;
using NUnit.Framework;

namespace MessageBoards.Domain.UnitTests.ReadingCommandIdentifierTests
{
    [TestFixture]
    public class IsMatchMethod
    {
        [TestCase("Moonshot")]
        [TestCase("Apollo")]
        public void AllExamplesFromRequirementsDocShouldMatch(string command)
        {
            // Arrange
            var sut = new ReadingCommandIdentifier();

            // Act
            var result = sut.IsMatch(command);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
