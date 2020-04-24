using System.Collections.Generic;
using System.Web.Mvc;
using Domain.Models;
using Service.FunctionsService;
using WebSite.Models;

namespace WebSite.Controllers
{
    public class ResultsController : Controller
    {
        FunctionPrintNumbersService functionPrintNumbersService;
        FunctionSquaredService functionSquaredService;
        FuncFibonacciService functionFibonacciService;
        public ResultsController()
        {
            functionPrintNumbersService = new FunctionPrintNumbersService();
            functionSquaredService = new FunctionSquaredService();
            functionFibonacciService = new FuncFibonacciService();

        }
        public ActionResult Results()
        {
            FunctionsModel model = new FunctionsModel();

            model.PrintNumbersReturn = GetPrintNumbersReturn();
            model.squaredReturn = GetFunctionSquaredReturn();
            model.fibonacciReturn = GetFibonacciReturn();

            return View(model);
        }

        private PrintNumbersReturn GetPrintNumbersReturn()
        {
            Tag name = new Tag("Briane");
            Tag lastName = new Tag("Bianca");
            return functionPrintNumbersService.ListNumbers(name, lastName);
        }
        private FunctionSquaredReturn GetFunctionSquaredReturn()
        {
            var numbersList = new List<int>();
            for(int i=1; i < 6; i++)
            {
                numbersList.Add(i);
            }
            return functionSquaredService.ShowSquaredSumResult(numbersList);
        }

        private FibonacciReturn GetFibonacciReturn()
        {
            int digits = 5;
            return functionFibonacciService.ShowFibonacciResult(digits);
        }
    }
}