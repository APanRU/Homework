// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, -567, 89, 223-> 3

Console.Write("Введите числа через запятую: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);

int QuantityMore0(int[] arr)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

// int count = QuantityMore0(array);
// Console.WriteLine($"Кол-во чисел > 0: {count}");

Console.WriteLine($"Кол-во чисел > 0: {QuantityMore0(array)}");

