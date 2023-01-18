/* Задача 35: Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

Console.Clear();
Console.WriteLine("Выполняется создание массива... ");
int[] array = GetArray(10, 0, 100);
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
        if((arr[i] >= 10) && (arr[i] <= 99)) kol++;
    }
    return kol;
}

//Console.Write("Количество элементов из отрезка [10, 99] -> "); // алььтернатива строке 35
Console.Write($"[{String.Join(", ", array)}] -> ");
Console.Write(KolArray(array));