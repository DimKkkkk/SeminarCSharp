/* Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

Console.Clear();

int N = GetNumberFromUser("Введите значение N: ", "Ошибка ввода!");
Console.WriteLine();
Console.Write($"{N} -> ");
Console.WriteLine(SumResult(N));

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int number);
        if (isCorrect) return number;
        else Console.WriteLine("Ошибка ввода!");
    }
}

int SumResult(int number)
{
    if (number == 0) return 0;
    else return number % 10 + SumResult(number / 10);
}