// Задача 12 при помощи функции
// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно
int InsNum()
{
    int Usernum;
    while (true)
    {
        Console.Write("Введите число: ");
        if (int.TryParse(Console.ReadLine(), out Usernum))
            break;
        Console.WriteLine("Ты осёл, введи число!");
    }
    return Usernum;
}

int num1 = InsNum();
int num2 = InsNum();

int ost = num1 % num2;

if (ost == 0)
{
    Console.WriteLine($"{num1}, {num2} -> кратно");
}
else
{
    Console.WriteLine($"{num1}, {num2} -> не кратно, остаток {ost}");
}
