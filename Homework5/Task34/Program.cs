// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void FillArray(int[] collection)
{
    int length = collection.Length;
    for (int index = 0; index < length; index++)
    {
        collection[index] = new Random().Next(100, 999);
    }
}

int FindPositive(int[] collection)
{
    int count = 0;
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        if (collection[index] % 2 == 0)
        {
            count++;
            index++;
        }
        else
            index++;
    }
    return count;
}

int[] array = new int[6];
FillArray(array);
Console.WriteLine("[{0}]", string.Join(",", array));
int positive = FindPositive(array);
Console.WriteLine(positive);
