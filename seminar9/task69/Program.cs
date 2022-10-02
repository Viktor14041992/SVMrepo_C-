// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int PowAtoB(int a, int b)  // метод для подсчета суммы цифр в числе
{
    
    if(b < 1)
    {
        return 1;  //выход из рекурсии
    }
    else
    {
        a = PowAtoB(a, b-1)*a;
        b --;
        return a;
    }  
}

int numberA = ReadNumber("Введите A: ");
int numberB = ReadNumber("Введите B: ");
Console.WriteLine( );
PowAtoB(numberA, numberB);
Console.WriteLine(PowAtoB(numberA, numberB));