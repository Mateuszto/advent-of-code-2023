string inputPath = "../../../input.txt";
long total = 0;

var allDigits = new Dictionary<string, int>()
{
    { "one", 1 },
    { "two", 2 },
    { "three", 3 },
    { "four", 4 },
    { "five", 5 },
    { "six", 6 },
    { "seven", 7 },
    { "eight", 8 },
    { "nine", 9 },
};

for (int i = 1; i < 10; i++)
{
    allDigits.Add(i.ToString(), i);
}

try
{
    if (File.Exists(inputPath))
    {
        string[] lines = File.ReadAllLines(inputPath);

        foreach (string line in lines)
        {
            var firstIndex = line.Length;
            var lastIndex = -1;
            var firstValue = 0;
            var lastValue = 0;

            foreach (var digit in allDigits)
            {
                var index = line.IndexOf(digit.Key);
                if (index == -1)
                {
                    continue;
                }

                if (index < firstIndex)
                {
                    firstIndex = index;
                    firstValue = digit.Value;
                }

                index = line.LastIndexOf(digit.Key);

                if (index > lastIndex)
                {
                    lastIndex = index;
                    lastValue = digit.Value;
                }
            }

            var fullNumber = firstValue * 10 + lastValue;
            total += fullNumber;
        }
    }
    else
    {
        Console.WriteLine("The file does not exist.");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}
finally
{
    Console.WriteLine(total);
}