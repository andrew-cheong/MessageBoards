using MessageBoards.Domain.CommandIdentifiers;
using NUnit.Framework;
using System;

namespace MessageBoards.Domain.UnitTests.PostingCommandIdentifierTests
{
    [TestFixture]
    public class IsMatchMethod
    {
        [TestCase("Alice -> @Moonshot I'm working on the log on screen")]
        [TestCase("Bob -> @Moonshot Awesome, I'll start on the forgotten password screen")]
        [TestCase("Bob -> @Apollo Has anyone thought about the next release demo?")]
        [TestCase("Bob -> @Moonshot I'll give you the link to put on the log on screen shortly Alice")]
        public void AllExamplesFromRequirementsDocShouldMatch(string command)
        {
            // Arrange
            var sut = new PostingCommandIdentifier();

            // Act
            var result = sut.IsMatch(command);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
