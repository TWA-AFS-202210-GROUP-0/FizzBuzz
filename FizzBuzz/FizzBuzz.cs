using System;

namespace FizzBuzz
{
    public class FizzBuzzClass
    {
        public string Shout(int number)
        {
            if (number % 3 == 0)
            {
                return "Fizz";
            }

            if (number % 7 == 0)
            {
                return "Buzz";
            }

            return number.ToString();
        }
    }
}
