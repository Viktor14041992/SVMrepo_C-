// Задача 49: Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4


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
    for(int i=0; i< matrix.GetLength(0); i++) // цикл, обходящий каждый чётный одномерный массив
    {
        for(int j=0; j<matrix.GetLength(1); j++) // цикл, обходящий каждый чётный элемент одномерного массива
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine(); //перенос строки, чтобы вывод был в виде матрицы, а не в виде строки
    }
}

void ChangeMatrix(int[,]matrix) //метод, позволяющий вывести матрицу на экран
{
    for(int i=0; i< matrix.GetLength(0); i+=2) // цикл, обходящий каждый чётный одномерный массив
    {
        for(int j=0; j<matrix.GetLength(1); j+=2) // цикл, обходящий каждый чётный элемент одномерного массива
        {
            matrix[i,j] = matrix[i,j] * matrix[i,j];
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine(); //перенос строки, чтобы вывод был в виде матрицы, а не в виде строки
    }
}

int m = ReadNumber("Введите количество строк:");
int n = ReadNumber("Введите количество столбцов:");
int[,] matr = GetMatrix(m, n); //вызываем метод для нашей матрицы, задаём матрицу, присваиваем ей вызов нашего метода
PrintMatrix(matr);
ChangeMatrix(matr);
PrintMatrix(matr);

