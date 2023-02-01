/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Clear();

Console.Write("Введите число М: ");
int numM = GetNumberFromUser();
Console.Write("Введите число N: ");
int numN = GetNumberFromUser();

Console.WriteLine();
Console.Write($"M = {numM}; N = {numN} -> ");
Console.WriteLine(SumResult(numM, numN));

int GetNumberFromUser()
{
    while (true)
    {
        bool isCorrect = int.TryParse(Console.ReadLine(), out int number);
        if (isCorrect && number > 0) return number;
        else Console.WriteLine("Ошибка ввода!");
    }
}

int SumResult(int start, int end)
{
    if (start == end) return start;
    else if (start > end) return start + SumResult(start - 1, end + 1) + end;
    else return start + SumResult(start + 1, end - 1) + end;
}