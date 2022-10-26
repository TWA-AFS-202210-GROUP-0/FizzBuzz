using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzTest
    {
        [Fact]
        public void Should_return_number_when_count_off_given_normal_number()
        {
            //Given
            FizzBuzzCount test = new FizzBuzzCount();
            int number = 1;

            //when
            string result = test.CountOff(number);

            //then
            Assert.Equal("1", result);
        }

        [Fact]
        public void Should_return_Fizz_when_count_off_given_number_only_multiple_of_three()
        {
            //Given
            FizzBuzzCount test = new FizzBuzzCount();
            int number = 3;

            //when
            string result = test.CountOff(number);

            //then
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void Should_return_FizzBuzz_when_count_off_given_number_both_multiple_of_three_and_five()
        {
            //Given
            FizzBuzzCount test = new FizzBuzzCount();
            int number = 15;

            //when
            string result = test.CountOff(number);

            //then
            Assert.Equal("FizzBuzz", result);
        }

        [Fact]
        public void Should_return_FizzBuzz_when_count_off_given_number_all_multiple_of_three_and_five_and_seven()
        {
            //Given
            FizzBuzzCount test = new FizzBuzzCount();
            int number = 105;

            //when
            string result = test.CountOff(number);

            //then
            Assert.Equal("FizzBuzzWhizz", result);
        }
    }
}