// Задача 57: Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

Console.Clear();

Console.Write("Введите количество строк в массиве: ");
int rows = GetNumberFromUser();

Console.Write("Введите количество столбцов в массиве: ");
int columns = GetNumberFromUser();

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
int[] array1 = GetDictionaryOfElements(array);
PrintDictionaryOfElements(array1);

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

int[] GetDictionaryOfElements(int[,]array)
{
    int[] arr = new int[11];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == 0)
                arr[0]++;
            else if (array[i, j] == 1)
                arr[1]++;
            else if (array[i, j] == 2)
                arr[2]++;
            else if (array[i, j] == 3)
                arr[3]++;
            else if (array[i, j] == 4)
                arr[4]++;
            else if (array[i, j] == 5)
                arr[5]++;
            else if (array[i, j] == 6)
                arr[6]++;
            else if (array[i, j] == 7)
                arr[7]++;
            else if (array[i, j] == 8)
                arr[8]++;
            else if (array[i, j] == 9)
                arr[9]++;
            else if (array[i, j] == 10)
                arr[10]++;    
        }
    }
    return arr;
}

void PrintDictionaryOfElements(int[] data)
{
    for (int i = 0; i < data.Length; i++)
    {
        if (data[i] != 0)
            Console.WriteLine($"{i} встречается {data[i]} раз");
    }
}