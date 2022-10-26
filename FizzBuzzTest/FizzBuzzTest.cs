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

        [Fact]
        public void Should_return_Fizz_when_count_given_number_has_factor_of_3()
        {
            //givem
            var fb = new FizzBuzzClass();
            int num = 3;

            //when
            var shout = fb.Shout(num);

            //then
            Assert.Equal("Fizz", shout);
        }

        [Fact]
        public void Should_return_Buzz_when_count_given_number_has_factor_of_5()
        {
            //givem
            var fb = new FizzBuzzClass();
            int num = 5;

            //when
            var shout = fb.Shout(num);

            //then
            Assert.Equal("Buzz", shout);
        }

        [Fact]
        public void Should_return_Buzz_when_count_given_number_has_factor_of_7()
        {
            //givem
            var fb = new FizzBuzzClass();
            int num = 7;

            //when
            var shout = fb.Shout(num);

            //then
            Assert.Equal("Whizz", shout);
        }
    }
}