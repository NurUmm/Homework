﻿// Console.WriteLine("Введите 3х значное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num < 100 || num > 999) Console.WriteLine("Вы ввели неверное значение.");
// string sometext = num.ToString();
// Console.WriteLine(sometext[1]);


// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num < 99) Console.WriteLine("Нет третьей цифры.");
// else
// {
//     string result = num.ToString();
//     Console.WriteLine(result[2]);
// }

Console.WriteLine("Введите число дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num <= 7)
{
    if (num <= 5) Console.WriteLine("Нет");
if (num > 5 && num < 8) 
    {
        Console.WriteLine("Да.");
    }
}
else Console.WriteLine("В неделе только 7 дней");