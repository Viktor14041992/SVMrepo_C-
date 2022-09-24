// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве 
// находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

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
            matrix[i,j] = i + j;  // каждой ячейке присваиваем рандомное значене
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
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine(); //перенос строки, чтобы вывод был в виде матрицы, а не в виде строки
    }
}

int m = ReadNumber("Введите количество строк:");
int n = ReadNumber("Введите количество столбцов:");
int[,] matr = GetMatrix(m, n); //вызываем метод для нашей матрицы, задаём матрицу, присваиваем ей вызов нашего метода
PrintMatrix(matr);







//test

// int[] GetArray(int size, int leftRange, int rightRange)
// {
//     int[] arr = new int [size];
//     Random rand = new Random();
//     for(int i=0; i<size; i++)
//     {
//         arr[i] = i;
//     }
//     return arr;
// }
// int[] arr = GetArray(12, 9, 9);
// Console.Write("Сгенерирован массив:");
// Console.WriteLine(string.Join(", ", arr));