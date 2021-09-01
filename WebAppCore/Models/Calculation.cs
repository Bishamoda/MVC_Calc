using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCore.Models
{
    public class Calculation
    {
        public double Number1 { get; set; }
        public double Number2 { get; set; }
        public char Op { get; set; }
        public double Result { get; set; }
    }
}
