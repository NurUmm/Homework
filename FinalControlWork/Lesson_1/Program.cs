System.Console.WriteLine("Программа, которая выводит значения меньше или равное 3.");
Console.Write("Введите через пробел значения: ");
char[] separator = new char[] {' '};
string[] st1 = Console.ReadLine()!.Split(separator, StringSplitOptions.RemoveEmptyEntries);
string[] result = new string[st1.Length];
System.Console.WriteLine();
Console.Write(string.Join(", ", st1));
Console.Write(" ->");
for (int i = 0; i < st1.Length; i++)
{
    string temp = st1[i];
    if (temp.Length <= 3) Console.Write($" {temp},");
}
System.Console.WriteLine();
System.Console.WriteLine();


