int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());


if (num1 % num2 == 0) 
{
    Console.WriteLine("Кратно");
    Console.WriteLine(num1 / num2);
}

else 
{
    Console.WriteLine($"не кратно, остаток { num1 % num2}");
    Console.WriteLine(num1 / num2);
}