using static Utils;

class Day2 : Day
{   
    protected override List<string> PuzzleInput { get; } = GetPuzzleInput(2, true);
    protected override void Solve()
    {
        long answer2 = 0;

        foreach (string range in PuzzleInput)
        {
            string[] split = range.Split('-');
            long start = long.Parse(split[0]);
            long end = long.Parse(split[1]);

            for (long i = start; i <= end; i++)
            {
                string str = i.ToString();
                int half = str.Length / 2;
                string left = str[..half];
                string right = str[half..];
                
                if (left == right)
                {
                    answer2 += i;
                }
            }
        }

        Solution = (answer2.ToString(), "");
    }
    protected void Solve_Old()
    {
        long answer1 = 0;

        foreach (string range in PuzzleInput)
        {
            string[] split = range.Split('-');
            long start = long.Parse(split[0]);
            long end = long.Parse(split[1]);

            for (long i = start; i <= end; i++)
            {
                string str = i.ToString();

                int half = str.Length / 2;
                string left = str[..half];
                string right = str[half..];
                
                if (left == right)
                {
                    answer1 += i;
                }
            }
        }

        Solution = (answer1.ToString(), "");
    }
}