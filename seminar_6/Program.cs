Console.Write("Выберите номер задания от 1 до 2: ");
int Tasks = Convert.ToInt32(Console.ReadLine());
switch (Tasks)
{
    case 1:
  
     System.Console.WriteLine("Введите числа через пробел: ");
     char[] separators = new char[] {' '};
     string[] numbers = Console.ReadLine()!.Split(separators, StringSplitOptions.RemoveEmptyEntries);
     int[] numb = Array.ConvertAll(numbers, int.Parse);
     int count = 0;
     for (int i = 0; i < numb.Length; i++)
     {
        if (numb[i] > 0) count+= 1;
     }
     Console.WriteLine($"Количество положительных чисел = {count}");
     break;

    case 2:

    const int X = 0;
    const int Y = 1;

    double[] InitLine(int lineNumber)
    {
        double[] tempArray = new double[2];
        System.Console.Write($"Введите значение b{lineNumber} для {lineNumber} линии: ");
        tempArray[X] = Convert.ToDouble(Console.ReadLine());
        System.Console.Write($"Введите значение k{lineNumber} для {lineNumber} линии: ");
        tempArray[Y] = Convert.ToDouble(Console.ReadLine());
        return tempArray;
    }

    double[] FindCoordinates(double[] arg1, double[] arg2)
    {
        double[] coordinates = new double[2];
        coordinates[X] = -(arg1[0] - arg2[0]) / (arg1[1] - arg2[1]);
        coordinates[Y] = arg1[1] * coordinates[X] + arg1[0];
        return coordinates;
    }

    bool Validation(double[] arg1, double[] arg2)
    {
        if (arg1[0] == arg2[0])
        {
            if (arg1[1] == arg2[1])
            {
                System.Console.WriteLine("Прямые совпадают.");
                return false;
            }
            else
            {
                System.Console.WriteLine("Прямые параллельны.");
                return false;
            }
        }
        return true;
    }

    double[] line1 = InitLine(1);
    double[] line2 = InitLine(2);
    if (Validation(line1, line2))
    {
        double[] crossCoordinates = FindCoordinates(line1, line2);
        System.Console.WriteLine($"Линии пересекаются в точке ({crossCoordinates[X]};{crossCoordinates[Y]})");
    }
    break;
}