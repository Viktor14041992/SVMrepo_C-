// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода стоп-слова "stop"

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Введите длину массива:");
int lenght = Convert.ToInt32(Console.ReadLine());
int[] array = new int[lenght];
int count = 0;

for(int i=0; i<lenght; i++)
{
    Console.WriteLine("Введите элемент массива:");
    array[i] = Convert.ToInt32(Console.ReadLine());
    
    if(array[i]>0)
    {
        count = count+1;
    }
}
Console.WriteLine($"Кол-во положительных элементов: {count}");



// Console.WriteLine($"Кол-во положительных элементов: {count}");
// for(int n=0; n<lenght; n++)
// {
//     Console.Write(" " + array[n]);
// }
