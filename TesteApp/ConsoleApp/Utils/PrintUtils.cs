using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Utils
{
    public class PrintUtils
    {
        public void PrintListOfStrings(List<string> stringList)
        {
            Console.WriteLine("Resultado: Listagem de números múltiplos e 3 e de 5");
            Console.WriteLine();
            foreach (string text in stringList)
            {
                Console.WriteLine(text);
            }
            Console.WriteLine();
        }

        public void PrintSquaredSum(List<int> intList, int returnedValue)
        {
            Console.WriteLine("Resultado: Soma e quadrados");
            Console.WriteLine();
            Console.WriteLine("Dada a lista de inteiros:");

            foreach (int number in intList)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine($"Sua soma de quadrados é:{returnedValue}");
            Console.WriteLine();
        }

        public void PrintFibonacci(int n, int result)
        {
            Console.WriteLine("Resultado: Achar o primeiro número de 5 elementos na sequência de fibonacci");
            Console.WriteLine();
            Console.WriteLine($"F({n})={result}");
            Console.WriteLine();
        }
    }
}
