﻿// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1 7 -> такого числа в массиве нет


int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetMatrix(int rowsCount, int columsCount, int leftRange = -10, int rightRange = 10) // -10 и 10 - диапазоны по умолчанию, 
//они не передаются, если мы не укажем другой диапазон
{
    int[,] matrix = new int[rowsCount, columsCount];

    Random rand = new Random();

    for(int i=0; i< matrix.GetLength(0); i++) // цикл, обходящий каждый одномерный массив
    {
        for(int j=0; j<matrix.GetLength(1); j++) // цикл, обходящий каждый элемент одномерного массива
        {
            matrix[i,j] = rand.Next(leftRange, rightRange + 1);  // каждой ячейке присваиваем рандомное значене
        }
    }
    return matrix;
}

void PrintMatrix(int[,]matrix) //метод, позволяющий вывести матрицу на экран
{
    for(int i=0; i< matrix.GetLength(0); i++) // цикл, обходящий каждый одномерный массив
    {
        for(int j=0; j<matrix.GetLength(1); j++) // цикл, обходящий каждый элемент одномерного массива
        {
            Console.Write($"{matrix[i,j]}\t ");
        }
        Console.WriteLine(); //перенос строки, чтобы вывод был в виде матрицы, а не в виде строки
    }

    int a = ReadNumber("Введите номер строки искомого элемента:");
    int b = ReadNumber("Введите номер столбца искомого элемента:");

    if(a>0 && b>0 && a <= matrix.GetLength(0) && b <= matrix.GetLength(1)) 
        {
        Console.WriteLine($"Искомый элемент: {matrix[a-1, b-1]}");
        }
        else
            {
                Console.WriteLine("Такого элемента нет");
            }
}



int m = ReadNumber("Введите количество строк:");
int n = ReadNumber("Введите количество столбцов:");
int[,] matr = GetMatrix(m, n); //вызываем метод для нашей матрицы, задаём матрицу, присваиваем ей вызов нашего метода
PrintMatrix(matr);

