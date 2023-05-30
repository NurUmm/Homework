Console.Write("Выберите номер задания от 1 до 3: ");
int X = Convert.ToInt32(Console.ReadLine());
switch (X)
{
    case 1:
     System.Console.WriteLine("\n Количество четных чисел в массиве.");
     int length = Prompt("Введите длину массива: ");
     int min = 99;
     int max = 999;
     Console.WriteLine();
     int[] array = GenerateArray(length, min, max);
     int count = 0;
     for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0) count ++;
        }
     PrintArray(array);
     Console.WriteLine($" -> {count}");

    break;
     
    case 2:
     System.Console.WriteLine("\n Сумма элементов, стоящих на нечетных позициях.");
     int Length = Prompt("Введите длинну: ");
     int minValue = Prompt("Введите минимальное значение: ");
     int maxValue = Prompt("Введите максимальное значение: ");
     int[] numbers = new int[Length];
     Random random = new Random();
     for (int i = 0; i < numbers.Length; i++)
     {
        numbers[i] = random.Next(minValue, maxValue);
     }
     int coun = 0;
     for (int i = 1; i < numbers.Length; i=i+2)
     {
        coun += numbers[i];
     }
     PrintArray(numbers);
     Console.WriteLine($" -> {coun}");
     break;

     case 3:
     System.Console.WriteLine("\n Разность Макс и Мин значения.");
     double[] number = new double[5];
     Random rand = new Random();
     for(int i = 0; i < number.Length; i++)
        {
            number[i] = Math.Round((rand.NextDouble() * 10 - 5), 2);
        }
     double maxValue_ = number.Max();
     System.Console.WriteLine($"Max = {maxValue_}");
     double minValue_ = number.Min();
     System.Console.WriteLine($"Min = {minValue_}");
     double result = Math.Round((maxValue_ - minValue_), 2);

    Console.WriteLine($"{String.Join(",", number)} -> Результат: {result})");

     break;

}



 int Prompt(string message)
      {
        Console.Write(message);
        int result = Convert.ToInt32(Console.ReadLine());
        return result;
      }

     int[] GenerateArray(int Length, int minValue, int maxValue)
      {
        int[] array = new int[Length];
        Random random = new Random();
        for (int i = 0; i < Length; i++)
        {
            array[i] = random.Next(minValue, maxValue + 1);

        }
        return array;
      }
 void PrintArray(int[] array)
     {
        Console.Write("[");
        for (int i = 0; i < array.Length - 1; i++)
        {
            Console.Write($"{array[i]}, ");
        }
        Console.Write($"{array[array.Length - 1]}");
        Console.Write("]");
     }

    