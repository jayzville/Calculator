using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Calculator {
    public class Calculator {

        public decimal ValueInMemory { get; set; }
        public bool UsingCalc { get; set; } = true;
        public int ContinueOperation { get; set; } = 1;

        public decimal Add(decimal a, decimal b) {
            return a + b;
        }
        public decimal Subtract(decimal a, decimal b) {
            return a - b;
        }
        public decimal Multiply(decimal a, decimal b) {
            return a * b;
        }
        public decimal Divide(decimal a, decimal b) {
            return a / b;
        }
        public decimal Exponential(decimal a, decimal b) {
            return (decimal)Math.Pow((double)a, (double)b);
        }
    }
}
