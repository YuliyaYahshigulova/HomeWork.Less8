// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],5}");
        }
    Console.WriteLine();  
    }    
}
//
int[,] SortArray(int[,] array)
{
    int temp;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, j] < array[i, k])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
    return array;
}

Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Заданный массив: ");
int[,] array = CreateArray(n, m);
array = FillArray(array, 1, 199);
PrintArray(array);
Console.WriteLine();

array = SortArray(array);
Console.WriteLine("Отсортированный массив: ");
PrintArray(array);