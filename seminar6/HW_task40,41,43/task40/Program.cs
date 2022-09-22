// Задача 40: Напишите программу, которая принимает 
// на вход три числа и проверяет, может ли существовать 
// треугольник с сторонами такой длины.

Console.WriteLine("Введите значение первой стороны треугольника:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение второй стороны треугольника:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение третьей стороны треугольника:");
int c = Convert.ToInt32(Console.ReadLine());

if(a < b+c && b < a+c && c < b + a)
{
    Console.WriteLine("Треугольник с такими значениями сторон существует");
}
else
{
    Console.WriteLine("Треугольника с такими значениями сторон не существует");
}
