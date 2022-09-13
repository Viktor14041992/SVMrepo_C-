// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());
int tempNumber = number;
int reversedNumber = 0; //развернутое число


if (number >= 10000 && number < 100000)

{
    while(tempNumber >0)
    {
        int digit = tempNumber % 10;
        reversedNumber = reversedNumber * 10 + digit;
        tempNumber = tempNumber / 10;
    }
     Console.WriteLine(reversedNumber);

    if(number == reversedNumber)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}

else
{
    Console.WriteLine("Вы ввели не пятизначное число, повторите попытку");
}
