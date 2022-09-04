// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


void FillArray(int[] collection)
{
    int length = collection.Length;
    for (int index = 0; index < length; index++)
    {
        collection[index] = new Random().Next(-10, 10);
    }
}

int FindSumm(int[] collection)
{
    int sum = 0;
    int length = collection.Length;
    int index = 0;
    while (index < length)
        {
            if (index % 2 == 0 )
            {
                index ++;                            
            }
            else
            {
                sum = sum + collection[index];
                index++;
            }
                
        }
    return sum;   
}

int[] array = new int [4];
FillArray(array);
Console.WriteLine("[{0}]", string.Join(",", array));
int summ = FindSumm(array);
Console.WriteLine(summ);
