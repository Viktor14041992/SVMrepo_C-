// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести 
// сообщение для пользователя.



void GetMatrix(int[,]matrix) 
{
    Random rand = new Random();

    for(int i=0; i< matrix.GetLength(0); i++) // цикл, обходящий каждый одномерный массив
    {
        for(int j=0; j<matrix.GetLength(1); j++) // цикл, обходящий каждый элемент одномерного массива
        {
            matrix[i,j] = rand.Next(-10, 11);  // каждой ячейке присваиваем рандомное значене
            Console.Write($"{matrix[i,j]}\t ");
        }
        Console.WriteLine();
    }
}

void ReverseMatrix(int[,]matrix)
{
    for(int i=0; i< matrix.GetLength(1); i++)
    {
        for(int j=0; j< matrix.GetLength(0); j++)
        {
            Console.Write($"{matrix[j,i]}\t ");
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
Console.WriteLine("Матрица c заменой строк на столбцы:");
ReverseMatrix(matrix);