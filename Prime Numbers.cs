using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Find_Prime_Numbers_Lab_JT
{
    public class Prime_Numbers
    {
        public List<int> ListPrimes(int num3)
        {
            // Default empty list
            var result = new List<int>();
            for (int n = 0; n <= num3; n++)
            {
                if (GetPrime(n))
                {
                    result.Add(n);
                }
            }
            return result;
        }

        public bool GetPrime(int num)
        {
            
            int max = (int)(Math.Sqrt(num) + 1);

            if (num < 2)  // Negative Numbers, 0, 1, and evens are instantly out
            {
                return false;
            }
            if (num < 4)
            {
                return true;
            }
            if (IsEven(num)) //even numbers cannot be prime
            {
                return false; 
            }
            for (int n = 3; n <= max; n += 2)
            {
                if (IsDivisor(num, n))
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsEven(int num2) //if number is even
        {
            if (num2 % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsDivisor(int N, int n) //if the number can only be divided by itself
        {
            return (N % n == 0);
        }
       
    }
}
