// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран. Данные вводятся с консоли пользователем


// Случайная генерация: 

// int[]array = new int[8];
// Random rand = new Random();

// for(int n = 0; n < array.Length; n++)
// array[n]=rand.Next(0, 10);

// foreach(int arr in array)
// {
//     Console.Write(arr +" ");
// }

//-----------------------------------------------------------------

// Ввод массива:

Console.WriteLine("Введите длину массива:");
int lenght = Convert.ToInt32(Console.ReadLine());
int[] array = new int[lenght];

for(int n=0; n<lenght; n++)
{
    Console.WriteLine("Введите эл-ты массива:");
    array[n] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Введённый массив: ");
for(int n=0; n<lenght; n++)
{
    Console.Write(" " + array[n]);
}
