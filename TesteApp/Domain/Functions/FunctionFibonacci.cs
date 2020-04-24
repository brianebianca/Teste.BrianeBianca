using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Functions
{
    public class FunctionFibonacci
    {
        public int DoFibonacciWhileFindNDigitsNumber(out int n, int digits = 5)
        {
            int next = 1;
            int result = 0;
            n = 0;

            while (!HasNDigits(result, digits))
            {
                int temp = result;
                result = next;
                next = temp + next;
                n++;
            }
            return result;
        }

        public bool HasNDigits(int number, int n) 
        {
            return number.ToString().Length == n;
        }
    }
}
