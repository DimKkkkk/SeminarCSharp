/* Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
*/

Console.Clear();

int rows = 0;
int columns = 0;
InputSizeArray(ref rows, ref columns);
int[,] array = GetArray(rows, columns, 0, 10);
int[,] array2 = ReplaceRowsToColumns(array);
ReplaceRowsToColumns(array);
// Console.Write("Введите количество строк в массиве: ");
// int rows = GetNumberFromUser();

// Console.Write("Введите количество столбцов в массиве: ");
// int columns = GetNumberFromUser();


PrintArray(array);
Console.WriteLine();
PrintReplaceArray(array);

void InputSizeArray(ref int a, ref int b)
{
    try
    {
        Console.Write("Введите количество строк в массиве: ");
        a = int.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите количество столбцов в массиве: ");
        b = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception ex)
    {
        Console.Write("Ошибка ввода!", ex);
    }
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] arr = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return arr;
}

int[,] ReplaceRowsToColumns(int[,] arr)
{
    int[,] arr2 = new int[arr.GetLength(1), arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr2[j, i] = arr [i, j];
        }
    }
    return arr2;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintReplaceArray(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
