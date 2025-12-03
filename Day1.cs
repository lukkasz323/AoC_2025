using static Utils;

class Day1 : Day
{   
    protected override List<string> PuzzleInput { get; } = GetPuzzleInput(1);
    protected override void Solve()
    {
        Solution = (Solve_Part1(), Solve_Part2());
    }

    string Solve_Part1()
    {
        int zeroes = 0;
        int dial = 50;

        foreach (string row in PuzzleInput)
        {
            int distance = int.Parse(row.Substring(1));

            if (row[0] == 'L')
            {
                dial -= distance;
            }
            else
            {
                dial += distance;
            }

            dial = Modulo(dial, 100);

            if (dial == 0)
            {
                ++zeroes;
            }
        }

        return zeroes.ToString();
    }

    string Solve_Part2()
    {
        int zeroes = 0;
        int dial = 50;

        foreach (string row in PuzzleInput)
        {
            int distance = int.Parse(row.Substring(1));

            for (int i = 0; i < distance; i++)
            {
                if (row[0] == 'L')
                {
                    --dial;
                }
                else
                {
                    ++dial;
                }
                dial = Modulo(dial, 100);

                if (dial == 0)
                {
                    ++zeroes;
                }
            }
        }

        return zeroes.ToString();
    }
}