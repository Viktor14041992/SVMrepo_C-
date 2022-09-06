// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6



Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number / 100 > 0)
{
int n = number;  //искомое число
int i = 1;   //кол-во знаков
while (number > 0)
     {
         number = number / 10;
         i=i*10;
    }

// Console.WriteLine($"{i} - количество знаков числа");
i=i/1000;

// Console.WriteLine($"{k} - степень");

n =(n/i)%10;

Console.WriteLine($"{n} - третья цифра числа");

}
else
{
    Console.WriteLine("Третьей цифры нет");
}



//ПРЕДЫДУЩИЙ ВАРИАНТ(РЕШЕНИЕ С ВОЗВЕДЕНИЕМ В СТЕПЕНЬ)
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number / 100 > 0)
// {
// int n = number;  //искомое число
// int i = 0;   //кол-во знаков
// while (number > 0)
//      {
//          number = number / 10;
//          i=i+1;
//     }

// Console.WriteLine($"{i} - количество знаков числа");
// i=i-3;

// double k = 10^i;
// Console.WriteLine($"{k} - степень");

// double m =(n/k)%10;

// Console.WriteLine($"{m} - третья цифра числа");

// }
// else
// {
//     Console.WriteLine("Третьей цифры нет");
// }

