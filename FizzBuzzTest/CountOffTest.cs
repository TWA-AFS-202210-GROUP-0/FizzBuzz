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
            //when
            var result = countNumber.GetRequirementOne(number);
            //then
            Assert.Equal("3", result);
        }

        [Fact]
        public void Should_return_Fizz_when_CountOff_is_multiples_of_three()
        {
            //given
            CountOff countNumber = new CountOff();
            int number = 9;
            //when
            var result = countNumber.GetRequirementTwo(number);
            //then
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void Should_return_Buzz_when_CountOff_is_multiples_of_five()
        {
            //given
            CountOff countNumber = new CountOff();
            int number = 10;
            //when
            var result = countNumber.GetRequirementTwo(number);
            //then
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void Should_return_Whizz_when_CountOff_is_multiples_of_seven()
        {
            //given
            CountOff countNumber = new CountOff();
            int number = 14;
            //when
            var result = countNumber.GetRequirementTwo(number);
            //then
            Assert.Equal("Whizz", result);
        }

        [Fact]
        public void Should_return_normalNumber_when_CountOff_requirement2_is_neither_multiples_of_three_or_five_or_seven()
        {
            //given
            CountOff countNumber = new CountOff();
            int number = 2;
            //when
            var result = countNumber.GetRequirementTwo(number);
            //then
            Assert.Equal("2", result);
        }

        [Fact]
        public void Should_return_warning_when_CountOff_requirement2_is_negative()
        {
            //given
            CountOff countNumber = new CountOff();
            int number = -2;
            //when
            var result = countNumber.GetRequirementTwo(number);
            //then
            Assert.Equal("Invalid negative Number!", result);
        }

        [Fact]
        public void Should_return_BuzzWhizz_when_CountOff_is_multiples_of_five_and_seven()
        {
            //given
            CountOff countNumber = new CountOff();
            int number = 35;
            //when
            var result = countNumber.GetRequirementThree(number);
            //then
            Assert.Equal("BuzzWhizz", result);
        }

        [Fact]
        public void Should_return_FizzWhizz_when_CountOff_is_multiples_of_three_and_seven()
        {
            //given
            CountOff countNumber = new CountOff();
            int number = 21;
            //when
            var result = countNumber.GetRequirementThree(number);
            //then
            Assert.Equal("FizzWhizz", result);
        }

        [Fact]
        public void Should_return_FizzBuzz_when_CountOff_is_multiples_of_three_and_five()
        {
            //given
            CountOff countNumber = new CountOff();
            int number = 15;
            //when
            var result = countNumber.GetRequirementThree(number);
            //then
            Assert.Equal("FizzBuzz", result);
        }

        [Fact]
        public void Should_return_FizzBuzzWhizz_when_CountOff_is_multiples_of_three_and_five_and_seven()
        {
            //given
            CountOff countNumber = new CountOff();
            int number = 105;
            //when
            var result = countNumber.GetRequirementThree(number);
            //then
            Assert.Equal("FizzBuzzWhizz", result);
        }

        [Fact]
        public void Should_return_normalNumber_when_CountOff_requirement3_is_neither_multiples_of_three_or_five_or_seven()
        {
            //given
            CountOff countNumber = new CountOff();
            int number = 2;
            //when
            var result = countNumber.GetRequirementThree(number);
            //then
            Assert.Equal("2", result);
        }

        [Fact]
        public void Should_return_warning_when_CountOff_requirement3_is_negative()
        {
            //given
            CountOff countNumber = new CountOff();
            int number = -2;
            //when
            var result = countNumber.GetRequirementThree(number);
            //then
            Assert.Equal("Invalid negative Number!", result);
        }

        [Fact]
        public void Should_return_Fizz_when_CountOff_contains_3()
        {
            //given
            CountOff countNumber = new CountOff();
            int number = 13;
            //when
            var result = countNumber.GetRequirementFour(number);
            //then
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void Should_return_Fizz_when_CountOff_isMultipleOf_3()
        {
            //given
            CountOff countNumber = new CountOff();
            int number = 6;
            //when
            var result = countNumber.GetRequirementFour(number);
            //then
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void Should_return_FizzBuzz_when_CountOff_Contain_3_and_is_Multiple_of_5()
        {
            //given
            CountOff countNumber = new CountOff();
            int number = 30;
            //when
            var result = countNumber.GetRequirementFour(number);
            //then
            Assert.Equal("FizzBuzz", result);
        }

        [Fact]
        public void Should_return_FizzBuzzWhizz_when_CountOff_Contain_3_and_is_Multiple_of_5_and_7()
        {
            //given
            CountOff countNumber = new CountOff();
            int number = 35;
            //when
            var result = countNumber.GetRequirementFour(number);
            //then
            Assert.Equal("FizzBuzzWhizz", result);
        }

        [Fact]
        public void Should_return_normalNumber_when_CountOff_requirement4_is_neither_multiples_of_three_or_five_or_seven_orContain3()
        {
            //given
            CountOff countNumber = new CountOff();
            int number = 11;
            //when
            var result = countNumber.GetRequirementFour(number);
            //then
            Assert.Equal("11", result);
        }

        [Fact]
        public void Should_return_warning_when_CountOff_requirement4_is_negative()
        {
            //given
            CountOff countNumber = new CountOff();
            int number = -2;
            //when
            var result = countNumber.GetRequirementFour(number);
            //then
            Assert.Equal("Invalid negative Number!", result);
        }

        [Fact]
        public void Should_return_Fizz_when_CountOff_contains3_and_IsMultiplesOf_3()
        {
            //given
            CountOff countNumber = new CountOff();
            int number = 33;
            //when
            var result = countNumber.GetRequirementFive(number);
            //then
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void Should_return_Fizz_when_CountOff_contains3_and_IsMultiplesOf_5()
        {
            //given
            CountOff countNumber = new CountOff();
            int number = 30;
            //when
            var result = countNumber.GetRequirementFive(number);
            //then
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void Should_return_Fizz_when_CountOff_contains3_and_IsMultiplesOf_7()
        {
            //given
            CountOff countNumber = new CountOff();
            int number = 35;
            //when
            var result = countNumber.GetRequirementFive(number);
            //then
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void Should_return_Fizz_when_CountOff_contains3_and_normal_number()
        {
            //given
            CountOff countNumber = new CountOff();
            int number = 31;
            //when
            var result = countNumber.GetRequirementFive(number);
            //then
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void Should_return_Fizz_when_CountOff_NotContain3_isMultiplesOf_3()
        {
            //given
            CountOff countNumber = new CountOff();
            int number = 9;
            //when
            var result = countNumber.GetRequirementFive(number);
            //then
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void Should_return_FizzBuzz_when_CountOff_NotContain3_isMultiplesOf_3_and_5()
        {
            //given
            CountOff countNumber = new CountOff();
            int number = 15;
            //when
            var result = countNumber.GetRequirementFive(number);
            //then
            Assert.Equal("FizzBuzz", result);
        }

        [Fact]
        public void Should_return_FizzBuzzWhizz_when_CountOff_NotContain3_isMultiplesOf_3_and_5_and_7()
        {
            //given
            CountOff countNumber = new CountOff();
            int number = 105;
            //when
            var result = countNumber.GetRequirementFive(number);
            //then
            Assert.Equal("FizzBuzzWhizz", result);
        }

        [Fact]
        public void Should_return_normalNumber_when_CountOff_requirement5_is_neither_multiples_of_three_or_five_or_seven_orContain3()
        {
            //given
            CountOff countNumber = new CountOff();
            int number = 11;
            //when
            var result = countNumber.GetRequirementFive(number);
            //then
            Assert.Equal("11", result);
        }

        [Fact]
        public void Should_return_warning_when_CountOff_requirement5_is_negative()
        {
            //given
            CountOff countNumber = new CountOff();
            int number = -2;
            //when
            var result = countNumber.GetRequirementFive(number);
            //then
            Assert.Equal("Invalid negative Number!", result);
        }


    }
}