class Program
{
    static void ChangeValue(ref int number)
    {
        number = 10; // تغییر مقدار پارامتری که به عنوان مرجع داده شده است
    }

    static void Main(string[] args)
    {
        int value = 5;
        Console.WriteLine($"Before method call: {value}");

        // فراخوانی متد با استفاده از ref
        ChangeValue(ref value);

        Console.WriteLine($"After method call: {value}"); // خروجی: 10
    }
}
