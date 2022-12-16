// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write("Введите целое число A: ");
string numberA = Console.ReadLine() ?? "";
Console.Write("Введите целое число B: ");
string numberB = Console.ReadLine() ?? "";

int number1 = int.Parse(numberA);
int number2 = int.Parse(numberB);

int max = 0;

if(max < number1)
{
    Console.WriteLine($"max = {number1}");
}
else if (number1 < number2)
{
    Console.WriteLine($"max = {number2}");
}