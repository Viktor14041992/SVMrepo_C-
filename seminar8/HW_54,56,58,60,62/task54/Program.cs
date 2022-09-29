// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по возрастанию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8


void GetMatrix(int[,]matrix) 
{
    Random rand = new Random();

    for(int i=0; i< matrix.GetLength(0); i++) 
    {
        for(int j=0; j<matrix.GetLength(1); j++) 
        {
            matrix[i,j] = rand.Next(0, 10);  
            Console.Write($"{matrix[i,j]}\t ");
        }
        Console.WriteLine();
    }
}


void SelectionSortMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            int minPosition = j;
            for(int k = j+1; k < matrix.GetLength(1)-1; k++)
        {
            if(matrix[i,j] < matrix[i,minPosition]) 
            minPosition = k; 
        int temp = matrix[i,j];
        matrix[i,j] = matrix[i,minPosition];
        matrix[i,minPosition] = temp;
        }
        Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
        }
}


Console.Write("Введите кол-во строк: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int j = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[i, j]; 
Console.WriteLine("Исходная матрица:");
GetMatrix(matrix);
Console.WriteLine(" ");
Console.WriteLine("Упорядоченная матрица:");
SelectionSortMatrix(matrix);