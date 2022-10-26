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

            if (number % 7 == 0)
            {
                return "Whizz";
            }

            if (number.ToString().Contains("3"))
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
