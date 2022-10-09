// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33-> [6, 1, 33]

// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     for (int index = 0; index < length; index++)
//     {
//         collection[index] = new Random().Next(1, 100);
//         if (index == 0)
//             Console.Write("[" + collection[index] + ",");
//         else if (index >= 1 && index <= length - 2)
//             Console.Write(collection[index] + ",");
//         else if (index == length - 1)
//             Console.Write(collection[index] + "]");
//     }
// }

// int[] array = new int[8];
// FillArray(array);

void FillArray(int[] collection)
{
    int length = collection.Length;
    for (int index = 0; index < length; index++)
    {
        collection[index] = new Random().Next(1, 100);
    }
}

int[] array = new int[8];
FillArray(array);
Console.WriteLine("[{0}]", string.Join(",", array));