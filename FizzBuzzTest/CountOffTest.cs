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

        [Fact]
        public void Should_return_normalNumber_when_CountOff_requirement2_is_neither_multiples_of_three_or_five_or_seven()
        {
            //given
            CountOff countNumber = new CountOff();
            int number = 2;
            //then
            var result = countNumber.GetRequirementTwo(number);
            Assert.Equal("2", result);
        }

        [Fact]
        public void Should_return_warning_when_CountOff_requirement2_is_negative()
        {
            //given
            CountOff countNumber = new CountOff();
            int number = -2;
            //then
            var result = countNumber.GetRequirementTwo(number);
            Assert.Equal("Invalid negative Number!", result);
        }

        [Fact]
        public void Should_return_BuzzWhizz_when_CountOff_is_multiples_of_five_and_seven()
        {
            //given
            CountOff countNumber = new CountOff();
            int number = 35;
            //then
            var result = countNumber.GetRequirementThree(number);
            Assert.Equal("BuzzWhizz", result);
        }

        [Fact]
        public void Should_return_FizzWhizz_when_CountOff_is_multiples_of_three_and_seven()
        {
            //given
            CountOff countNumber = new CountOff();
            int number = 21;
            //then
            var result = countNumber.GetRequirementThree(number);
            Assert.Equal("FizzWhizz", result);
        }

        [Fact]
        public void Should_return_FizzBuzz_when_CountOff_is_multiples_of_three_and_five()
        {
            //given
            CountOff countNumber = new CountOff();
            int number = 15;
            //then
            var result = countNumber.GetRequirementThree(number);
            Assert.Equal("FizzBuzz", result);
        }

        [Fact]
        public void Should_return_FizzBuzzWhizz_when_CountOff_is_multiples_of_three_and_five_and_seven()
        {
            //given
            CountOff countNumber = new CountOff();
            int number = 105;
            //then
            var result = countNumber.GetRequirementThree(number);
            Assert.Equal("FizzBuzzWhizz", result);
        }

        [Fact]
        public void Should_return_normalNumber_when_CountOff_requirement3_is_neither_multiples_of_three_or_five_or_seven()
        {
            //given
            CountOff countNumber = new CountOff();
            int number = 2;
            //then
            var result = countNumber.GetRequirementThree(number);
            Assert.Equal("2", result);
        }

        [Fact]
        public void Should_return_warning_when_CountOff_requirement3_is_negative()
        {
            //given
            CountOff countNumber = new CountOff();
            int number = -2;
            //then
            var result = countNumber.GetRequirementThree(number);
            Assert.Equal("Invalid negative Number!", result);
        }

        [Fact]
        public void Should_return_Fizz_when_CountOff_contains_3()
        {
            //given
            CountOff countNumber = new CountOff();
            int number = 13;
            //then
            var result = countNumber.GetRequirementFour(number);
            Assert.Equal("Fizz", result);


        }
}