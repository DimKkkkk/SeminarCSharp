// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Write("Введите трёхзначное число: ");
int InsertNum = int.Parse(Console.ReadLine() ?? "");

int num = InsertNum / 10;
int num2 = num % 10;

Console.WriteLine($"{InsertNum} -> {num2}");