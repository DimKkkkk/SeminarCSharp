/* Задача 63: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

Console.Clear();

int N = GetNumberFromUser("Введите значение N: ", "Ошибка ввода!");
Console.WriteLine();
Console.Write($"N = {N} -> ");
Console.WriteLine(PrintResult(1, N));


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

string PrintResult(int start, int end)
{
    if (start == end) return end.ToString();
    else return start + ", " + PrintResult(start + 1, end);
}