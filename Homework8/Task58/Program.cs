// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateAndFillArray(int a, int b)
{
    int[,] array = new int[a, b];

    for (int cols = 0; cols < array.GetLength(0); cols++)
    {
        for (var rows = 0; rows < array.GetLength(1); rows++)
        {
            array[cols, rows] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int cols = 0; cols < array.GetLength(0); cols++)
    {
        for (var rows = 0; rows < array.GetLength(1); rows++)
        {
            System.Console.Write(array[cols, rows]);
            System.Console.Write("\t");
        }
        System.Console.WriteLine();
    }
}

int[,] MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int result = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                result += firstMartrix[i, k] * secomdMartrix[k, j];
            }
            resultMatrix[i, j] = result;
        }
    }
    return resultMatrix;
}

int[,] array1 = CreateAndFillArray(2, 2);
int[,] array2 = CreateAndFillArray(2, 2);
int[,] array3 = new int[2, 2];
PrintArray(array1);
System.Console.WriteLine();
PrintArray(array2);
int[,] arr = MultiplyMatrix(array1, array2, array3);
System.Console.WriteLine();
PrintArray(arr);