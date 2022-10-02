// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumMtoN(int m, int n)  // метод для подсчета суммы цифр в числе
{
    
    if(n < m)
    {
        return 0;  //выход из рекурсии
    }
    else
    {
        int sum = SumMtoN(m, n-1)+n;
        n --;
        return sum;
    }  
}

int numberM = ReadNumber("Введите M: ");
int numberN = ReadNumber("Введите N: ");
Console.WriteLine( );
SumMtoN(numberM, numberN);
Console.WriteLine(SumMtoN(numberM, numberN));