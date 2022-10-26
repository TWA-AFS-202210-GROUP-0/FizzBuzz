using Moq;
using Xunit;

namespace FizzBuzzTest
{
    using FizzBuzz;

    public class Class1Test
    {
        [Fact]
        public void Should_return_Fizz_when_number_is_multiples_3()
        {
            // Given
            FizzBuzz fizzBuzz = new FizzBuzz();
            var number = 3;

            // When
            var res = fizzBuzz.CountOff(number);

            //then
            Assert.Equal(res, "Fizz");
        }

        [Fact]
        public void Should_return_Buzz_when_number_is_multiples_5()
        {
            // Given
            FizzBuzz fizzBuzz = new FizzBuzz();
            var number = 5;

            // When
            var res = fizzBuzz.CountOff(number);

            //then
            Assert.Equal(res, "Buzz");
        }

        [Fact]
        public void Should_return_Whizz_when_number_is_multiples_7()
        {
            // Given
            FizzBuzz fizzBuzz = new FizzBuzz();
            var number = 7;

            // When
            var res = fizzBuzz.CountOff(number);

            //then
            Assert.Equal(res, "Whizz");
        }

        [Fact]
        public void Should_return_Fizz_when_number_contain_3()
        {
            // Given
            FizzBuzz fizzBuzz = new FizzBuzz();
            var number = 13;

            // When
            var res = fizzBuzz.CountOff(number);

            //then
            Assert.Equal(res, "Fizz");
        }
    }
}