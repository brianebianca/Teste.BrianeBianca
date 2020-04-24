using ConsoleApp.Functions;
using ConsoleApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FuntionsCaller funtionsCaller = new FuntionsCaller();
            funtionsCaller.CallAllFunctions();
            Console.ReadLine();
        }
    }
}
