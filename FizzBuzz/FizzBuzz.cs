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

           if (number % 5 == 0)
            {
                return "Buzz";
            }

           else
            {
                return string.Empty;
            }
        }
    }
}
