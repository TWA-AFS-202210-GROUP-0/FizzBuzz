using System;
using System.Net;
using System.Xml.Schema;

namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        public static string Play(int number)
        {
            string result = string.Empty;
            foreach (char c in number.ToString())
            {
                if (c == '3')
                {
                    return "Fizz";
                }
            }

            if (number % 3 == 0)
            {
                result += "Fizz";
            }

            if (number % 5 == 0)
            {
                result += "Buzz";
            }

            if (number % 7 == 0)
            {
                result += "Whizz";
            }

            if (result == string.Empty)
            {
                result = number.ToString();
            }

            return result;
        }
    }
}
