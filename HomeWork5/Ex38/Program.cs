/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
Console.Clear();
Console.WriteLine("Выполняется создание массива... ");
int[] array = GetArray(5, 0, 100);
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

int Raznica(int[] arr)
{
    int razn = 0;
    int max = 0;
    int min = arr[0];
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max) max = arr[i];
        if(arr[i] < min) min = arr[i];
        {
            razn = max - min;
        }
    }
    return razn;
}

Console.Write($"[{String.Join(", ", array)}] -> ");
Console.Write(Raznica(array));