using Xunit;

namespace Calculator {
    public class CalculatorTests {

        [Fact]
        public void AddPositiveNumbers() {
            var calculatorInstance = new Calculator();
            var a = 3m;
            var b = 2m;

            Assert.Equal(5m, calculatorInstance.Add(a, b));
        }
        [Fact]
        public void AddNegativeNumbers() {
            var calculatorInstance = new Calculator();
            var a = -3m;
            var b = 2m;

            Assert.Equal(-1m, calculatorInstance.Add(a, b));
        }
        [Fact]
        public void AddDecimalNumbers() {
            var calculatorInstance = new Calculator();
            var a = 3.5m;
            var b = 4.5m;

            Assert.Equal(8m, calculatorInstance.Add(a, b));
        }
        [Fact]
        public void SubtractPositiveNumbers() {
            var calculatorInstance = new Calculator();
            var a = 2m;
            var b = 3m;

            Assert.Equal(-1m, calculatorInstance.Subtract(a, b));
        }
        [Fact]
        public void SubtractNegativeNumbers() {
            var calculatorInstance = new Calculator();
            var a = -2m;
            var b = -3m;

            Assert.Equal(1m, calculatorInstance.Subtract(a, b));
        }
        [Fact]
        public void SubtractDecimalNumbers() {
            var calculatorInstance = new Calculator();
            var a = 3.5m;
            var b = 4.5m;

            Assert.Equal(-1m, calculatorInstance.Subtract(a, b));
        }
        [Fact]
        public void MultiplyPositiveNumbers() {
            var calculatorInstance = new Calculator();
            var a = 2m;
            var b = 3m;

            Assert.Equal(6m, calculatorInstance.Multiply(a, b));
        }
        [Fact]
        public void MultiplyNegativeNumbers() {
            var calculatorInstance = new Calculator();
            var a = -2m;
            var b = -3m;

            Assert.Equal(6m, calculatorInstance.Multiply(a, b));
        }
        [Fact]
        public void MultiplyDecimalNumbers() {
            var calculatorInstance = new Calculator();
            var a = 3.0m;
            var b = 4.0m;

            Assert.Equal(12m, calculatorInstance.Multiply(a, b));
        }
        [Fact]
        public void DividePositiveNumbers() {
            var calculatorInstance = new Calculator();
            var a = 18m;
            var b = 3m;

            Assert.Equal(6m, calculatorInstance.Divide(a, b));
        }
        [Fact]
        public void DivideNegativeNumbers() {
            var calculatorInstance = new Calculator();
            var a = -6m;
            var b = -3m;

            Assert.Equal(2m, calculatorInstance.Divide(a, b));
        }
        [Fact]
        public void DivideDecimalNumbers() {
            var calculatorInstance = new Calculator();
            var a = 12.0m;
            var b = 4.0m;

            Assert.Equal(3m, calculatorInstance.Divide(a, b));
        }
        [Fact]
        public void ExponentPositiveNumbers() {
            var calculatorInstance = new Calculator();
            var a = 2m;
            var b = 3m;

            Assert.Equal(8m, calculatorInstance.Exponential(a, b));
        }
        [Fact]
        public void ExponentNegativeNumbers() {
            var calculatorInstance = new Calculator();
            var a = -2m;
            var b = -3m;

            Assert.Equal(-0.125m, calculatorInstance.Exponential(a, b));
        }
        [Fact]
        public void ExponentDecimalNumbers() {
            var calculatorInstance = new Calculator();
            var a = 2.0m;
            var b = 4.0m;

            Assert.Equal(16m, calculatorInstance.Exponential(a, b));
        }
    }
}
