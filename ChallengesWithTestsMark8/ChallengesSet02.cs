using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c) => Char.IsLetter(c);


        public bool CountOfElementsIsEven(string[] vals) => vals.Length % 2 == 0 ? true : false;


        public bool IsNumberEven(int number) => number % 2 == 0 ? true : false;


        public bool IsNumberOdd(int num) => num % 2 != 0 ? true : false;


        public double SumOfMinAndMax(IEnumerable<double> numbers) => numbers == null || numbers.Count() == 0 ? 0 : numbers.Min() + numbers.Max();


        public int GetLengthOfShortestString(string str1, string str2) => str1.Length < str2.Length ? str1.Length : str2.Length;


        public int Sum(int[] numbers) => numbers == null ? 0 : numbers.Sum();


        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            var sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }
    
       public bool IsSumOdd(List<int> numbers) => numbers == null || numbers.Count == 0 ? false : numbers.Sum() % 2 != 0;


        public long CountOfPositiveOddsBelowNumber(long number) => number <= 0 ? 0 : number / 2;    
       
        
    }
}
