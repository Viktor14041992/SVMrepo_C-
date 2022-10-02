// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Ack(int m, int n) // функция Аккермана
{
    
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ack(m - 1, 1);
    }
    else
    {
        return Ack(m - 1, Ack(m, n - 1));
    }
}


int numberM = ReadNumber("Введите M: ");
int numberN = ReadNumber("Введите N: ");
Console.WriteLine( );
Ack(numberM, numberN);
Console.WriteLine(Ack(numberM, numberN));
