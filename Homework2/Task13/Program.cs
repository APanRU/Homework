// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// void ShowThirdNumber()
// {
//     string str = Console.ReadLine();
//     int length = str.Length;
//     if (length < 3)
//     {
//         Console.WriteLine("В числе нет третьей цифры");
//     }
//     else
//     {
//         Console.WriteLine(str[2]);
//     }
// }
// Console.WriteLine("Введите число ");
// ShowThirdNumber();


void ShowThirdNumber(int x)
{
    while (x >= 1000) x = x / 10;
    int y = x % 10;
    if (x >= 100)
    {
        Console.WriteLine($"Третья цифра числа = {y}.");
    }
    else
    {
        Console.WriteLine("В числе нет третьей цифры");
    }
}

Console.WriteLine("Введите число ");
int x = Convert.ToInt32(Console.ReadLine());
ShowThirdNumber(x);
