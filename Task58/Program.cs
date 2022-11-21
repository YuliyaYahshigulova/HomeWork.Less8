// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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
//умножение массивов(матрица)
int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    var newmatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (var i = 0; i < matrix1.GetLength(0); i++)
    {
        for (var j = 0; j < matrix2.GetLength(1); j++)
        {
            newmatrix[i, j] = 0;
            for (var k = 0; k < matrix2.GetLength(0); k++)
            {
                
                newmatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return newmatrix;
}
//
int[,] matrix1 = CreateArray(2, 2);
int[,] matrix2 = CreateArray(2, 2);
matrix1 = FillArray(matrix1, 0, 10);
matrix2 = FillArray(matrix2, 0, 10);
PrintArray(matrix1);
Console.WriteLine();
PrintArray(matrix2);
Console.WriteLine();
Console.WriteLine("Результирующая матрица: ");
int[,] newmatrix = MultiplicationMatrix(matrix1, matrix2);
PrintArray(newmatrix);


