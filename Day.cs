using static Utils;

abstract class Day
{
    protected (string, string) Solution = ("", "");

    public List<string> PuzzleInput { get; }
    public Day()
    {
        PuzzleInput = GetPuzzleInput(1);
    }

    abstract protected void Solve();

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

    public void Run()
    {
        Solve();
        Print("Part 1: " + Solution.Item1);
        Print("Part 2: " + Solution.Item2);
    }
}