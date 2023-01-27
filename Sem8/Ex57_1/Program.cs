// Задача 57 (ДРУГОЙ СПОСОБ): Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

Console.Clear();

Console.Write("Введите количество строк в массиве: ");
int rows = GetNumberFromUser();
Console.Write("Введите количество столбцов в массиве: ");
int columns = GetNumberFromUser();

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
PrintResult(array, 10);

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

int CountElement(int num, int[,] array)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (num == array[i, j]) result++;
        }
    }
    return result;
}

void PrintResult(int[,] array, int maxValue)
{
    for (int i = 0; i < maxValue+1; i++)
    {
        int num = CountElement(i, array);
        Console.WriteLine($"{i} встречается {num} раз.");
    }
}
