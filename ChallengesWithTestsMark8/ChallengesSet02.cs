using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (char.IsLetter(c))
            {
                return true;
            }
            else
                return false;

        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
                return true;
            else
                return false;
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
                return true;
            else
                return false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
                return true;
            else
                return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            return numbers.Max() + numbers.Min();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            
        }

        public int Sum(int[] numbers)
        {
            var sum = numbers.Sum();
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            return numbers.Where(x => x % 2 == 0).Sum();
                    
        }

        public bool IsSumOdd(List<int> numbers)
        {
            var sum = numbers.Sum();
            if (sum % 2 != 0)
                return true;
            else
                return false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return 9;
        }
    }
}
