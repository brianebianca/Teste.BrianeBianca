using System.Collections.Generic;

namespace Domain.Models
{
    public class PrintNumbersReturn
    {
        public PrintNumbersReturn()
        {
            numberString = new List<string>();
        }
        public List<string> numberString { get; set; }
    }
}
