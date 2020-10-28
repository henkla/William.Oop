using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using William.Oop.Library;


namespace William.Oop.Library.Tests
{
    public class CmopetitorTests
    {
        [Fact]
        public void MakeWinner_WhenCalled_SetsWinnerFlagToTrue()
        {
            // Arrange - förbered testet - skapa allt som behövs för att kunna utföra testet
            var competitor = new Competitor(1, "name");

            // Act
            competitor.MakeWinner();

            // Assert
            Assert.True(competitor.IsWinner);
        }

        [Theory]
        [InlineData("william")]
        [InlineData("henrik")]
        public void Competitor_WhenNameIsSetInCtor_NameFieldIsSet(string input)
        {
            // Arrange
            // Act
            var competitor = new Competitor(1, input);

            // Assert
            Assert.Equal(input, competitor.Name);
        }
    }
}
