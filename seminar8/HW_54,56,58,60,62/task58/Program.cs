// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, заданы 2 массива:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// и

// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49


void GetMatrix(int[,]matrix1, int[,]matrix2) 
{
    Random rand1 = new Random();

    for(int i=0; i< matrix1.GetLength(0); i++) 
    {
        for(int j=0; j<matrix1.GetLength(1); j++) 
        {
            matrix1[i,j] = rand1.Next(1, 10);  
            Console.Write($"{matrix1[i,j]}\t ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();

    Random rand2 = new Random();
    for(int i=0; i< matrix2.GetLength(0); i++) 
    {
        for(int j=0; j<matrix2.GetLength(1); j++) 
        {
            matrix2[i,j] = rand2.Next(1, 10);  
            Console.Write($"{matrix2[i,j]}\t ");
        }
        Console.WriteLine();

    }
    Console.WriteLine();
    Console.WriteLine("Произведение масивов:");

    int[,] newMatrix = new int[matrix1.GetLength(0)-1, matrix1.GetLength(1)-1];
    
    for(int i = 0; i < matrix1.GetLength(0); i++)
    {
        for(int j = 0; j < matrix1.GetLength(1); j++)
        {
        matrix1[i,j] = matrix1[i,j] * matrix2[i,j];
        Console.Write($"{matrix1[i,j]}\t");
        }
        Console.WriteLine();
    }
    
}



Console.Write("Введите кол-во строк: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int j = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = new int[i, j];
int[,] matrix2 = new int[i, j];
Console.WriteLine("Исходная матрица:");
GetMatrix(matrix1,matrix2);
Console.WriteLine(" ");


