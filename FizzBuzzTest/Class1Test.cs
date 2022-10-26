using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class Class1Test
    {
        [Fact]
        public void Should_return_the_input_number_as_string_Given_normal_case()
        {
            //Given
            var number = 1;
            //When
            var result = FizzBuzzGame.Play();
            //Then
            Assert.Equal("1", result);
        }
    }
}