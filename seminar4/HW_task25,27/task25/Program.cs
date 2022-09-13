// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Не использовать Math.Pow() и аналоги!

//-----------------------------------------------------------------------------------------------

// ВТОРОЙ ВАРИАНТ (РАБОТАЕТ):

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

// int Grade(number1);
// {
//     int grade = 1;
//     for(int i=0; i < number2; i++)
//     {
//         grade = grade * number1;
//     }
//     return grade;
    
// }
int number1 = ReadNumber("Введите первое число ");
int number2 = ReadNumber("Введите второе число ");
// int digit = Grade(number1);
// Console.WriteLine($"Число в степени = {digit}");

int grade = 1;
for(int i=0; i < number2; i++)
{
    grade = grade * number1;
}
Console.Write(grade);




// -----------------------------------------------------------------------------------------------

// ПЕРВЫЙ ВАРИАНТ (РАБОТАЕТ):

// Console.WriteLine("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// int i = 0;
// int grade = 1;

// while(i < number2)
// {
//     grade = grade * number1;
//     i = i + 1;
// }
// Console.Write(grade);