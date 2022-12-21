// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Write("Введите число: ");
int InsertNum = int.Parse(Console.ReadLine() ?? "");

int num3 = InsertNum % 10;
int num = InsertNum;
int num4 = InsertNum;

if (InsertNum < 100)
{
    Console.WriteLine($"{InsertNum} -> третьей цифры тютю");
}
else if (InsertNum > 99 && InsertNum < 1000)
{
    Console.WriteLine($"{InsertNum} -> {num3}");
}

while (true)
{
    if (InsertNum > 999)
    {
        num = InsertNum / 100;
        InsertNum = num;
        num = InsertNum % 10;
    }
    break;
}
Console.WriteLine($"{num4} -> {num}");
