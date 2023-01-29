/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

Console.Clear();

Console.Write("Введите число: ");
int rows = GetNumberFromUser();
int columns = rows;

Console.WriteLine($"Размерность матриц = {rows}x{columns}");
Console.WriteLine();

int[,] array = GetArray(rows, columns, 0, 10);
int[,] array2 = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Произведение двух матриц: ");
PrintArrayMulti(MultiArray(array, array2));


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

void PrintArrayMulti(int[,] inArray)  // метод печати результата перемножения массивов
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (j < inArray.GetLength(1) - 1) Console.Write($"{inArray[i, j], 1}|");
            else Console.Write($"{inArray[i, j], 1}");
        }
        Console.WriteLine("| ");
    }
}

void PrintArray(int[,] inArray)  //метод печати двух массивов рядом друг с другом
{
    int rowCount =  array.GetLength(0); // Строк в первой матрице
    int rowMedium = rowCount / 2; // Средняя строка
    int col1Count = array.GetLength(1); // Колонок в первой матрице
    int col2Count = array2.GetLength(1);// Колонок во второй матрице

    for (int row = 0; row < rowCount; row++)
    {
        Console.Write(" | ");
        for (int col = 0; col < col1Count; col++)
            Console.Write(array[row, col] + "  ");
        Console.Write((row == rowMedium) ? "| * | " : "|   | "); // знак умножения между массивами
        for (int col = 0; col < col2Count; col++)
            Console.Write(array2[row, col] + "  ");
        Console.WriteLine("|");
    }
}

int[,] MultiArray(int[,] array, int [,] array2)  // метод перемножения двух массивов и его заполнение
{
    int[,] multiarray = new int[array.GetLength(0), array2.GetLength(1)];    // создаём массив, который будет получаться по формуле 
    //умножения массивов - первая строка на первый столбец и т.д. 
    for (int i = 0; i < multiarray.GetLength(0); i++)
    {        
        for (int j = 0; j < multiarray.GetLength(1); j++)
        {
            multiarray[i, j] = 0; // ставим временный аккумулятор произведения, куда будут присваиваться произведение элементов двух наших массивов. 
            //он обнуляется с переходом на каждую новую строку.
            for (int n = 0; n < array.GetLength(1); n++) 
            {
                multiarray[i, j] += array[i, n] * array2[n, j]; // формула перемножения элементов и суммирование их
            }
            
        }    
    }
    return multiarray;    
}