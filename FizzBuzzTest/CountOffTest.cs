using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class CountOffTest
    {
        [Fact]
        public void Should_return_normal_number_when_CountOff_give_number()
        {
            //given
            CountOff countNumber = new CountOff();
            int number = 3;
            //then
            var result = countNumber.Game(number);
            Assert.Equal("3", result);
        }
    }
}