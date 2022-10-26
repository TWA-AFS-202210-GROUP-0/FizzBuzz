using System.Collections.Generic;
using System.Threading;
using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzTest
    {
        [Fact]
        public void Should_return_the_input_number_as_string_Given_normal_case()
        {
            //Given
            var number = 1;
            //When
            var result = FizzBuzzGame.Play(number);
            //Then
            Assert.Equal("1", result);
        }


        [Fact]
        public void Should_return_correct_answer_Given_all_mutiple_cases_()
        {
            //Given
            var numbers = new List<int> { 1, 3, 5, 7, 15, 21, 70, 105 };
            var expects = new List<string>
                { "1", "Fizz", "Buzz", "Whizz", "FizzBuzz", "FizzWhizz", "BuzzWhizz", "FizzBuzzWhizz" };
            //When
            var actuals = new List<string>();
            for (int i = 0; i < numbers.Count; i++)
            {
                actuals.Add(FizzBuzzGame.Play(numbers[i]));
            }

            //Then
            Assert.Equal(expects, actuals);
        }


        [Fact]
        public void Should_return_correct_answer_Given_all_contains_cases_()
        {
            //Given
            var numbers = new List<int> { 13, 23, 35 };
            var expects = new List<string>
                { "Fizz", "Fizz", "Fizz" };
            //When
            var actuals = new List<string>();
            for (int i = 0; i < numbers.Count; i++)
            {
                actuals.Add(FizzBuzzGame.Play(numbers[i]));
            }

            //Then
            Assert.Equal(expects, actuals);
        }
    }
}