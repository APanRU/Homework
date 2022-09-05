// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Read(string line)
{
    Console.WriteLine(line);
    double R = double.Parse(Console.ReadLine() ?? "");
    return R;
}

void Result(double b1, double k1, double b2, double k2)
{
    if (b1 == b2 & k1 == k2)
    {
       Console.WriteLine("Прямые совпадают");
    }
    else if (k1 == k2)
    {
        Console.WriteLine("Прямые параллельны друг другу");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        x = Math.Round(x, 3);
        y = Math.Round(y, 3);
        Console.WriteLine($"Точка пересечения: ({x};{y})");
    }
}

double b1 = Read("Введите b1: ");
double k1 = Read("Введите k1: ");
double b2 = Read("Введите b2: ");
double k2 = Read("Введите k2: ");
Result(b1, k1, b2, k2);



