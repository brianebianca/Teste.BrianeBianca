using Domain.Functions;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.FunctionsService
{
    public class FuncFibonacciService
    {
        FunctionFibonacci functionFibonacci;
        public FuncFibonacciService()
        {
            functionFibonacci = new FunctionFibonacci();
        }
        public FibonacciReturn ShowFibonacciResult(int digits)
        {
            int n;
            var fib = functionFibonacci.DoFibonacciWhileFindNDigitsNumber(out n, digits);

            var fibonacciReturn = new FibonacciReturn()
            {
                n = n,
                result = fib
            };

            return fibonacciReturn;
        }
    }
}
