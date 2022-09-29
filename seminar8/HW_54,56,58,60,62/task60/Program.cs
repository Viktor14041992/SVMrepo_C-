// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)

// 45(1,0,0) 53(1,0,1)


int[,,]arr = new int[2,2,2];
Random rand = new Random();
int[] array = new int[8];

for(int i =0; i < array.Length; i++)
{
    int number = rand.Next(10,100);
    if(array.Contains(number)) 
    i--;
    else array[i] = number;
}

int count = 0;
for(int i =0; i < arr.GetLength(0); i++)
{
    for(int j =0; j < arr.GetLength(1); j++)
    {
        for(int n =0; n < arr.GetLength(2); n++)
        {
            arr[i,j,n] = array[count];
            count++;
            Console.WriteLine($"{arr[i,j,n]} ({i},{j},{n})");
        }
    }
}