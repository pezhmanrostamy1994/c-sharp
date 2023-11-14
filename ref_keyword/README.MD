## Understanding `ref`

ref is used to pass a variable by reference to methods or functions in C#.
When a variable is passed using ref, any changes made to it inside the method will affect the original variable outside the method.
The variable passed with ref must be initialized before being passed to the method.

## Example

```csharp
class Program
{
    // Example using ref
    static void ModifyValue(ref int number)
    {
        number = 20; // Changes the value of the variable passed by reference
    }

    static void Main(string[] args)
    {
        int value = 10;
        Console.WriteLine($"Before method call: {value}");

        // Calling the method using ref
        ModifyValue(ref value);

        Console.WriteLine($"After method call: {value}"); // Output: 20
    }
}
```
