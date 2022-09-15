// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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


int[,]  SortRowMaxElements(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int m = 0; m < array.GetLength(1) - 1; m++)
      {
        if (array[i, m] < array[i, m + 1])
        {
          int temp = array[i, m + 1];
          array[i, m + 1] = array[i, m];
          array[i, m] = temp;
        }
      }
    }
  }
  return array;
}

int[,] array = CreateAndFillArray(4, 4);
PrintArray(array);

int[,] arr = SortRowMaxElements(array);
System.Console.WriteLine();
PrintArray(arr);