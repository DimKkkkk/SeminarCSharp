/* Задача 34: Задайте массив заполненный случайными 
положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

Console.Clear();
Console.WriteLine("Выполняется создание массива... ");
int[] array = GetArray(4, 100, 1000);
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

int KolArray(int[] arr)
{
    int kol = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0) kol++;
    }
    return kol;
}

Console.Write($"[{String.Join(", ", array)}] -> ");
Console.Write(KolArray(array));