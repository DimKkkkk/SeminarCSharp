/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

static void initKub(ref int num)

{
    try
    {
        Console.Write("Введите число N: ");
        num = int.Parse(Console.ReadLine() ?? "");        
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return;
    }
}

int N = 0;
initKub(ref N);
int index = 1;
Console.Write($"{N} -> ");

while (index <= N)
{
    if (index < N)
        Console.Write($"{Math.Pow(index, 3)}, ");
    else
        Console.Write($"{Math.Pow(index, 3)}.");
    index++;
}

/* решение задачи гораздо проще
Clear();
Write("Введите число N: ");
int N = int.Parse(ReadLine());

for (int i=1; i<= N; i++)
{
    Write($"{i * i * i}");
}