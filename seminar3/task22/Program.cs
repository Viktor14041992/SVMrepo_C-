// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 0;

if (n > 0)
{
    while (i < n)
{
    i = i + 1;
    double k = Math.Pow(i, 2);
{
    Console.Write(k+ ", ");
}
};

}
else
{
    Console.WriteLine("Введите число больше 0");
}


