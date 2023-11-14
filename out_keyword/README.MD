# Using `out` in C#

The `out` keyword in C# is utilized to pass output parameters to methods or functions. The concept is explained below:

## Understanding `out`

- `out` is used when we want a method or function to generate a value as output and have access to it.
- Parameters marked as `out` must be initialized inside the method before being used.
- Initial value assignment for `out` parameters is not mandatory and is done inside the method.

## Example

```csharp
class Program
{
    // Example using out
    static void Divide(int dividend, int divisor, out int quotient, out int remainder)
    {
        // Checking division by zero
        if (divisor != 0)
        {
            quotient = dividend / divisor;
            remainder = dividend % divisor;
        }
        else
        {
            quotient = 0;
            remainder = 0;
        }
    }

    static void Main(string[] args)
    {
        int dividend = 10;
        int divisor = 3;
        int resultQuotient;
        int resultRemainder;

        // Using out
        Divide(dividend, divisor, out resultQuotient, out resultRemainder);

        Console.WriteLine($"Quotient: {resultQuotient}, Remainder: {resultRemainder}");
    }
}
```
