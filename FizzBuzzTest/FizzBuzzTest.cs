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
        public void Should_return_Whizz_when_count_given_number_has_factor_of_7()
        {
            //givem
            var fb = new FizzBuzzClass();
            int num = 7;

            //when
            var shout = fb.Shout(num);

            //then
            Assert.Equal("Whizz", shout);
        }

        [Fact]
        public void Should_return_FizzBuzz_when_count_given_number_has_factor_of_3_and_5()
        {
            //givem
            var fb = new FizzBuzzClass();
            int num = 15;

            //when
            var shout = fb.Shout(num);

            //then
            Assert.Equal("FizzBuzz", shout);
        }

        [Fact]
        public void Should_return_FizzWhizz_when_count_given_number_has_factor_of_3_and_7()
        {
            //givem
            var fb = new FizzBuzzClass();
            int num = 21;

            //when
            var shout = fb.Shout(num);

            //then
            Assert.Equal("FizzWhizz", shout);
        }

        [Fact]
        public void Should_return_BuzzWhizz_when_count_given_number_has_factor_of_5_and_7()
        {
            //givem
            var fb = new FizzBuzzClass();
            int num = 70;

            //when
            var shout = fb.Shout(num);

            //then
            Assert.Equal("BuzzWhizz", shout);
        }

        [Fact]
        public void Should_return_FizzBuzzWhizz_when_count_given_number_has_factor_of_3_5_and_7()
        {
            //givem
            var fb = new FizzBuzzClass();
            int num = 105;

            //when
            var shout = fb.Shout(num);

            //then
            Assert.Equal("FizzBuzzWhizz", shout);
        }

        [Fact]
        public void Should_return_Fizz_when_count_given_number_contains_3()
        {
            //givem
            var fb = new FizzBuzzClass();
            int num = 13;

            //when
            var shout = fb.Shout(num);

            //then
            Assert.Equal("Fizz", shout);
        }
    }
}