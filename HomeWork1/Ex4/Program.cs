//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.Write("Введите целое число A: ");
string numberA = Console.ReadLine() ?? "";
Console.Write("Введите целое число B: ");
string numberB = Console.ReadLine() ?? "";
Console.Write("Введите целое число C: ");
string numberC = Console.ReadLine() ?? "";

int number1 = int.Parse(numberA);
int number2 = int.Parse(numberB);
int number3 = int.Parse(numberC);

int max = number1;

if(number1 < number2)
{
    Console.WriteLine($"max число = {number2}");
}
else if (number2 < number3)
{
    Console.WriteLine($"max = {number3}");
}
else
{
    Console.WriteLine($"max = {number1}");
}