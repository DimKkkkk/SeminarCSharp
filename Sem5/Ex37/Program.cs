/* Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/
int[] array = GetArray(4, -10, 10);
int[] array2 = CreateNewArray(array);
Console.Write($"[{String.Join(", ", array)}] -> ");
Console.Write($"{String.Join(", ", array2)}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] CreateNewArray(int[] arr)
{
    int size = 0;
    if(arr.Length % 2 == 1) size = arr.Length / 2 + 1;
    else size = arr.Length / 2;

    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        if((arr.Length % 2 == 1) && (i == size - 1)) res[i] = arr[i];
        else res[i] = arr[i] * arr[arr.Length - i - 1];
    }
    return res;
}



