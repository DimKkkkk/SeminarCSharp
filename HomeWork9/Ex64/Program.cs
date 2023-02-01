/* Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.Clear();

int num = GetNumberFromUser("Введите число N: ");
Console.WriteLine();

Console.Write($"N = {num} - > ");
string str ="\"";
Console.Write(str + PrintResult(num, 1) + str);


int GetNumberFromUser(string message)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int number);
        if (isCorrect) return number;
        else Console.WriteLine("Ошибка ввода!");
    }
}

string PrintResult(int start, int end)
{
    if (start == end) return start.ToString();
    else return start + ", " + PrintResult(start - 1, end); // + это мы собираем строку и через запятую перечисляем значения. это не сложение чисел.
}
