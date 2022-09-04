// Напишите программу, которая принимает на фход число 
// и проверяет кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0 && number % 23 ==0)
{
Console.WriteLine("Число кратно одновременно 7 и 23");
}
else
{
    Console.WriteLine("Число не кратно");
}
