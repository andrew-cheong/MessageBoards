using MessageBoards.Domain.CommandIdentifiers;
using NUnit.Framework;
using System;

namespace MessageBoards.Domain.UnitTests.FollowingCommandIdentifierTests
{
    [TestFixture]
    public class IsMatchMethod
    {
        [TestCase("Charlie follows Apollo")]
        [TestCase("Charlie follows Moonshot")]
        public void AllExamplesFromRequirementsDocShouldMatch(string command)
        {
            // Arrange
            var sut = new FollowingCommandIdentifier();

            // Act
            var result = sut.IsMatch(command);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
