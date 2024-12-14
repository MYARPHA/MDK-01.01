Console.WriteLine("Введите имя файла: ");
var filename = Console.ReadLine();

if (File.Exists(filename))
{
    Console.WriteLine("Файл существует! Текст в файле: ");
    Console.WriteLine(File.ReadAllText(filename));
}
else
{
    Console.WriteLine("Файл не существует");
}
