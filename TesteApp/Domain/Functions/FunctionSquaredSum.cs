using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Functions
{
    public class FunctionSquaredSum
    {
        public int SumOfSquared(List<int> numbers)
        {
            var result = 0;

            foreach(int number in numbers)
            {
                result += Square(number);
            }

            return result;
        }

        public int Square(int number)
        {
            return number * number;
        }
    }
}
