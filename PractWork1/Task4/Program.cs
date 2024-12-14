Console.WriteLine("Ведите путь к папке: ");
var directoryName = Console.ReadLine();
Console.WriteLine("Введите часть имени файла: ");
var filename = Console.ReadLine();
DirectoryInfo directory = new (directoryName);
var files = directory.GetFiles();
foreach (var file in files)
{
    Console.WriteLine(file.Name);
    Console.WriteLine(file.Length);
}