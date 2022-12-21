// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Write("Введите число: ");
int insertNum = int.Parse(Console.ReadLine() ?? "");

int tmp = insertNum;

if (insertNum < 100)
{
    Console.WriteLine($"{insertNum} -> третьей цифры тютю");
}

else
{
    while (tmp > 1000)
    {
        {
            tmp = tmp / 10; //можно ещё так tmp /= 10;
        }                        
    }    
int num3 = tmp % 10;
Console.WriteLine($"{insertNum} -> {num3}");
}
