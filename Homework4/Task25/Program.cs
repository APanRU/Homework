// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4-> 16

int Exponentiation(int number1, int number2)
{
    int result = 1;
    int i = 0;
    while (i != number2)
    {
        i++;
        result = result * number1;
    }
    return result;
}
Console.WriteLine("Введите первое число ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int exponentiation = Exponentiation(firstNumber, secondNumber);
Console.WriteLine(exponentiation);

double Exponentiation(double number1, double number2)
{
    double result = Math.Pow(number1, number2);
    return result;
}
Console.WriteLine("Введите первое число ");
double firstNumber = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число ");
double secondNumber = Convert.ToDouble(Console.ReadLine());
double exponentiation = Exponentiation(firstNumber, secondNumber);
Console.WriteLine(exponentiation);