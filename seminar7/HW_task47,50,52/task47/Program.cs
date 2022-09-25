// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] GetMatrix(int rowsCount, int columsCount, int leftRange = -10, int rightRange = 10) // -10 и 10 - диапазоны по умолчанию, 
//они не передаются, если мы не укажем другой диапазон
{
    double[,] matrix = new double[rowsCount, columsCount];

    Random rand = new Random();

    for(int i=0; i< matrix.GetLength(0); i++) // цикл, обходящий каждый одномерный массив
    {
        for(int j=0; j<matrix.GetLength(1); j++) // цикл, обходящий каждый элемент одномерного массива
        {
            matrix[i,j] = rand.Next(leftRange, rightRange + 1)+rand.NextDouble();  // каждой ячейке присваиваем рандомное значене
        }
    }
    return matrix;
}

void PrintMatrix(double[,]matrix) //метод, позволяющий вывести матрицу на экран
{
    for(int i=0; i< matrix.GetLength(0); i++) // цикл, обходящий каждый одномерный массив
    {
        for(int j=0; j<matrix.GetLength(1); j++) // цикл, обходящий каждый элемент одномерного массива
        {
            Console.Write("{0,5:f1} ", matrix[i,j]);
        }
        Console.WriteLine(); //перенос строки, чтобы вывод был в виде матрицы, а не в виде строки
    }
}

int m = ReadNumber("Введите количество строк:");
int n = ReadNumber("Введите количество столбцов:");
double[,] matr = GetMatrix(m, n); //вызываем метод для нашей матрицы, задаём матрицу, присваиваем ей вызов нашего метода
PrintMatrix(matr);
