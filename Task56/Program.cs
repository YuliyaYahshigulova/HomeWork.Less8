// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

//
int[,] CreateArray(int n, int m)
{
    int[,] array = new int[n, m];
    return array;
}
// 
int[,] FillArray(int[,] array, int min, int max)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(min, max);
        }
    }    
    return array;
}
//
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++, Console.WriteLine())
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
    }    
}
// находим строки с наименьшей суммой элементов.
int FindMinSumString(int[,] array)
{
    int str = 1;
    int min = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        min = min + array[0, j];
    }
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        if (sum < min)
        {
            min = sum;
            str = i + 1;
        }
        else sum = 0;
    }
    return str;
}
//
int[,] array = CreateArray(3, 6);
array = FillArray(array, 0, 10);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(FindMinSumString(array) + " - cтрока с наименьшей суммой элементов");









