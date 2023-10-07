using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirror_Number
{
    internal class Operation
    {
        public bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        public bool IsPalindrome(int number)
        {
            int reversedNumber = 0;
            int originalNumber = number;

            while (number > 0)
            {
                int remainder = number % 10;
                reversedNumber = (reversedNumber * 10) + remainder;
                number = number / 10;
            }

            return originalNumber == reversedNumber;
        }
    }
}
