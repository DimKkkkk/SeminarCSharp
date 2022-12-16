//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.Write("Введите любое число: ");
string numberA = Console.ReadLine() ?? "";


int number1 = int.Parse(numberA);

if(number1 % 2 == 0)
{
    Console.WriteLine("да, Число четнее некуда");
}
else
{
    Console.WriteLine("нет, Число нечёткое");
}