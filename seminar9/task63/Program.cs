﻿// Задача 63: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"



int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void Print1toN(int n)
{
    if(n <= 0)
    {
        return;  //выход из рекурсии
    }
    else
    {
        Print1toN(n-1);  //действия, если рекурсия не остановилась
        Console.WriteLine(n+ " ");
    }
}

int number = ReadNumber("Введите N");
Console.WriteLine( );
Print1toN(number);