using System;
using System.Security.Cryptography.X509Certificates;

namespace FizzBuzz
{
    public class CountOff
    {
        //return number % 7 == 0 ? "FizzBuzzWizz" : "FizzBuzz";
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
                if (res.Length > 0)
                {
                    return res;
                }
                else
                {
                    return number.ToString();
                }
            }
            else { return "Invalid negative Number!";  }
        }
    }
}
