string inputPath = "../../../input.txt";

const int redMax = 12;
const int greenMax = 13;
const int blueMax = 14;

long total = 0;

try
{
    if (File.Exists(inputPath))
    {
        string[] lines = File.ReadAllLines(inputPath);

        foreach (string line in lines)
        {
            var gameInfo = line.Split(':');
            var gameId = int.Parse(gameInfo[0].Split(' ')[1]);
            var rounds = gameInfo[1].Split(';', StringSplitOptions.TrimEntries);
            bool isGameValid = true;
            foreach (var round in rounds)
            {
                var colorInfos = round.Split(',', StringSplitOptions.TrimEntries);
                foreach (var color in colorInfos)
                {
                    var colorInfo = color.Split(' ');
                    var colorCount = int.Parse(colorInfo[0]);
                    var colorName = colorInfo[1];
                    switch (colorName)
                    {
                        case "red":
                            if (colorCount > redMax)
                            {
                                isGameValid = false;
                            }
                            break;
                        case "green":
                            if (colorCount > greenMax)
                            {
                                isGameValid = false;
                            }
                            break;
                        case "blue":
                            if (colorCount > blueMax)
                            {
                                isGameValid = false;
                            }
                            break;
                    }
                }

                if (!isGameValid)
                {
                    break;
                }
            }
            if (isGameValid)
            {
                total += gameId;
            }
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