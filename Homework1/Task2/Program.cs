// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int maxNumber = 0;
int minNumber = 0;
if (number1 > number2)
{
    maxNumber = number1;
    minNumber = number2;
    Console.Write("Большее число = " + maxNumber + "," + " Меньшее число = " + minNumber);
}
else if (number1 == number2)
{
    Console.WriteLine("Числа равны");
}
else
{
    maxNumber = number2;
    minNumber = number1;
    Console.Write("Большее число = " + maxNumber + "," + " Меньшее число = " + minNumber);
}

