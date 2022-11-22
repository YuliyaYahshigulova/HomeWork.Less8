// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
// Спиральное заполнение массива. 
int[,] FillSpiralArray(int n)
{
    int[,] array = new int[n, n];
    int num = 0;
    int count = n;
    int mean = -n;
    int amount = -1;

    while (count > 0)
    {
        mean = -mean / n;
        for (int i = 0; i < count; i++)
        {
            amount += mean;
            array[amount / n, amount % n] = num++;
        }
        mean *= n;
        count--;
        for (int i = 0; i < count; i++)
        {
            amount += mean;
            array[amount / n, amount % n] = num++;
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
int[,] array = FillSpiralArray(4);
PrintArray(array);




