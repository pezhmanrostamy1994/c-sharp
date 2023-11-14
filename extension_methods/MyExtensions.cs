namespace MyNameSpace;
public static class MyExtensions
{
    public static string FirstHalf(this string str)
    {
        return str.Substring(0, str.Length / 2);
    }
}
