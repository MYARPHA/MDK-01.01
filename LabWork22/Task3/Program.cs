internal class Program
{
    static async Task Main(string[] args)
    {
        var filename = "1.txt";
        await WriteFileAsync(filename, 200000);
        Console.WriteLine("Конец программы");
    }

    static async Task WriteFileAsync(string fileName, int linesCount)
    {
        Random random = new();
        Console.WriteLine("Запись начата");
        using (StreamWriter writer = new(fileName, true))
        {
            for (int i = 1; i <= linesCount; i++)
            {
                await writer.WriteLineAsync($"Число №{i}: {random.Next()}");
            }
        }
        Console.WriteLine("Запись закончена");
    }
}

