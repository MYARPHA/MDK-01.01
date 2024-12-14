internal class Program
{
    static async Task Main(string[] args)
    {
        var filename = "1.txt";
        var filename1 = "2.txt";
        var filename2 = "3.txt";
        Task task1 = ReadFileAsync(filename);
        Task task2 = ReadFileAsync(filename1);
        Task task3 = ReadFileAsync(filename2);
        await Task.WhenAll(task1, task2, task3);
    }

    static async Task ReadFileAsync(string fileName)
    {
        using (StreamReader reader = new(fileName, true))
        {
            string line;
            Console.WriteLine("Чтение из файла начато");
            while ((line = await reader.ReadLineAsync()) != null)
            {
                Console.WriteLine($"{fileName}: {line}");
            }
            Console.WriteLine("Чтение из файла закончено");
        }
    }
}

