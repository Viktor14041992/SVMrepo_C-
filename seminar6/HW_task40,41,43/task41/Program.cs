// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода стоп-слова "stop"

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


int countOfPositive = 0;

while(true)
{
    var answer = Console.ReadLine() ;
    if (answer == "stop")
    {
        break;
    }
    else
    {
        int.TryParse(answer, out int answerNumber);   //TryParse берёт строку answer. Если конвертация возможна, 
        // то результат кдадётся в answerNumber. Проверяет возможна ли конвертация.
        //int answerNumber = Convert.ToInt32(answer); //конвертируем нашу строку в число.
        if (answerNumber > 0)
        {
            countOfPositive++;
        }
    }
}
Console.WriteLine($"Количество положительных элементов: {countOfPositive}");

