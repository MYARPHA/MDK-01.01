internal class Program
{
    static async Task Main(string[] args)
    {
        // последовательный асинхорнный
        await Task.Run(() => PrintPower(2, 3));
        await Task.Run(() => PrintPower(2, 4));
        await Task.Run(() => PrintPower(2, 5));

        // параллельный асинхронный
        Task task1 = Task.Run(() => PrintPower(2, 1));
        Task task2 = Task.Run(() => PrintPower(2, 6));
        Task task3 = Task.Run(() => PrintPower(2, 7));

        await Task.WhenAll(task1, task2, task3);
    }

    static void PrintPower(double number, int power)
    {
        double result = 1;
        for (double i = 0; i < power; i++)
            result *= number;
        Console.WriteLine($"{number}^{power} = {result}");
    }
}
