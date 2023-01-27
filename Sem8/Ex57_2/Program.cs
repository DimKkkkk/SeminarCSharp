// Задача 57 (ЕЩЁ СПОСОБ с методами и отсеивающий 0 раз): Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

Console.Clear();

Console.Write("Введите количество строк в массиве: ");
int rows = GetNumberFromUser();
Console.Write("Введите количество столбцов в массиве: ");
int columns = GetNumberFromUser();

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
CheckPrintResult(array, 0, 10);

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

void CheckPrintResult(int[,] inArray, int minValue, int maxValue)
{
    Console.WriteLine();
    int[] countNumber = new int[maxValue + 1 - minValue]; // создаем одномерный массив и наполняем его числами рандом из нашего диапазона от 0 до 10 включительно 
    //для проверки нахождения этих сисел в нашем двумерном массиве.
    for (int x = 0; x < countNumber.Length; x++) // х - это переменная которая принимает на себя числа из диапазона и каждый из них проверяет по всей длине диапазона
    {
        int amount = 0; // заводим переменную в которую будем собирать количество нахождения раз числа из нашего двумерного массива
        for (int i = 0; i < inArray.GetLength(0); i++) // берём первые координаты строки
        {
            for (int j = 0; j < inArray.GetLength(1); j++) // берём первые координаты столбца
            {
                if (inArray[i, j] == x) amount += 1; // полученные координаты через условие сравниваем: число в этих координатах равно х (первому числу проверки), 
                //если да то счётчик прибавляет к себе количество.               
            }
        }
        countNumber[x] = amount; // в наш одномерный массив заносим под индексом х количество из нашего счётчика
        if (amount != 0) // далее через условие, если счётчик не равен нуля и он насчитал количество раз повторений то выдаёт результаты в консоль
        {
            if (amount % 10 == 2 || amount % 10 == 3 || amount % 10 == 4) // если количество повторений с остатком от деления %10 = 2 или 3 или 4, то на конце пишем разА.
                Console.WriteLine($"{x} встречается {amount} раза");
            else
                Console.WriteLine($"{x} встречается {amount} раз"); // иначе пишем раз.
        }
    }
}