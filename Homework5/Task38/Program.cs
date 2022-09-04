// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void FillArray(int[] collection)
{
    int length = collection.Length;
    for (int index = 0; index < length; index++)
    {
        collection[index] = new Random().Next(0, 100);
    }
}

int FindDifference(int[] collection)
{
    int index = 0;
    int max = collection[0];
    int min = collection[0];
    int deffence = 0;
    int length = collection.Length;
    while (index < length)
        {
            if (collection[index] > max)
            {
                max = collection[index];
                index ++;                                            
            }
            else if (collection[index] < min)
            {
                min = collection[index];
                index ++;                                            
            }
            else
            {
                index++;
            }

        }
    Console.WriteLine(max);
    Console.WriteLine(min);
    deffence = max - min;    
    return deffence;   
}

int[] array = new int [4];
FillArray(array);
Console.WriteLine("[{0}]", string.Join(",", array));
int deffence = FindDifference(array);
Console.WriteLine(deffence);


