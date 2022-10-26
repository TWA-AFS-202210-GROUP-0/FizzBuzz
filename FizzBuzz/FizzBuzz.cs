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

            return number.ToString();
        }
    }
}
