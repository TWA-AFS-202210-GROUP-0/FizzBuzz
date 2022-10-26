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

            else
            {
                return string.Empty;
            }
        }
    }
}
