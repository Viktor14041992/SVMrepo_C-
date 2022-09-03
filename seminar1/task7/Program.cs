// Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает последнюю цифруэтого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите трёхзначное число ");
int number = Convert.ToInt32(Console.ReadLine());
if(number >= 100 && number < 1000)
{
    double count = number % 10;
     Console.WriteLine(count);
}
else
{
    Console.WriteLine("введено не трёхзначное число ");
}
