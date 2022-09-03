// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое чило квадратом второго.
// a = 25, b = 5 --> да
// a = 2, b = 10 --> нет

// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 --> Среда
// 5 --> Пятница


Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA == numberB * numberB)
{
    Console.WriteLine("ДА");
}

else
{
   Console.WriteLine("НЕТ"); 
}
