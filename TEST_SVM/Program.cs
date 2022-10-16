// Задача:
// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа.
//Пример:

//["hello", "2", "world", ":-)"] -> ["2", ":-)"]




string[] Array = { "hello", "Month", "2", "world", "245", "6870", ":-)" }; // Инициализация массива строк
Console.WriteLine($"Исходный массив: [{string.Join(", ", Array)}]");
// for (int i = 0; i < Array.Length; i++) // Вывод массива строк в цикле
// Console.WriteLine(Array[i]); // вывод массива

Console.WriteLine(" "); // пробел
Console.WriteLine("нужные элементы массива:"); // вывод отсортироованного массива

string[] NewArray = new string[Array.Length]; // новый отсортированный массив
int count=0;
for (int i = 0; i < Array.Length; i++) // цикл для проверки условия для каждого элемента массива

    if (Array[i].Length <= 3)// условия для элементов нового массива
    
    {
        Console.WriteLine(Array[i]); // вывод отсортироованного массива
        count++;
        NewArray[i] = Array[i];
    }


Console.WriteLine(" "); // пробел
Console.WriteLine($"Отсортированный массив: [{string.Join(" ", NewArray)}]");
Console.WriteLine(count);
