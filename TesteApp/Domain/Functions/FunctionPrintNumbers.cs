using Domain.Models;
using System.Collections.Generic;

namespace Domain.Functions
{
    public class FunctionPrintNumbers
    {
        public List<string> ListNumbers(Tag name, Tag lastName)
        {
            var numberStringList = new List<string>();

            for (int i = 1; i < 101; i++)
            {
                var isMultipleOfThree = IsMultipleOfThree(i);
                var isMultipleOfFive = IsMultipleOfFive(i);
                numberStringList.Add(getNumberString(i, isMultipleOfThree, isMultipleOfFive, name, lastName));
            }

            return numberStringList;
        }

        public bool IsMultipleOfThree(int number)
        {
            return number % 3 == 0 ? true : false;
        }

        public bool IsMultipleOfFive(int number)
        {
            return number % 5 == 0 ? true : false;
        }

        public string getNumberString(int number, bool isMultipleOfThree, bool isMultipleOfFive, Tag name, Tag lastName)
        {
            if (isMultipleOfThree && isMultipleOfFive)
            {
                return getNumberStringMultipleOfThreeAndFive(number, name, lastName);
            }
            else if (isMultipleOfThree)
            {
                return getNumberStringMultipleOfThree(number, name);
            }
            else if (isMultipleOfFive)
            {
                return getNumberStringMultipleOfFive(number, lastName);
            }
            return getNumberStringNotMultiple(number);
        }
        public string getNumberStringNotMultiple(int number)
        {
            return $"{number}";
        }
        public string getNumberStringMultipleOfThree(int number, Tag name)
        {
            return $"{number} {name.Value}";
        }

        public string getNumberStringMultipleOfFive(int number, Tag lastName)
        {
            return $"{number} {lastName.Value}";
        }

        public string getNumberStringMultipleOfThreeAndFive(int number, Tag name, Tag lastName)
        {
            return $"{number} {name.Value} {lastName.Value}";
        }
    }
}
