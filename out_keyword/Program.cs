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