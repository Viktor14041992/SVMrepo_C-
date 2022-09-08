// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 0;

if (n > 0)
{
    while (i < n)
{
    i = i + 1;
    double k = Math.Pow(i, 3);
{
    Console.Write(k+ ", ");
}
};

}
else
{
    Console.WriteLine("Введите число больше 0");
}