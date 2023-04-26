Console.Write("Выберите номер задания от 1 до 3: ");
int X = Convert.ToInt32(Console.ReadLine());
switch (X)

{ 
    case 1:
     Console.WriteLine("\n Вывод второго значения.");
     Console.Write("Введите 3х значное число: ");
     int num = Convert.ToInt32(Console.ReadLine());
     if (num < 100 || num > 1000) Console.WriteLine("Вы ввели неверное значение.");
     else {
         string sometext = num.ToString();
         Console.WriteLine(sometext[1]);   
     }  
    break;

    case 2:
     Console.WriteLine("\n Вывод третьего значения.");
     Console.Write("Введите 3х значное число: ");
     int num1 = Convert.ToInt32(Console.ReadLine());
     if (num1 < 99) Console.WriteLine("Некорректный ввод.");

     else
     {
        string result = num1.ToString();
        Console.WriteLine(result[2]);
     }
    break;
    
    case 3:
     Console.WriteLine("\n Проверка выходного дня.");
     Console.Write("Введите число дня недели: ");
     int num2 = Convert.ToInt32(Console.ReadLine());
     if (num2 <= 7)
     {
        if (num2 <= 5) Console.WriteLine("Это не выходной.");
        if (num2 > 5 && num2 < 8) 
        {
            Console.WriteLine("Да, это выходной.");
        }
     }  
     else Console.WriteLine("В неделе только 7 дней");
    break;
}
