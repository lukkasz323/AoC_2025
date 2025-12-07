using System.Globalization;
using System.Text;
using static Utils;

class Day3 : Day
{   
    protected override List<string> PuzzleInput { get; } = GetPuzzleInput(3);

    protected override void Solve()
    {
        long totalJoltage = 0;

        foreach (string bank in PuzzleInput)
        {
            SortedDictionary<int, int> battery = new();

            for (int iBattery = 0; iBattery < 12; iBattery++)
            {
                // Find highest digit in a onoccupied position and assign it
                (int Index, int Value) highestDigit = default;
                for (int i = 0; i < bank.Length; i++)
                {
                    // --- Skip occupied positions
                    if (battery.ContainsKey(i)) { 
                        continue;
                    }

                    // --- Find
                    int digit = (int)char.GetNumericValue(bank[i]);
                    if (digit > highestDigit.Value)
                    {
                        highestDigit.Index = i;
                        highestDigit.Value = digit;
                    }
                }
                // --- Assign
                battery[highestDigit.Index] = highestDigit.Value;
            }

            StringBuilder batteryStringBuilder = new();
            foreach (int jolt in battery.Values)
            {
                batteryStringBuilder.Append(jolt);
            }
            totalJoltage += long.Parse(batteryStringBuilder.ToString());
        }

        Solution = ("todo", totalJoltage.ToString());
    }

    protected void Solve_Old()
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