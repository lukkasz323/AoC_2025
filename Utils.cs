using System.Text;

class Utils
{
    public static void Print(IEnumerable<string> items)
    {
        Console.Write(string.Join(", ", items));
    }

    public static void Print(string text)
    {
        Console.WriteLine(text);
    }

    public static int Modulo(int value, int modulus)
    {
        return ((value % modulus) + modulus) % modulus;
    }

}