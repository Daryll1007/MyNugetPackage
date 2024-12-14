namespace MyNugetPackage
{
    public class MathOperations
    {
        // Add two numbers
        public double Add(double a, double b)
        {
            return a + b;
        }

        // Subtract two numbers
        public double Subtract(double a, double b)
        {
            return a - b;
        }

        // Multiply two numbers
        public double Multiply(double a, double b)
        {
            return a * b;
        }

        // Divide two numbers
        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Division by zero is not allowed.");
            }
            return a / b;
        }
    }
}
