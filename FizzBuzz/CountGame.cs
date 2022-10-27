using System;

namespace FizzBuzz
{
    public class CountGame
    {
        public string OrdMapping(int number)
        {
            if (number.ToString().Contains(Consts.StringThree))
            {
                return Consts.Fizz;
            }

            if (number % Consts.Three == 0)
            {
                if (number % Consts.Five == 0)
                {
                    if (number % Consts.Seven == 0)
                    {
                        return Consts.FizzBuzzWhizz;
                    }

                    return Consts.FizzBuzz;
                }

                if (number % Consts.Seven == 0)
                {
                    return Consts.FizzWhizz;
                }

                return Consts.Fizz;
            }

            if (number % Consts.Five == 0)
            {
                if (number % Consts.Seven == 0)
                {
                    return Consts.BuzzWhizz;
                }

                return Consts.Buzz;
            }

            if (number % Consts.Seven == 0)
            {
                return Consts.Whizz;
            }

            return number.ToString();
        }
    }
}
