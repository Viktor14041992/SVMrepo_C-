﻿// Задача:
// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа.
//Пример:

//["hello", "2", "world", ":-)"] -> ["2", ":-)"]




string[] Array = { "hello", "Month", "2", "world", "245", "6870", ":-)" }; // Инициализация массива строк

for (int i = 0; i < Array.Length; i++) // Вывод массива строк в цикле

Console.WriteLine(Array[i]); // вывод массива

Console.WriteLine(" "); // пробел
Console.WriteLine("Sorted array:"); // вывод отсортироованного массива

string[] NewArray = Array; // новый отсортированный массив
for (int i = 0; i < NewArray.Length; i++) // цикл для проверки условия для каждого элемента массива
    if (NewArray[i].Length <= 3)   // условия для элементов нового массива
{
    Console.WriteLine(NewArray[i]);  // вывод отсортироованного массива
}

