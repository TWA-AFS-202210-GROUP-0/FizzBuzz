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

        [Fact]
        public void Should_return_Fizz_when_given_number_multiple_3()
        {
            CountGame countGame = new CountGame();
            int number = 3;
            string ordMappingResult = countGame.OrdMapping(number);
            Assert.Equal(expected: "Fizz", ordMappingResult);
        }

        [Fact]
        public void Should_return_Buzz_when_given_number_multiple_5()
        {
            CountGame countGame = new CountGame();
            int number = 5;
            string ordMappingResult = countGame.OrdMapping(number);
            Assert.Equal(expected: "Buzz", ordMappingResult);
        }
    }
}