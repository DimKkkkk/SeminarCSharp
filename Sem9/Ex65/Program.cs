/* Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
*/

Console.Clear();

Console.Write("Введите значение М: ");
int numM = GetNumberFromUser();
Console.Write("Введите значение N: ");
int numN = GetNumberFromUser();


Console.Write($"M = {numM}; N = {numN} -> ");
Console.WriteLine(PrintResult(numM, numN));


int GetNumberFromUser()
{
    while (true)
    {
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
