﻿// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5



int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int countNumbers(int n)
{

    int i = 0;
    for (i = 0; n > 0 ; i++)
    {
        n = n / 10;
    }
    return i;
    
}
int number = ReadNumber("Введите число ");
int count = countNumbers(number);
Console.WriteLine($"Кол-во цифр в числе: {count}");