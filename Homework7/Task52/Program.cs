// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] numbers = new int[3, 4];

int [,] FillingArray(int[,] outArray)
{
    for (int i = 0; i < outArray.GetLength(0); i++)
        {
            for (int j = 0; j < outArray.GetLength(1); j++)
            {
               outArray[i,j] = Convert.ToInt32(new Random().Next(1, 10)); 
            }
    }
    return outArray;
}

void Print2DArray(int[,] matr)
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


FillingArray(numbers);
Print2DArray(numbers);
Console.WriteLine();

for (int j = 0; j < numbers.GetLength(1); j++)
    {            
        double arithmeticMean = 0;
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            arithmeticMean = arithmeticMean + numbers[i,j];            
        }
       Console.WriteLine($"{ arithmeticMean / numbers.GetLength(0)} ");
    } 





