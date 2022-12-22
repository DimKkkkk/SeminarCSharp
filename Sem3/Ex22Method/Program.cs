/* Напишите программу, которая принимает на вход число (N) и 
выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4  */

static void Init_Digit(ref int x)
{
    try
    {
        Console.Write("Введите число: ");
        x = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return;
    }
}

int N = 0;
Init_Digit(ref N);
int index = 1;
Console.Write($"{N} -> ");
while (index <= N)
{
    Console.Write($"{index * index}, ");
    index++;
}
