Console.Write("Выберите номер задания от 1 до 3: ");
int X = Convert.ToInt32(Console.ReadLine());
switch (X)
{
    case 1:
     int values()
    {
        Console.WriteLine("Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        return num;
    }

     int step(int firstNum, int secondNum)
     {
     int step = 1;
     for (int i = 0; i < secondNum; i++)
     {
        step *= firstNum;
     }
     return step;
     }

     int firstNum = values();
     int secondNum = values();

     Console.WriteLine("Ваш результат: " + step(firstNum, secondNum));
    break;

    case 2:
     
     int Help(string message)
     {
        Console.WriteLine(message);
        int variable = Convert.ToInt32(Console.ReadLine());
        return variable;
     }
     
     int SumAllDigit(int num)
     {
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num = num / 10;
        }
        return sum;
     } 

     int num = Help("Введите число: ");
     Console.WriteLine("Сумма всех чисел: " + SumAllDigit(num));
    break;

    case 3:
     
     int Help_(string message)
     {
        Console.Write(message);
        int variable = Convert.ToInt32(Console.ReadLine());
        return variable;
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
        Console.WriteLine("]");
     }

     int length = Help_("Введите длину массива: ");
     int min = Help_("Начальное значение, для диапозона случайного числа: ");
     int max = Help_("Конечное значение, для диапозона случайного числа: ");
     Console.WriteLine();
     int[] array = GenerateArray(length, min, max);
     PrintArray(array);
     Console.WriteLine();

     break;
}