// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



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


void SearchMinSumOfElements(int[,] matrix)
{
    int min=matrix[0,0];
    int Row = 0;
    int sum = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
    for(int j = 0; j < matrix.GetLength(1); j++)
        {
        sum = sum + matrix[i,j];
        }
        Row =i;
        Console.WriteLine($"Сумма элементов строки = {sum}");
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
SearchMinSumOfElements(matrix);