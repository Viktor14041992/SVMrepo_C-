// 5. Напишите программу, которая на вход
// принимает одно число (N), а на выходе показывает все
// целые числа в провежутке от - N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4."

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = -number;
while(count <= number)
{
    Console.Write(count + " ");
    count = count + 1;
}
