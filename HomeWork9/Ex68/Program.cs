/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

Console.Clear();

Console.Write("Введите неотрицательное число m: ");
int numM = GetNumberFromUser();
Console.Write("Введите неотрицательное число n: ");
int numN = GetNumberFromUser();

Console.WriteLine();
Console.Write($"m = {numM}, n = {numN} - > A({numM},{numN}) = ");
Console.WriteLine(AkkermanFunction(numM, numN));

int GetNumberFromUser()
{
    while (true)
    {
        bool isCorrect = int.TryParse(Console.ReadLine(), out int number);
        if (isCorrect && number > -1) return number;
        else Console.WriteLine("Ошибка ввода!");
    }
}

int AkkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m == 1) return n + 2;
    else if (m != 0 && n == 0) return AkkermanFunction(m - 1, 1);
    else return AkkermanFunction(m - 1,AkkermanFunction(m, n - 1));
}

