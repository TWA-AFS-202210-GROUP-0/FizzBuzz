using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class CountGameTest
    {
        [Fact]
        public void Should_return_number_when_given_normal_number()
        {
            CountGame countGame = new CountGame();
            int number = 1;
            string ordMappingResult = countGame.OrdMapping(number);
            Assert.Equal(expected: "1", ordMappingResult);
        }
    }
}