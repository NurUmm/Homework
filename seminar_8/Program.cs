Console.Write("Выберите номер задания от 1 до 4: ");
int taskNumber = int.Parse(Console.ReadLine()!);
switch (taskNumber)

{
    case 1:
        System.Console.Write("Введите количество строк: ");
        int arrayH = int.Parse(Console.ReadLine()!);
        System.Console.Write("Введите количество столбцов: ");
        int arrayW = int.Parse(Console.ReadLine()!);
        int[,] array = new int[arrayH, arrayW];
        System.Console.WriteLine();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j] = new Random().Next(1,10);
                Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
        }
        System.Console.WriteLine("Сортировка по строкам: ");
        int[,] array2 = new int[arrayH, arrayW];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = j+1; k < array.GetLength(1); k++)
                if (array[i, j] < array[i, k])
                    {
                        int Temp = array[i, j];
                        array[i, j] = array[i, k];
                        array[i, k] = Temp;
                    }
                Console.Write(array[i, j] + " ");
                
            }
            System.Console.WriteLine();
        }
    break;

    case 2:
        System.Console.Write("Введите количество строк: ");
        int arrayH2 = int.Parse(Console.ReadLine()!);
        System.Console.Write("Введите количество столбцов: ");
        int arrayW2 = int.Parse(Console.ReadLine()!);
        
        int[,] arrayTwo = new int[arrayH2, arrayW2];
        int[] arrayTemp = new int[arrayH2];
        int summ = 0;
        for (int i = 0; i < arrayTwo.GetLength(0); i++)
        {
            for (int j = 0; j < arrayTwo.GetLength(1); j++)
            {
                arrayTwo[i,j] = new Random().Next(1,10);
                summ+= arrayTwo[i,j];
                arrayTemp[i] += arrayTwo[i, j];
                Console.Write(arrayTwo[i, j] + " ");
            }
            System.Console.WriteLine($" <- Сумма строки: {summ}");
            summ = 0;
            ;
        }
        
        int min = 0;
        int temp2 = arrayTemp[0];
        for (int i=0; i < arrayTemp.Length; i++)
        {
            if (temp2 > arrayTemp[i])
            {
                temp2 = arrayTemp[i];
                min = i;
            }
        }
        
        System.Console.WriteLine($"Строка с наименьшей суммой: {min+1}");
        break;

        case 3:
            int array2dH = Prompt("Введите количество столбцов: ");
            int array2dW = Prompt("Введите количество строк: ");

            int[,] array2d = GenerateArray(array2dH, array2dW);
            PrintArray(array2d);
            System.Console.WriteLine("---");
            int array2dH2 = Prompt("Введите количество столбцов: ");
            int array2dW2 = Prompt("Введите количество строк: ");
            int[,] array2d2 = GenerateArray(array2dH2, array2dW2);
            PrintArray(array2d2);
            System.Console.WriteLine("---");
            int [,] matrixRow = new int[array2d.GetLength(0), array2d2.GetLength(1)];
            if (array2d.GetLength(0) == array2d2.GetLength(1))
            { 
                for (int i = 0; i < array2d.GetLength(0); i++)
                {
                    for (int j = 0; j < array2d2.GetLength(1); j++)
                    {
                        for (int h = 0; h < array2d.GetLength(0); h++)
                        {
                        
                        matrixRow[i, j] +=  array2d[i, h] * array2d2[h,j];
                        
                        }
                    }
                }
                PrintArray(matrixRow);
            }
            else System.Console.WriteLine("Произведение невозможно.");
            
        break;

        case 4:

            int[,] matrix = new int [4,4];
            int l=1;
            for (int i=0;i<4;i++)
            {
                for (int j=0; j<4; j++)
                {
                    matrix[i,j]=0;
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----");
            for (int i=0;i<4;i++)
            {
                matrix[0,i]=l;
                l+=1;
            }
            for (int i=1;i<4;i++)
            {
                matrix[i,3]=l;
                l+=1;
            }

            for (int i=2;i>=0;i--)
            {
                matrix[3,i]=l;
                l+=1;
            }

            for (int i=2;i>=1;i--)
            {
                matrix[i,0]=l;
                l+=1;
            }

            for (int i=1;i<=2;i++)
            {
                matrix[1,i]=l;
                l+=1;
            }
            for (int i=2;i>=1;i--)
            {
                matrix[2,i]=l;
                l+=1;
            }
            
            
            for (int i=0;i<4;i++)
            {
                for (int j=0;j<4;j++)
                {
                    if (matrix[i, j] < 10) System.Console.Write($"0{matrix[i,j]} ");
                    else Console.Write(matrix[i,j]+" ");
                }
                Console.WriteLine();
            }   
            break;
}


       

int Prompt(string message)
     {
        Console.Write(message);
        int result = Convert.ToInt32(Console.ReadLine());
        return result;
     }





        int[,] GenerateArray(int rows, int columns)
        {
            int[,] temp2dArray = new int[rows, columns];
            for (int i = 0; i < temp2dArray.GetLength(0); i++)
            {
                for (int j = 0; j < temp2dArray.GetLength(1); j++)
                {
                    temp2dArray[i, j] = new Random().Next(0, 10);
                }
            }
            return temp2dArray;
        }

// int[] GenerateArray(int Length, int minValue, int maxValue)
// {
//     int[] array = new int[Length];
//     Random random = new Random();
//     for (int i = 0; i < Length; i++)
//     {
//         array[i] = random.Next(minValue, maxValue + 1);
//     }
//     return array;
// }

void PrintArray(int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
        {
            for (int b = 0; b < array.GetLength(1); b++)
            {
                Console.Write(array[a, b] + " ");
            }
            Console.WriteLine();
        }
}