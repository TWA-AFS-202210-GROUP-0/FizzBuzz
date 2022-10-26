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

        [Fact]
        public void Should_return_Whizz_when_given_number_multiple_7()
        {
            CountGame countGame = new CountGame();
            int number = 7;
            string ordMappingResult = countGame.OrdMapping(number);
            Assert.Equal(expected: "Whizz", ordMappingResult);
        }

        [Fact]
        public void Should_return_FizzBuzz_when_given_number_multiple_3_5()
        {
            CountGame countGame = new CountGame();
            int number = 15;
            string ordMappingResult = countGame.OrdMapping(number);
            Assert.Equal(expected: "FizzBuzz", ordMappingResult);
        }

        [Fact]
        public void Should_return_FizzWhizz_when_given_number_multiple_3_7()
        {
            CountGame countGame = new CountGame();
            int number = 21;
            string ordMappingResult = countGame.OrdMapping(number);
            Assert.Equal(expected: "FizzWhizz", ordMappingResult);
        }

        [Fact]
        public void Should_return_BuzzWhizz_when_given_number_multiple_5_7()
        {
            CountGame countGame = new CountGame();
            int number = 35;
            string ordMappingResult = countGame.OrdMapping(number);
            Assert.Equal(expected: "BuzzWhizz", ordMappingResult);
        }
    }
}