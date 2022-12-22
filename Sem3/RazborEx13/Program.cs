/*******************
    Напишите программу, которая выводит третью цифру
    заданного числа или сообщает, что третьей цифры нет.
********************/
int num;

while(true) //этот цикл сделали для того чтобы отсеивать некорректный вод, символ или ещё что кроме числа
{
    Console.Write("Введите целое число: ");

    try
    {
        num = Convert.ToInt32(Console.ReadLine() ?? "");
        break; // завершает цикл, если мы ввели корректное число
    }
    catch(Exception exc)  //это как раз класс исключения и переменная к нему exc
    {
        Console.WriteLine($"Ошибка ввода! {exc.Message}");  // это сообщение об ошибке о некорретном вводе
    }
}


int num_abs = Math.Abs(num);  // этот класс Math.Abs позволяет превратить отриц число в положительное

if (num_abs < 100)
{
    Console.WriteLine($"Третьей цифры нет");
    return;  // возвращает и завершает программу
}

int thirdNumberRight = num_abs / 100 % 10;

while(num_abs > 999)
{
    num_abs /= 10;
}
int thirdNumberLeft = num_abs % 10;


Console.WriteLine($"Третья цифра числа {num} справа -> {thirdNumberRight}");
Console.WriteLine($"Третья цифра числа {num} слева -> {thirdNumberLeft}");