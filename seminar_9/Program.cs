int task = Prompt("Введите номер задания от 1 до 4: ");
switch (task)
{

    case 1:
        int num = Prompt("Введите число: ");
        string DigitRev( int num, int last = 1)
        {
            if (num == last)
            {
                return num.ToString();
            }
            return($"{num}, {DigitRev(num - 1, last)}.");
        }
        System.Console.WriteLine($"{num} -> {DigitRev(num)}");

    break;

    case 2:
        // Задайте значения M и N. Напишите программу, которая найдёт сумму 
        // натуральных элементов в промежутке от M до N.

        // M = 1; N = 15 -> 120
        // M = 4; N = 8. -> 30

        int num1 = Prompt("Введите первое число: ");
        int num2 = Prompt("Введите второе число: ");
        
        int SumAllDigit (int num1, int num2)
        {
            // int summ = 0;
            if (num1 == num2)
            {
                return num2; 
            }
            return num1 + SumAllDigit(num1+1, num2);
            
        }
        System.Console.WriteLine(SumAllDigit(num1, num2));
    break;

    case 3:
       
        int numM = Prompt("Введите первое число: ");
        int numN = Prompt("Введите второе число: ");

        int akk(int numM, int numN)
        {
            if (numM == 0) return numN+1;

            else if (numM > 0 && numN ==0) return akk(numM - 1, numN = 1);
            
            else return akk(numM-1, akk(numM, numN-1)); 
        }

        Console.WriteLine($"Результат: {akk(numM, numN)}");
        

    break;
}

int Prompt(string message)
     {
        Console.Write(message);
        int result = Convert.ToInt32(Console.ReadLine());
        return result;
     }
