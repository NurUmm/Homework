Console.WriteLine("Программа, которая выводит значения меньше или равное 3.");
Console.Write("Введите через пробел значения: ");
char[] separator = new char[] {' '};
string[] st1 = Console.ReadLine()!.Split(separator, StringSplitOptions.RemoveEmptyEntries);
Console.Write(string.Join(", ", st1));
Console.Write(" ->");
for (int i = 0; i < st1.Length; i++)
{
    if (st1[i].Length <= 3) Console.Write($" {st1[i]},");
}


