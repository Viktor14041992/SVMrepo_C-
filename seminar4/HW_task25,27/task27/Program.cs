// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 012 -> 12


int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int SumNumbersFromToA(int a)
{
    if (a > 0) //если а >=1, то работаем дальше
    {
        int sum = 0;
        int n = a;
        for (int i=0; i <= a; i++)
        {
            sum = sum + n % 10;
            n = n / 10;
        }
        return sum;
    }
    else
    {
        Console.WriteLine("A должна быть больше 0");
        return -1; //неправильная сумма (код ошибки)
    }
}
int number = ReadNumber("Введите число ");
int summa = SumNumbersFromToA(number);
Console.WriteLine($"Сумма элементов в числе = {summa}");