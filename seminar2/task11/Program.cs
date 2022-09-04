// Напишите программу, которая выводит случайное
// случайное трёхзначное число и удаляет вторую цифру
// этого числа
// 456 -> 46
// 782 -> 72


Random rand = new Random();
int number = rand.Next(100, 1000);
Console.WriteLine($"Сгенерировалось случайное число {number}");
int digit2 = number % 10;
int digit1 = number / 100;
Console.WriteLine(digit1);
Console.WriteLine(digit2);
int number2 = digit1 * 10 + digit2;
{
    Console.WriteLine(number2);
}
