// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.



int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetMatrix(int rowsCount, int columsCount, int leftRange = 0, int rightRange = 10) // -10 и 10 - диапазоны по умолчанию, 
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
}


void ReverseMatrix(int[,]matrix)
{
    for(int j=0; j< matrix.GetLength(1); j++)
    {
        int temp = matrix[0,j];
        matrix[0,j] = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0)-1, j] = temp;
    }
}

void PrintReverseMatrix(int[,]matrix)
{

    for(int i=0; i< matrix.GetLength(0); i++) 
    {
        for(int j=0; j<matrix.GetLength(1); j++) 
        {
            Console.Write($"{matrix[i,j]}\t ");
        }
        Console.WriteLine(); 
    }
}



int m = ReadNumber("Введите количество строк:");
int n = ReadNumber("Введите количество столбцов:");
int[,] matr = GetMatrix(m, n); 
Console.WriteLine("Исходная матрица:");
PrintMatrix(matr);
ReverseMatrix(matr);
Console.WriteLine("Матрица с поменяными крайними строками:");
PrintReverseMatrix(matr);
