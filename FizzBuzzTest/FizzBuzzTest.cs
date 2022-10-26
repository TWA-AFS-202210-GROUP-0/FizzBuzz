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
            var result = FizzBuzzGame.Play();
            //Then
            Assert.Equal("1", result);
        }

        [Fact]
        public void Should_return_correct_answer_Given_all_cases()
        {
            //Given
            var numbers = new List<double> { 1, 3, 5, 7, 15, 21, 35, 105 };
            var results = new List<string>
                { "1", "Fizz", "Buzz", "Whizz", "FizzBuzz", "FizzWhizz", "BuzzWhizz", "FizzBuzzWhizz" };
        }
    }
}