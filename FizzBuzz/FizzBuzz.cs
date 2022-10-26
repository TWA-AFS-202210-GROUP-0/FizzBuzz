using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public FizzBuzz()
        {
        }

        public string CountOff(int number)
        {
           if (number % 3 == 0)
            {
                return "Fizz";
            }
           else
            {
                return string.Empty;
            }
        }
    }
}
