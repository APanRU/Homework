// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int Read(string line)
{
    Console.Write(line);
    int R = int.Parse(Console.ReadLine() ?? "");
    return R;
}

double [,] FillingArray(double[,] outArray)
{
    for (int i = 0; i < outArray.GetLength(0); i++)
        {
            for (int j = 0; j < outArray.GetLength(1); j++)
            {
               outArray[i,j] = Convert.ToDouble(new Random().Next(-300, 300)) / 10; 
            }
    }
    return outArray;
}

void Print2DArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int lines = Read("Введите количество строк - ");
int columns = Read("Введите количество столбцов - ");
double[,] numbers = new double[lines, columns];
Console.WriteLine();
FillingArray(numbers);
Print2DArray(numbers);