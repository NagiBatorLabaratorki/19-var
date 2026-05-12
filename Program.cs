using System.IO;

string[] lines = new string[5];

Console.WriteLine("Введите 5 строк текста:");

for (int i = 0; i < lines.Length; i++)
{
    Console.Write($"Строка {i + 1}: ");
    lines[i] = Console.ReadLine();
}

File.WriteAllLines("output.txt", lines);

Console.WriteLine("\nФайл output.txt успешно создан!");
Console.WriteLine("Содержимое файла:");

string[] savedLines = File.ReadAllLines("output.txt");
foreach (string line in savedLines)
{
    Console.WriteLine(line);
}
