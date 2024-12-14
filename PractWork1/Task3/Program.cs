Console.WriteLine("Введите имя текстового файла: ");
var filename = Console.ReadLine();
Console.WriteLine("Введите текст из файла: ");
string searchText = Console.ReadLine();

if (File.Exists(filename))
{
    Console.WriteLine("Файл существует");
    string[] lines = File.ReadAllLines(filename);

    for (int i = 0; i < lines.Length; i++)
    {
        if (lines[i].Contains(searchText))
        {
            Console.WriteLine($"{i + 1}: {lines[i]}");
        }
    }
}
else
{
    Console.WriteLine("Файл не существует");
}




