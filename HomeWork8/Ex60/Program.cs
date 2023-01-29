/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
Console.Clear();

Console.Write("Введите количество измерений в массиве: ");
int page = GetNumberFromUser();

Console.Write("Введите количество строк в массиве: ");
int rows = GetNumberFromUser();

Console.Write("Введите количество столбцов в массиве: ");
int columns = GetNumberFromUser();

int[,,] array = GetArray(page, rows, columns, 10, 99);
PrintArray(array);
Console.WriteLine();


int GetNumberFromUser()
{
    while (true)
    {
        bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
        if (isCorrect) return num;
        else Console.WriteLine("Ошибка ввода");
    }
}

int[,,] GetArray(int p, int m, int n, int minValue, int maxValue)
{
    int[,,] arr3D = new int[p, m, n];
    Random rnd = new Random();
    for (int z = 0; z < p; z++)
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                arr3D[z, i, j] = rnd.Next(minValue, maxValue + 1);
            }
        }
    }    
    return arr3D;
}


void PrintArray(int[,,] inArray)
{
    for (int z = 0; z < inArray.GetLength(0); z++)
    {
        for (int i = 0; i < inArray.GetLength(1); i++)
        {
            for (int j = 0; j < inArray.GetLength(2); j++)
            {
                Console.Write($"{inArray[z, i, j]}({z},{i},{j}) ");
            }
            Console.WriteLine();
        }            
    }    
}