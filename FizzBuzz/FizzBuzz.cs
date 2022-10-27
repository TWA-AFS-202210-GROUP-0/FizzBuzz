using System;

namespace FizzBuzz
{
    public class FizzBuzzClass
    {
        public string Shout(int number)
        {
            if (number.ToString().Contains("3"))
            {
                return "Fizz";
            }

            string res = string.Empty;

            if (number % 3 == 0)
            {
                res += "Fizz";
            }

            if (number % 5 == 0)
            {
                res += "Buzz";
            }

            if (number % 7 == 0)
            {
                res += "Whizz";
            }

            if (res == string.Empty)
            {
                res = number.ToString();
            }

            return res;
        }
    }
}
