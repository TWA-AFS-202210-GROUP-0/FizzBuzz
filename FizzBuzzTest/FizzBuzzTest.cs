using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzTest
    {
        [Fact]
        public void Should_return_number_string_when_count_given_normal_number()
        {
            //givem
            var fb = new FizzBuzzClass();
            int num = 2;

            //when
            var shout = fb.Shout(num);

            //then
            Assert.Equal("2", shout);
        }
    }
}