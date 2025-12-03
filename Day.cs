using static Utils;

abstract class Day
{
    protected (string, string) Solution = ("", "");

    protected bool AltInputStyle { get; init; } = true;
    protected abstract List<string> PuzzleInput { get; }

    protected abstract void Solve();

    public static List<string> GetPuzzleInput(int dayNumber, bool altInputStyle = false)
        {
            try
            {
                Environment.CurrentDirectory = AppContext.BaseDirectory;
                using StreamReader text = File.OpenText(@$"{Environment.CurrentDirectory}\PuzzleInputs\{dayNumber}.txt");

                if (altInputStyle)
                {
                    return [.. text.ReadToEnd().Split(",")];
                }
                else
                {
                    return [.. text.ReadToEnd().Split("\r\n")];
                }
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