namespace MyNameSpace;
class Program
{

    static void Main(string[] args)
    {
        string myString = "Hello, World!";
        string firstHalf = myString.FirstHalf(); //Using Extension methods
        Console.WriteLine(firstHalf); // Output: Hello

    }
}