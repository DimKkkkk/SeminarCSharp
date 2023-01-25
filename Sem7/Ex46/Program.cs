/* Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1
*/

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columns, 0, 10);  //в квадратных скобках стоит запятая, значит массив будет двумерным. количество запятых +1 
//определит нам скольки мерный массив. в скобках у нас 4 переменных, количество строк, количество столбцов, и мин макс сгенерированных чисел.
PrintArray(array); //выводит наш массив в консоль

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n]; // создаём в памяти наш двумерный массив с переменной result. m кол-во строк, n кол-во столбцов.    
    for (int i = 0; i < m; i++) //создаём строки
    {
        for (int j = 0; j < n; j++) //создаём столбцы
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1); // заполняем наш массив result случайными числами. в квадратных скобках указываем строку и столбец
        }
    }
    return result;
}

void PrintArray(int[,] inArray) // метод вывода нашего массива
{
    for (int i = 0; i < inArray.GetLength(0); i++) // в скобках ноль так как начинается первая ячейка строки с 0,0
    {
        for (int j = 0; j < inArray.GetLength(1); j++) // а здесь 1 потому что 0,0 уже заполнили выше в for и начинать нам над уже с 0,1
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine(); // это нужно чтобы отделять строки друг от друга
    }
}
