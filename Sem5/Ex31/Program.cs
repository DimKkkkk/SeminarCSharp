/* Задача 31: Задайте массив из 12 элементов, заполненный случайными числами 
из промежутка [-9, 9]. Найдите сумму отрицательных и 
положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел 
равна 29, сумма отрицательных равна -20.
*/
Console.Clear(); // очищает в консоли строки
Console.WriteLine("Выполняется создание массива... ");

int[] array = GetArray(12, -9, 9);
int positiveSum = GetPositiveSum(array); // метод суммы положительных чисел, в скобках передаём сам массив
int negativeSum = GetNegativeSum(array); // метод суммы отрицательных

/* 10, 11, 12 строки можно завернуть в один метод MainLogic()
MainLogic();

void MainLogic()
{
    int[] array = GetArray(12, -9, 9);
    int positiveSum = GetPositiveSum(array); 
    int negativeSum = GetNegativeSum(array);
}

*/

/* 10, 11, 12 строки можно завернуть в один метод MainLogic() по ссылкам на переменные
MainLogic(out int[] array, out int positiveSum, out int negativeSum);

void MainLogic(out int[] array, out int positiveSum, out int negativeSum)
{
    array = GetArray(12, -9, 9);
    positiveSum = GetPositiveSum(array); 
    negativeSum = GetNegativeSum(array);
}

*/

// аналогично можно сделать с операциями ввода и вывода Consolo.WriteLine при помощи метода для вывода MainOutput(); также с void.

Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"Сумма положительных чисел = {positiveSum}, Сумма отрицательных чисел = {negativeSum} ");

//////////////////////////////////////////////////////////////////////////////////
// Возвращает массив из size элементов,
// заполненный случайными числами из промежутка [minValue, maxValue]
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
// Возвращает сумму положительных чисел массива arr
int GetPositiveSum(int[] arr)
{
    int positiveSum = 0; //присваиваем переменную с нулём
    foreach (int el in arr) //алгоритм накопления суммы при помощи тернарного оператора. другой вариант: for(int i=0; i < arr.Length; i++)
    {
        if (el > 0) positiveSum += el; // другой вариант: if(arr[i] > 0) positiveSum += arr[i];
    }
    return positiveSum;
}
// Возвращает сумму отрицательных чисел массива arr
int GetNegativeSum(int[] arr)
{
    int negativeSum = 0;
    foreach (int el in arr) //алгоритм накопления суммы при помощи тернарного оператора. другой вариант: for(int i=0; i < arr.Length; i++)
    {
        negativeSum += el < 0 ? el : 0; // другой вариант: if(arr[i] < 0) negativeSum += arr[i];
    }
    return negativeSum;
}