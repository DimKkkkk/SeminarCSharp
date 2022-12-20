// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да
Console.Write("Введите число: ");
//string num1 = Console.ReadLine() ?? "";

int number1 = int.Parse(Console.ReadLine() ?? "");
if (number1 % 7 == 0)
{
    Console.WriteLine($"{number1} -> да");
}
else if (number1 % 23 == 0)
{
    Console.WriteLine($"{number1} -> да");
}
else
    Console.WriteLine($"{number1} -> нет");