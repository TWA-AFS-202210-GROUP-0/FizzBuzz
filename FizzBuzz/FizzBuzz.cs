using System;

namespace FizzBuzz
{
    public class FizzBuzzCount
    {
        public string CountOff(int number)
        {

            if (number.ToString().Contains("3"))
            {
                return "Fizz";
            }

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

            if (number % 7 == 0)
            {
                isSpecialNumber = true;
                countOffResult += "Whizz";
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
