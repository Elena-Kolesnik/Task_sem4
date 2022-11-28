// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

using static System.Console;
Clear();

int number = int.Parse(ReadLine());

int result = number.ToString().Sum(c => c - '0');

WriteLine($"{result}");