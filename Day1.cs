using static Utils;

class Day1 : Day
{   
    public override void Solve()
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

        Solution.Item1 = zeroes.ToString();
    }

    public void Solve_Old()
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

        Solution.Item1 = zeroes.ToString();
    }
}