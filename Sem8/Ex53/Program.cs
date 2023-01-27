/* Задача 53: Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку массива.*/

Console.Clear();

Console.Write("Введите количество строк в массиве: ");
int rows = GetNumberFromUser();

Console.Write("Введите количество столбцов в массиве: ");
int columns = GetNumberFromUser();

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
ChangeArray(array);
PrintArray(array);

int GetNumberFromUser()
{
    while(true)
    {
        bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
        if (isCorrect) return num;
        else Console.WriteLine("Ошибка ввода");
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

void ChangeArray(int[,] inArray)
{
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        int temp = 0; // либо меняем при помощи временной переменной. нулевой элемент первой строки с элементом последней строки
        temp = inArray[0, j];
        inArray[0, j] = inArray[inArray.GetLength(0) - 1, j];
        inArray[inArray.GetLength(0) - 1, j] = temp;
        // (inArray[0, j], inArray[inArray.GetLength(0) - 1, j]) = (inArray[inArray.GetLength(0) - 1, j], inArray[0, j]); // либо хак при помощи  кортежа, 
        //какой элемент с каким меняем и так переставляем местами.
    }
}