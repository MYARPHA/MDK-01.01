Console.WriteLine("Введите имя файла: ");
var filename = Console.ReadLine();

if (File.Exists(filename))
    Console.WriteLine("Файл открыт на дозапись");
else
    Console.WriteLine($"Файл с названием {filename} создан");

string text;
while (true)
{
    text = Console.ReadLine();
    if (text != "end")
        File.AppendAllText(filename, $"{Environment.NewLine}{text}");
}