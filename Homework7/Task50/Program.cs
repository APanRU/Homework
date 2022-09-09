// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int lines = Read("Введите позицию в строке - ");
int columns = Read("Введите позицию в столбце - ");
int[,] numbers = new int[10, 10];

int Read(string line)
{
    Console.Write(line);
    int R = int.Parse(Console.ReadLine() ?? "");
    return R;
}

int [,] FillingArray(int[,] outArray)
{
    for (int i = 0; i < outArray.GetLength(0); i++)
        {
            for (int j = 0; j < outArray.GetLength(1); j++)
            {
               outArray[i,j] = Convert.ToInt32(new Random().Next(0, 10)); 
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

string FindElement (int[,] matr, int n, int m)
{
    if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
    {
        return  "Такого элемента нет";
    }
    
    else
    {
        return  ($"На позиции:  индекс строки: {n}, индекс столбца: {m} - находится элемент со значением {numbers[n-1,m-1]}");
    }
}


Console.WriteLine();
FillingArray(numbers);
Print2DArray(numbers);
string result = FindElement(numbers,lines,columns);
Console.WriteLine(result);