/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

Console.Clear();

Console.Write("Введите количество строк в массиве: ");
int rows = GetNumberFromUser();

Console.Write("Введите количество столбцов в массиве: ");
int columns = GetNumberFromUser();

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

Console.WriteLine();
Console.Write("Введите позицию строки массива: ");
int rowCheck = CheckElementsArray();

Console.Write("Введите позиция столбца массива: ");
int columnCheck = CheckElementsArray();

Console.WriteLine();
Console.Write($"{rowCheck}, {columnCheck} - > ");

CheckArray(rowCheck, columnCheck, array);

int GetNumberFromUser()
{
    while (true)
    {
        bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
        if (isCorrect) return num;
        else Console.WriteLine("Ошибка ввода!");
    }
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int CheckElementsArray()
{
    while (true)
    {
        bool isCorrect = int.TryParse(Console.ReadLine(), out int poz);
        if (isCorrect) return poz;
        else Console.WriteLine("Ошибка ввода!");
    }
}

void CheckArray(int chRow, int chCol, int[,] inArray)
{
    if (chRow < inArray.GetLength(0) && chCol < inArray.GetLength(1))
    {
        Console.Write($"{inArray[chRow, chCol]}");
    }
    else Console.Write("такого числа в массиве нет!");
}

