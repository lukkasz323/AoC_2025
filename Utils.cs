using System.Text;

class Utils
{
    public static List<string> GetPuzzleInput(int dayNumber)
    {
        try
        {
            Environment.CurrentDirectory = AppContext.BaseDirectory;
            using StreamReader text = File.OpenText(@$"{Environment.CurrentDirectory}\PuzzleInputs\{dayNumber}.txt");

            return [.. text.ReadToEnd().Split("\r\n")];
        }
        catch (FileNotFoundException)
        {
            return [];
        }
    }

    public static void Print<T>(IEnumerable<T> items)
    {
        Console.Write(string.Join(", ", items));
    }
}