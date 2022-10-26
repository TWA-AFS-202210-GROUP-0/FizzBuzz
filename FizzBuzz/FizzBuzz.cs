﻿using System;

namespace FizzBuzz
{
    public class FizzBuzzClass
    {
        public string Shout(int number)
        {
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

            return res;
        }
    }
}
