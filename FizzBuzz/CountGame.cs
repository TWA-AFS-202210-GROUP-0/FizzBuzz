﻿using System;

namespace FizzBuzz
{
    public class CountGame
    {
        public string OrdMapping(int number)
        {
            if (number % 3 == 0)
            {
                return "Fizz";
            }

            if (number % 5 == 0)
            {
                return "Buzz";
            }

            return number.ToString();
        }
    }
}
