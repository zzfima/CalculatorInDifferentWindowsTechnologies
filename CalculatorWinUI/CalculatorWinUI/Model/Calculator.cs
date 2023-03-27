namespace CalculatorWinUI.Model
{
    public class Calculator : ICalculator
    {
        public int Add(int a, int b) => a + b;

        public double Devide(int a, int b) => a / b;

        public int Minus(int a, int b) => a - b;

        public int Multiply(int a, int b) => a * b;
    }
}
