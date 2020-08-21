
```csharp
using System;

 
namespace MathMachine
{
    public class CalculatorService
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
 
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Divide(int a, int b)
        {
            if (b.Equals(0)) throw new DivideByZeroException();

            return a / b;
        }
    }
}
```