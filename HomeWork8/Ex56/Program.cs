/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.Clear();

Console.Write("Введите количество строк в массиве: ");
int rows = GetNumberFromUser();

Console.Write("Введите количество столбцов в массиве: ");
int columns = GetNumberFromUser();

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
int index = SumRows(array);
Console.WriteLine($"Строка с наименьшей суммой элементов: {index} строка");

int GetNumberFromUser()
{
    while (true)
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

int SumRows(int[,] inArray)
{
    int index = 0; //создаём переменную индекс, куда будем сохранять индекс с наименьшей суммой
    int sum = 0; // создаём переменную сум, в которой будем аккамулировать сумму строки и обнулять после сложения всей строки
    int result = 0; // создаём переменную резалт, куда будем переносить наименьшую сумму после сравнения    
    for (int i = 0; i < inArray.GetLength(0); i++) // пробегаем строки массива
    {
        sum = 0; // устанавливаем нашу переменную сум, в которую будет заноситься сумма строки, он обнуляется каждый раз 
        //после окончания сложения строки, когда закончится цикл j для строки i
        for (int j = 0; j < inArray.GetLength(1); j++) // пробегаем все элементы строки каждого столбца
        {
            sum += inArray[i, j]; // аккумулируем сумму элементов
        }        
        if (i == 0) result = sum; // для первой строки условие, оно истина по этому переносим сумму первой строки в переменную result для будущих сравнений
        else if (sum < result) // со второй строки начинает работать это условие, где мы начинаем сравнивать сумму следующих строк с суммой первой строки
        {
            result = sum; // если оказывается что сумма следующей строки меньше, то мы обновляем наш result и заносим в него меньшую сумму
            index = i; // и обновляем индекс этой строки с меньшей суммой
        } 
    }
    return index;   // по результату возвращаем индекс с наименьшей суммой 
}