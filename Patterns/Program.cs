// 
// Вещественный массив
// диапозон min + Random.NextDouble() * (max - min);

// int[,] GenerateArray(int rows, int columns)
// {
//     int[,] temp2dArray = new int[rows, columns];
//     for (int i = 0; i < temp2dArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < temp2dArray.GetLength(1); j++)
//         {
//             temp2dArray[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return temp2dArray;
// }

// Console.Write("Выберите номер задания от 1 до 3: ");
// int X = Convert.ToInt32(Console.ReadLine());
// switch (X)
// {
//     case 1:

//     break;           swich case

//     case 2:

//     break;
// }


// Приглашение ко вводу
// int Prompt(string message)
//      {
//         Console.Write(message);
//         int result = Convert.ToInt32(Console.ReadLine());
//         return result;
//      }

// Генерация массива случайными числами 
// int[] GenerateArray(int Length, int minValue, int maxValue) 
//       {
//         int[] array = new int[Length];
//         Random random = new Random();
//         for (int i = 0; i < Length; i++)
//         {
//             array[i] = random.Next(minValue, maxValue + 1);

//         }
//         return array;
//       }








//       Console.WriteLine("Введите пожалуйста число которое будет пятизначным");
// int a =Convert.ToInt32(Console.ReadLine());


// Console.WriteLine(a/10000+ " "); // Первое значение

// int b = a / 1000 % 10;
// Console.WriteLine(c+ " "); // Второе значение

// int c = a % 100/10;
// Console.WriteLine(b+ " ");   // четвертое значение

// Console.Write(a%10+ " "); //  Последнее значение

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать 
// треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.



// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// int c = Convert.ToInt32(Console.ReadLine());

// void treug(int a, int b, int c)
// {
//     if (a < c + b && b < a + c && c < a + b)
//         System.Console.WriteLine("Треугольник существует");
//     else System.Console.WriteLine("Такого треугольника нет");
// }

// treug(a,b,c);

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10



// System.Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string stroka = "";
// while (num > 0)
//     {
//         stroka = num % 2 + stroka;
//         num = num / 2; 
//     }
// System.Console.WriteLine(stroka);


// Решение в группах задач:
// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
//  Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
//  Задача 45: Напишите программу, которая будет создавать копию 
//  заданного массива с помощью поэлементного копирования.

System.Console.WriteLine("Введите число: ");
int feb = Convert.ToInt32(Console.ReadLine());

int[] mass = new int[feb];
mass[0] = 0;
mass[1] = 1;
int i = 2;
Console.Write($"{mass[0]}{mass[1]}");
while (i < feb)
{
    mass[i] = mass[i-2] + mass[i-1];
    Console.Write(mass[i]);
    i++;  
}
