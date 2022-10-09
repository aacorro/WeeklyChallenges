using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals) => vals.Contains(false);


        public bool IsSumOfOddsOdd(IEnumerable<int> numbers) 
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }
            var oddSum = numbers.Sum();
            return (oddSum % 2 != 0);
        }


        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var lower = false;
            var upper = false;
            var num = false;

            for (var i = 0; i < password.Length; i++)
            {
                if (char.IsLower(password[i]))
                {
                    lower = true;
                }
                if (char.IsUpper(password[i]))
                {
                    upper = true;
                }
                if (char.IsNumber(password[i]))
                    {
                    num = true; 
                }
            }

            if(lower && upper && num)
            {
               return true;
            }
            else
            {
               return false;
            }
            
        }

        public char GetFirstLetterOfString(string val)
        {
            char first = val[0];
            return first;
        }

    public char GetLastLetterOfString(string val) => val[val.Length - 1];
        

        public decimal Divide(decimal dividend, decimal divisor)
        {
            
            if(divisor > 0)
            {
                return Decimal.Divide(dividend, divisor);
            }
            else
            {
                return 0;
            }
        }

    public int LastMinusFirst(int[] nums)  
        {
            int first = nums[0];
            int last = nums[nums.Length - 1];
            return (last) - (first);
        }

        public int[] GetOddsBelow100()
        {
            var list =  new List<int>();

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    list.Add(i);
                }

            }
            return list.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
           for (int i = 0; i < words.Length; i++)
                words[i] = words[i].ToUpper();
        }
    }
}
