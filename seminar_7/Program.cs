
Console.Write("Выберите номер задания от 1 до 3: ");
int task = Convert.ToInt32(Console.ReadLine());
switch (task)
{
    case 1:
        double[,] array = new double[3, 4];
        Random rand = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = Math.Round(rand.NextDouble() * 10, 2);
                Console.Write(array[i, j] + " | ");
            }
            Console.WriteLine();
        }

        break;

    case 2:
        Console.Write("Введите число: ");
        int userEnter = Convert.ToInt32(Console.ReadLine());

        int[,] array2 = new int[3, 4];
        Random random = new Random();
        bool f = false;
        for (int i = 0; i < array2.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                array2[i, j] = random.Next(1, 10);
                if (userEnter == array2[i, j]) f = true;
                Console.Write(array2[i, j] + " | ");
            }
            Console.WriteLine();
        }
        if (f)
        {
            System.Console.WriteLine($"\n {userEnter} -> есть в массиве.");
        }
        else System.Console.WriteLine($"\n {userEnter} -> нет в массиве.");

    break;

    case 3:
        int[,] array3 = new int[3, 4];
        Random random3 = new Random();
        int[] summ = new int[4];
        for (int i = 0; i < array3.GetLength(0); i++)
        {
            for (int j = 0; j < array3.GetLength(1); j++)
            {
                array3[i, j] = random3.Next(1, 10);
                Console.Write(array3[i, j] + " | ");
                summ[j] += array3[i, j];
                
            }
            Console.WriteLine();
        }
        foreach (double elem in summ)
        {
            double result = elem/3;
            double finish = Math.Round(result, 1);
            System.Console.Write($"{finish} | ");
            
        }
        System.Console.Write("<- Ср.ариф");

    break;
}