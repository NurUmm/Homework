Console.Write("\n Выберите номер задания от 1 до 4: ");
int X = Convert.ToInt32(Console.ReadLine());
switch (X)
{
    case 1:
     Console.WriteLine("\n Задание 1. Проверка наибольшего значения из 2х.");
     Console.Write("Введите первое число: ");
     int a = Convert.ToInt32(Console.ReadLine());
     Console.Write("Введите второе число: ");
     int b = Convert.ToInt32(Console.ReadLine());
     if (a > b) Console.WriteLine($"\n Число {a} наибольшее.");
     else Console.WriteLine($"Число {b} наибольшее.");
    break;

    case 2:
     Console.WriteLine("\n Задание 2. Максимальное из трех чисел.");
     Console.Write("Введите первое число: ");
     int c = Convert.ToInt32(Console.ReadLine());
     Console.Write("Введите второе число: ");
     int d = Convert.ToInt32(Console.ReadLine());
     Console.Write("Введите третье число: ");
     int e = Convert.ToInt32(Console.ReadLine());
     
     if (c>d && d>e) Console.WriteLine($"\n Наибольшее число {c}.");
     else if (c<d && d>e) Console.WriteLine($"\n Наибольшее число {d}.");
     else if (c<d && d<e) Console.WriteLine($"\n Наибольшее число {e}.");
    break;

    case 3:
     Console.WriteLine("\n Задание 3. Проверка четности чисел.");
     Console.Write("Введите число: ");
     int q = Convert.ToInt32(Console.ReadLine());
     if (q % 2 == 0) Console.WriteLine($"\n Число {q} является четным.");
     else Console.WriteLine($"\n Число {q} не является четным.");
    break;

    case 4:
     Console.WriteLine("\n Задание 4. Вывод четных чисел до числа 'X'.");
     Console.Write("Введите число: ");
     int f = Convert.ToInt32(Console.ReadLine());
     for (int i = 1; i <= f; i++)
        if (i % 2 == 0) {
            Console.Write(i);
            Console.Write(" ");
        }
    break;
}