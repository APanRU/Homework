﻿// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число ");
string numbers = Console.ReadLine();
if ((numbers[^1] == numbers[0]) && (numbers[^2] == numbers[1]))
{
    Console.Write("Число  палиндромом");
}
else
{
    Console.Write("Число не палиндромом");
}