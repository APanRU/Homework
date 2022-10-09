// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int SummNumber(int number)
// {
//     int counter = Convert.ToString(number).Length;
//     int advance = 0;
//     int result = 0;
//     for (int i = 0; i < counter; i++)
//     {
//         advance = number - number % 10;
//         result = result + (number - advance);
//         number = number / 10;
//     }
//     return result;
// }

// Console.WriteLine("Введите число ");
// int number = Convert.ToInt32(Console.ReadLine());
// int summ = SummNumber(number);
// Console.WriteLine("Сумма цифр в числе: " + summ);

// int SummNumber(string number)
// {
//     int result = 0;
//     for (int i = 0; i < number.Length; i++)
//     {
//         result += number[i] - '0';
//     }
//     return result;
// }

// Console.WriteLine("Введите число ");
// string number = Console.ReadLine();
// int summ = SummNumber(number);
// Console.WriteLine("Сумма цифр в числе: " + summ);

int SummNumber(int number)
{
    int result = 0;
    while (number > 0)
    {
        int temp = number % 10;
        result += temp;
        number = number / 10;
    }
    return result;
}

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int summ = SummNumber(number);
Console.WriteLine("Сумма цифр в числе: " + summ);