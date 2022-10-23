using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            return numbers.Where(x => x % 2 == 0).Sum() - numbers.Where(k => k % 2 != 0).Sum();

        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            string[] words = { str1, str2, str3, str4 };
            return words.Min(p => p.Length);

        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] num = { number1, number2, number3, number4 };
            return num.Min(p => p);

        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (

                    sideLength1 + sideLength2 > sideLength3 &&
                    sideLength1 + sideLength3 > sideLength2 &&
                    sideLength3 + sideLength2 > sideLength1
                  );
        }

        public bool IsStringANumber(string input)
        {
            try
            {
                double.Parse(input);
                return true;
            } catch { return false; }
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
           => objs.Where((o) => o == null).Count() > objs.Where((o) => o != null).Count() ?
            true : false;

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            var x = numbers.Where(x => x % 2 == 0);
            if (x.Count() == 0)
            {
                return 0;
            }
            return x.Average();

        }
        public int Factorial(int number)
        {
            int fact = 1;
            for (int i = 2; i <= number; i++)
            {
                 fact = fact * i;
            }
            return fact;
        }
        
    }
}
