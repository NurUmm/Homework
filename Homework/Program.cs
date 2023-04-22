Console.Write("Выберите номер задания от 1 до 4: ");
int X = Convert.ToInt32(Console.ReadLine());
switch (X)
{
    case 1:
     Console.WriteLine("\n Задание 1. Проверка наибольшего значения из 2х.");
     Console.Write("Введите первое число: ");
     int a = Convert.ToInt32(Console.ReadLine());
     Console.Write("Введите второе число: ");
     int b = Convert.ToInt32(Console.ReadLine());
     if (a > b) Console.WriteLine($"Число {a} наибольшее.");
     else Console.WriteLine($"Число {b} наибольшее.");
    break;

    case 2:
     Console.Write("\n Задание 2. Максимальное из трех чисел.");
     Console.Write("Введите первое число: ");
     int c = Convert.ToInt32(Console.ReadLine());
     Console.Write("Введите второе число: ");
     int d = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Введите третье число: ");
     int e = Convert.ToInt32(Console.ReadLine());
     
     if (c>d && d>e) Console.WriteLine($"Наибольшее число {c}.");
     else if (c<d && d>e) Console.WriteLine($"Наибольшее число {d}.");
     else if (c<d && d<e) Console.WriteLine($"Наибольшее число {e}.");
     break;

      case 3:
     Console.WriteLine("Среда");
     break;
     case 4:
     Console.WriteLine("Четверг");
     break;
     case 5:
     Console.WriteLine("Пятница");
     break;
     case 6:
     Console.WriteLine("Суббота");
     break;
     case 7:
     Console.WriteLine("Воскресенье");
     break;
     default:
     Console.WriteLine("Error");
     break;
}