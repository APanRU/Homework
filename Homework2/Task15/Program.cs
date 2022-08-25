// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void ShowWeekends(int number)
{
    if ((number == 6) |  (number == 7))
    {
        Console.WriteLine ("Это выходной");
    }
    else if  ((number <= 0) | (number > 7))
    {
        Console.WriteLine ("Это не день недели");
    }
    else 
    {
        Console.WriteLine ("Это не выходной");
    }
}
Console.WriteLine ("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
ShowWeekends(number);