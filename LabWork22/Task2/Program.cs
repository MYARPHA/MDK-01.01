internal class Program
{
    static async Task Main(string[] args)
    {
        var results = await Task.WhenAll
            (
                Task.Run(() => GetPower(2, 1)),
                Task.Run(() => GetPower(2, 2)),
                Task.Run(() => GetPower(2, 3))
            );
        foreach (var result in results)
        {
            Console.WriteLine(result);
        }
        Console.WriteLine();

        await GetExpressionAsync(2, 1, 3, 5, 10, 1, 5, 2);
    }

    static async Task GetExpressionAsync(double x1, int a1, double x2, int a2, double x3, int a3, double x4, int a4)
    {
        Console.WriteLine(await Task.Run(() => GetPower(x1, a1) + GetPower(x2, a2)) / (GetPower(x3, a3) - GetPower(x4, a4)));
    }

    static double GetPower(double number, double power)
    {
        double result = 1;
        for (int i = 0; i < power; i++)
            result *= number;
        return result;
    }
}

