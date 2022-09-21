// Задача 42: Напишите программу, которая 
// будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintBinaryView(int number)
{
    if (number <= 0) return;
    PrintBinaryView(number / 2);
    Console.Write(number % 2);
}


int num = ReadNumber("Введите число");
PrintBinaryView(num);
