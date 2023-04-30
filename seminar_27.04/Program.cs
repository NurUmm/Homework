Console.Write("\n Выберите номер задания от 1 до 3: ");
int X = Convert.ToInt32(Console.ReadLine());
switch (X)
{
    case 1:
        Console.WriteLine("Введите 5ти значное число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 9999 && num < 100000) {
            string poli = num.ToString();
            if (poli[0] == poli[4] && poli[1]==poli[3]) {
                Console.WriteLine("Число является палиндромом.");
            }
            else {
                Console.WriteLine("Число не является палиндромом.");
            }
        }
        else {
            System.Console.WriteLine("Некорректный ввод. Введите 5ти значное число.");
        }
    break;

    case 2:

        Console.WriteLine("Введите координаты первой точки: ");
        
        int[] FirstPoint = new int[3];
        for (int i = 0; i < FirstPoint.Length; i++)
            FirstPoint[i] = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите координаты второй точки: ");
       
        int[] SecondPoint = new int[3];
        for (int i = 0; i < SecondPoint.Length; i++)
            SecondPoint[i] = Convert.ToInt32(Console.ReadLine());
        
        double a = Math.Pow(SecondPoint[0] - FirstPoint[0], 2);
        double b = Math.Pow(SecondPoint[1] - FirstPoint[1], 2);
        double c = Math.Pow(SecondPoint[2] - FirstPoint[2], 2);

        double result = Math.Round(Math.Sqrt(a + b + c), 2);
        Console.WriteLine("Расстояние между точками: " + result);        
    break;

    case 3:
        Console.WriteLine("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        for (int i=1; i<number; i++) {
            Console.Write(Math.Pow(i, 3)+ " ");
        }
    break;
}