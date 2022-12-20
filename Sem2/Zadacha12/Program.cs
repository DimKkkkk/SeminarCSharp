// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно
Console.Write("Введите первое число: ");
string numA = Console.ReadLine() ?? "";
Console.Write("Введите второе число: ");
string numB = Console.ReadLine() ?? "";

int num1 = int.Parse(numA);
int num2 = int.Parse(numB);

int ost = num1 % num2;

if(ost == 0)
{
    Console.WriteLine($"{num1}, {num2} -> кратно");
}
else 
{
    Console.WriteLine($"{num1}, {num2} -> не кратно, остаток {ost}");
}