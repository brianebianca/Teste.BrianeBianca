using Domain.Functions;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.FunctionsService
{
    public class FunctionSquaredService
    {
        FunctionSquaredSum functionSquaredSum;

        public FunctionSquaredService()
        {
            functionSquaredSum = new FunctionSquaredSum();
        }

        public FunctionSquaredReturn ShowSquaredSumResult(List<int> numbers)
        {
            var result = functionSquaredSum.SumOfSquared(numbers);
            FunctionSquaredReturn functionSquaredReturn = new FunctionSquaredReturn()
            {
                numbers = numbers,
                returnedValue = result
            };

            return functionSquaredReturn;
        }
    }
}
