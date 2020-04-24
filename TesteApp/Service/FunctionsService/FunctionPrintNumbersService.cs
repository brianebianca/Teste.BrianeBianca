using Domain.Models;
using Domain.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.FunctionsService
{
    public class FunctionPrintNumbersService
    {
        FunctionPrintNumbers functionPrintNumbers;
        public FunctionPrintNumbersService()
        {
            functionPrintNumbers = new FunctionPrintNumbers();
        }
        public PrintNumbersReturn ListNumbers(Tag name, Tag lastName)
        {
            var printNumbersReturn = new PrintNumbersReturn();
            printNumbersReturn.numberString = functionPrintNumbers.ListNumbers(name, lastName);
            return printNumbersReturn;
        }
    }
}
