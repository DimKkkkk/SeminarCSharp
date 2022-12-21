// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Write ("Введите число от 1 до 7: ");
int day = int.Parse(Console.ReadLine() ?? "");

if (day < 6) Console.WriteLine($"{day} -> нет");

else if (day < 8) Console.WriteLine($"{day} -> да");

else Console.WriteLine("Введите число от 1 до 7: ");