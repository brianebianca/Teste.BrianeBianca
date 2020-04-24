using ConsoleApp.Utils;
using Domain.Models;
using Service.FunctionsService;
using System.Collections.Generic;

namespace ConsoleApp.Functions
{
    public class FuntionsCaller
    {
        FunctionPrintNumbersService functionPrintNumbersService;
        FunctionSquaredService functionSquaredService;
        FuncFibonacciService functionFibonacciService;
        PrintUtils printUtils;

        public FuntionsCaller()
        {
            functionPrintNumbersService = new FunctionPrintNumbersService();
            functionSquaredService = new FunctionSquaredService();
            functionFibonacciService = new FuncFibonacciService();
            printUtils = new PrintUtils();
        }

        public void CallAllFunctions()
        {
            this.CallPrintNumbers();
            this.CallFunctionSquaredSum();
            this.CallFibonacci();
        }

        private void CallPrintNumbers()
        {
            Tag name = new Tag("Briane");
            Tag lastName = new Tag("Bianca");
            var numbersList = functionPrintNumbersService.ListNumbers(name, lastName);
            printUtils.PrintListOfStrings(numbersList.numberString);
        }

        private void CallFunctionSquaredSum()
        {
            var numbersList = new List<int>();
            for (int i = 1; i < 6; i++)
            {
                numbersList.Add(i);
            }
            var result = functionSquaredService.ShowSquaredSumResult(numbersList);

            printUtils.PrintSquaredSum(result.numbers, result.returnedValue);
        }

        private void CallFibonacci()
        {
            int digits = 5;
            var result =  functionFibonacciService.ShowFibonacciResult(digits);

            printUtils.PrintFibonacci(result.n, result.result);
        }
    }
}
