/* Задача 32: Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
*/

Console.Clear();
Console.WriteLine("Выполняется создание массива... ");

int[] array = GetArray(4, -10, 10);
Console.Write($"[{String.Join(", ", array)}] -> ");
ChangeArray(array);
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

void ChangeArray (int[] arr) // используем void так как мы передаём массив по ссылке, то нам нет необходимости его возвращать, и в этом методе уже затрагивается наш первоначальный массив. Тогда мы сможем получить два разных массива в памяти.
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] =-arr[i];
    }    
}
