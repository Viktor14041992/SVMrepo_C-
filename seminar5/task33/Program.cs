// Задача 33: Задайте массив. Напишите программу, 
// которая определяет, присутствует ли заданное число 
// в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


int[] GetArray(int size, int leftRange, int rightRange)
{
    int[] arr = new int [size];
    Random rand = new Random();
    for(int i=0; i<size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange+1);

    }
    return arr;
}

// int Number(int[]arr)
// {
//     Console.WriteLine("Введите номер для поиска");
//     int number = Convert.ToInt32(Console.ReadLine());//искомое число
//     for(int i = 0; i < arr.Length; i++)
//     {
//        if(arr[i] == number)
//        Console.WriteLine("Да");
//        else
//        Console.WriteLine("Нет");

//     }
//     return number;
// }

// int[] array = GetArray(10,-10, 10);
// Console.WriteLine(string.Join(", ", array));
// Number(array); 


int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
// true - есть элемент в массиве;
// false - элемент в массиве отсутствует;
bool IsNumberInArray(int[] arr, int findNumber)
{
    bool isNumberInArray = false;
    for(int i=0; i < arr.Length; i++)
    {
        if (arr[i] == findNumber)
        {
            isNumberInArray = true;
        }
    }
    return isNumberInArray;
}

int[] array = GetArray(10,-10, 10);
Console.WriteLine(string.Join(", ", array));
int find = ReadNumber("Задайте число для поиска");
bool res = IsNumberInArray(array, find);
if(res == true)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

