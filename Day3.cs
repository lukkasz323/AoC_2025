using System.Globalization;
using static Utils;

class Day3 : Day
{   
    protected override List<string> PuzzleInput { get; } = GetPuzzleInput(3);
    protected override void Solve()
    {
        int totalJoltage = 0;

        foreach (string bank in PuzzleInput)
        {
            (int Value, int Index) highestJolt_1 = (0, 0);
            (int Value, int Index) highestJolt_2 = (0, 0);

            for (int i = 0; i < bank.Length - 1; i++)
            {
                int digit = (int)char.GetNumericValue(bank[i]);

                if (digit > highestJolt_1.Value)
                {
                    highestJolt_1 = (digit, i);
                }
            }
            for (int i = highestJolt_1.Index + 1; i < bank.Length; i++)
            {
                int digit = (int)char.GetNumericValue(bank[i]);

                if (digit > highestJolt_2.Value)
                {
                    highestJolt_2 = (digit, i);
                }
            }

            totalJoltage += int.Parse(highestJolt_1.Value.ToString() + highestJolt_2.Value.ToString());
        }

        Solution = ($"{totalJoltage}", "");
    }
}