using System;

namespace FizzBuzz
{
    public class FizzBuzzCount
    {
        public string CountOff(int number)
        {
            bool isSpecialNumber = false;
            string countOffResult = string.Empty;

            if (number % 3 == 0)
            {
                isSpecialNumber = true;
                countOffResult += "Fizz";
            }

            if (number % 5 == 0)
            {
                isSpecialNumber = true;
                countOffResult += "Buzz";
            }

           

            if (isSpecialNumber)
            {
                return countOffResult;
            }
            else
            {
                return number.ToString();
            }
        }
    }
}
