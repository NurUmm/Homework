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