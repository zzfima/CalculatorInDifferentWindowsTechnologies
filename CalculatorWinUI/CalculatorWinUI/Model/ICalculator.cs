namespace CalculatorWinUI.Model
{
    public interface ICalculator
    {
        int Add(int a, int b);
        int Minus(int a, int b);
        int Multiply(int a, int b);
        double Devide(int a, int b);
    }
}