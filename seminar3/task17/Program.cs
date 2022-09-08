// Напишите программу, которая принимает на вход координаты точки
// (X и Y), причем X не равно 0 и Y не равно 0,
// и выдаёт номер четверти плоскости, 
// в которой находится эта точка.


Console.WriteLine("Введите координату точки по X:");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки по X:");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("Точка находится в первой координатной четверти");
}

else if (x < 0 && y > 0)
{
    Console.WriteLine("Точка находится во второй координатной четверти");
}

else if (x < 0 && y < 0)
{
    Console.WriteLine("Точка находится в третьей координатной четверти");
}

else if (x > 0 && y < 0)
{
    Console.WriteLine("Точка находится в четвертой координатной четверти");
}

else
{
    Console.WriteLine("Нулевая координата по X или Y");
}



