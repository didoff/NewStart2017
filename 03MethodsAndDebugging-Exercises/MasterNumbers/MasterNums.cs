using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNumbers
{
    class MasterNums
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine(ContainsEvenDigit(input));
        }

        private static bool IsPalindrome(int num)
        {
            string numToChar = Convert.ToString(num);

            string first = numToChar.Substring(0, numToChar.Length / 2);
            char[] arr = numToChar.ToArray();
            Array.Reverse(arr);
            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);
            return first.Equals(second);
        }

        private static bool SumOfDigits(int num)
        {
            int sum = 0;

            for (int i = 0; i < num; i++)
            {
                int digit = num % 10;
                digit += sum;

                num /= 10;
            }

            if (sum % 7 == 0)
                return true;
            else
                return false;
        }

        private static bool ContainsEvenDigit(int num)
        {
            bool containsEven = false;

            while (containsEven == false)
            {
                int digit = num % 10;

                if (digit % 2 == 0)
                {
                    containsEven = true;
                    break;
                }

                num /= 10;

                if (num < 0)
                    break;
            }

            return containsEven;
        }
    }
}
