using PersonalTaskManager.Core.Helpers;

namespace PersonalTaskManager.Tests
{
    public class CalculateDateHelperTests
    {
        //Given_When_Then
        [Fact]
        public void ADatePreviousTheCurrentOne_NumberOfDaysOverdue_ShallReturnAStringContainingAtrasada()
        {
            //Arrange
            var date = new DateOnly(2023, 8, 25);

            var helper = new CalculateDateHelper();

            //Act
            var actual = helper.NumberOfDaysOVerdue(date);

            //Assert
            Assert.NotNull(actual);
            Assert.Contains("atrasada", actual);
        }

        [Fact]
        public void ShallReturnAStringContainingVencerGivenADateGreaterThanTheCurrentOne()
        {
            //Arrange
            var date = new DateOnly(2025, 8, 25);

            var helper = new CalculateDateHelper();

            //Act
            var actual = helper.NumberOfDaysOVerdue(date);

            //Assert
            Assert.NotNull(actual);
            Assert.Contains("vencer", actual);
        }
    }
}