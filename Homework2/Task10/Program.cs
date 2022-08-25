// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write(" Введите трехзначное число ");
// string str = Console.ReadLine();
// Console.Write(str[1]);

void ShowSecondNumber(int x)
{
    int y = x / 10 % 10;
    if (x >= 1000)
    {
        while (x >= 100) x = x / 10;
        int z = x % 10;
        Console.WriteLine($"Вторая цифра числа {z}. Вы ввели не трехзначное число");
    }
    else if (x >= 100)
    {
        Console.WriteLine(y);
    }
    else if ((x >= 10) && (x < 100))
    {
        int a = x % 10;
        Console.WriteLine($"Вторая цифра числа {a}.  Вы ввели не трехзначное число!");
    }
    else
    {
        Console.WriteLine("В числе нет второй цифры");
    }
}

Console.WriteLine("Введите число ");
int x = Convert.ToInt32(Console.ReadLine());
ShowSecondNumber(x);