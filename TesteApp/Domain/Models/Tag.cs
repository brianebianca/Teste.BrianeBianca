using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Tag
    {
        public Tag(String value)
        {
            this.Value = value;
        }
        public string Value { get; set; }
    }
}
