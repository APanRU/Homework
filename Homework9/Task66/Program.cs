// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumRec(int m, int n)
{
    if (m == 0 || n == 0) return 0;
    else if (n < m) return m + SumRec(m - 1, n);
    else return n + SumRec(m, n - 1);
}

Console.WriteLine(SumRec(1, 15));
