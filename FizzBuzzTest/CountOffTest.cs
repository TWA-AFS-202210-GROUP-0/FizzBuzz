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
            var result = countNumber.GetRequirementOne(number);
            Assert.Equal("3", result);
        }

        [Fact]
        public void Should_return_Fizz_when_CountOff_is_multiples_of_three()
        {
            //given
            CountOff countNumber = new CountOff();
            int number = 9;
            //then
            var result = countNumber.GetRequirementTwo(number);
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void Should_return_Buzz_when_CountOff_is_multiples_of_five()
        {
            //given
            CountOff countNumber = new CountOff();
            int number = 10;
            //then
            var result = countNumber.GetRequirementTwo(number);
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void Should_return_Whizz_when_CountOff_is_multiples_of_seven()
        {
            //given
            CountOff countNumber = new CountOff();
            int number = 14;
            //then
            var result = countNumber.GetRequirementTwo(number);
            Assert.Equal("Whizz", result);
        }
    }
}