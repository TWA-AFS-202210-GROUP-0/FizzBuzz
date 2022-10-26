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
    }
}