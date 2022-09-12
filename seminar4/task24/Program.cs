// Задача 24: 
// Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму 
// чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


int ReadNumber(string message);
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int SumNumbersFromToA(int a)
{
    if (a >= 1) //если а >=1, то работаем дальше
    {
        int sum = 0;
        for (int i=1; i <=a; i++)
        {
            sum = sum +i;
        }
        return sum;
    }
    else
    {
        Console.WriteLine("A должна быть не меньше 1!");
        return -1; //неправильная сумма (код ошибки)
    }
}
int number = ReadNumber("Введите число ");
int summa = SumNumbersFromToA(number);
Console.WriteLine($"Сумма элементов от 1 до А = {summa}");



