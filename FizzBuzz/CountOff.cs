using System;
using System.Security.Cryptography.X509Certificates;

namespace FizzBuzz
{
    public class CountOff
    {
        public string GetRequirementOne(int number)
        {
            return number.ToString();
        }

        public string GetRequirementTwo(int number)
        {
           if (number > 0)
            {
                if (number % 3 == 0) { return "Fizz"; }
                if (number % 5 == 0) { return "Buzz"; }
                if (number % 7 == 0) { return "Whizz"; }
                return number.ToString();
            }
            else { return "Invalid negative Number!"; }
        }

        public string GetRequirementThree(int number)
        {
            if (number > 0)
            {
                string res = string.Empty;
                if (number % 3 == 0) { res += "Fizz"; }
                if (number % 5 == 0) { res += "Buzz"; }
                if (number % 7 == 0) { res += "Whizz"; }
                return res.Length > 0 ? res : number.ToString();
            }
            else { return "Invalid negative Number!";  }
        }

        public string GetRequirementFour(int number)
        {
            if (number > 0)
            {
                string res = string.Empty;
                string numString = number.ToString();
                bool containThree = false;
                int startIndex = 0;
                int length = 1;
                while (startIndex <= numString.Length - 1)
                {
                    string substring = numString.Substring(startIndex, length);
                    if (substring == "3") { containThree = true; }
                    startIndex += 1;
                }

                if (containThree | number % 3 == 0) { res += "Fizz"; }
                if (number % 5 == 0) { res += "Buzz"; }
                if (number % 7 == 0) { res += "Whizz"; }
                return res.Length > 0 ? res : numString;
            }
            else { return "Invalid negative Number!"; }

        }
    }
}
