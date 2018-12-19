using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Calculator {
    public class Calculator {

        public decimal ValueInMemory { get; set; }

        public decimal Addition(decimal arg1, decimal arg2) {
            return arg1 + arg2;
        }
        public decimal Subtract(decimal arg1, decimal arg2) {
            return arg1 - arg2;
        }
        public decimal Multiply(decimal arg1, decimal arg2) {
            return arg1 * arg2;
        }
        public decimal Divide(decimal arg1, decimal arg2) {
            return arg1 / arg2;
        }
        public decimal Exponential(decimal arg1, decimal arg2) {
           return (decimal) Math.Pow((double)arg1, (double)arg2);
        }

         
    }
}
