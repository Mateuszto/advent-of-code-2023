
string inputPath = "../../../input.txt";
long total = 0;

try
{
    if (File.Exists(inputPath))
    {
        string[] lines = File.ReadAllLines(inputPath);

        foreach (string line in lines)
        {
            int firstDigit = line.First(line => char.IsDigit(line)) - '0';
            int lastDigit = line.Last(line => char.IsDigit(line)) - '0';

            var fullNumber = firstDigit * 10 + lastDigit;
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