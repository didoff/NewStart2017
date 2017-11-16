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

            for (int i = 1; i <= input; i++)
            {
                if (SumOfDigits(i) == true && ContainsEvenDigit(i) == true && IsPalindrome(i) == true)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool IsPalindrome(int num)
        {
            string numToSring = Convert.ToString(num);

            string first = numToSring.Substring(0, numToSring.Length / 2);
            char[] arr = numToSring.ToArray();
            Array.Reverse(arr);
            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);
            return first.Equals(second);
        }

        private static bool SumOfDigits(int num)
        {
            string str = num.ToString();
            int sum = 0;

            for (int i = 0; i < str.Length; i++)
            {
                sum += int.Parse(str[i].ToString());
            }

            if (sum % 7 == 0)
                return true;
            else
                return false;
        }

        //private static bool ContainsEvenDigit(int num)
        //{
        //    bool containsEven = false;

        //    while (containsEven == false)
        //    {
        //        int digit = num % 10;

        //        if (digit % 2 == 0 && digit > 0)
        //        {
        //            containsEven = true;
        //        }

        //        num /= 10;

        //        if (num <= 0)
        //            break;
        //    }

        //    return containsEven;
        //}

        public static bool ContainsEvenDigit(int number)
        {
            string str = number.ToString();
            int evenCounter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                int currentDigit = int.Parse(str[i].ToString());
                if (currentDigit % 2 == 0)
                {
                    evenCounter++;
                }
            }
            if (evenCounter > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
