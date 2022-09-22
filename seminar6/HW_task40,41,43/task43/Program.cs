// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение b1:");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k1:");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2:");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2:");
int k2 = Convert.ToInt32(Console.ReadLine());

if(k1==k2 && b1==b2)
{
    Console.WriteLine("Прямые совпадают");
}
else
{
    if(k1 != k2)
    {
        int x = (b2-b1)/(k1-k2);
        int y = k1*x +b1;
        Console.WriteLine($"Координата точки пересечения прямых: {x}, {y}");
        }
        else
        {
            Console.WriteLine("Прямые параллельны");
        }
}

