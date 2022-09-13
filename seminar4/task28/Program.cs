// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int SumNumbersFromToA(int a)
{
    if (a >= 1) //если а >=1, то работаем дальше
    {
        int sum = 1;
        for (int i=1; i <=a; i++)
        {
            sum = sum * i;
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
Console.WriteLine($"Произведение элементов от 1 до А = {summa}");