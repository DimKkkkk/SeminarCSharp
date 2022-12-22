/* Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y). */

Console.Clear();
Console.Write("Введите номер четверти: ");
int Chetvert = int.Parse(Console.ReadLine() ?? "");

if (Chetvert == 1)
{
    Console.WriteLine("X > 0 и Y > 0");
}
else if (Chetvert == 2)
{
    Console.WriteLine("X < 0 и Y > 0");
}
else if (Chetvert == 3)
{
    Console.WriteLine("X < 0 и Y < 0");
}
else if (Chetvert == 4)
{
    Console.WriteLine("X > 0 и Y < 0");
}
else
    Console.WriteLine("Ошибка! Такой четверти не существует, введите от 1 до 4");