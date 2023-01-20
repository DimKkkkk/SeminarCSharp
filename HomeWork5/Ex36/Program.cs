/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.Clear();
Console.WriteLine("Выполняется создание массива... ");
int[] array = GetArray(4, -100, 100);
Console.WriteLine($"[{String.Join(", ", array)}]");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int SumArray(int[] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(i % 2 == 1) sum = sum + arr[i];
    }
    return sum;
}

Console.Write($"[{String.Join(", ", array)}] -> ");
Console.Write(SumArray(array));