# C# Extension Methods

## Overview

Extension methods in C# enable you to add additional methods to existing classes without directly modifying or inheriting from the class. These methods become accessible to all instances of the targeted class.

## Creating Extension Methods

To create an extension method:

1. **Ensure it's in a Namespace:** Extension methods must be defined inside a static class within a namespace. For example:

```csharp
namespace MyExtensionMethods
{
    public static class MyExtensions
    {
        public static string FirstHalf(this string str)
        {
            return str.Substring(0, str.Length / 2);
        }
    }
}
```

Here, we've created an extension method FirstHalf for the string class. This method divides the input string into two halves and returns the first half.

You can then use this method in your code like this:

```csharp
string myString = "Hello, World!";
string firstHalf = myString.FirstHalf(); // Using the extension method here
Console.WriteLine(firstHalf); // Output: Hello

```

Ensure to import the namespace where the extension method resides (using MyExtensionMethods;) to utilize the extension method in your code.

## Important Note

Namespace Requirement: Extension methods must be defined within a namespace. Placing them inside a static class within a namespace allows their accessibility throughout the application.
