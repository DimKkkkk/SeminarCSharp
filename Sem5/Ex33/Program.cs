/* Задача 33: Задайте массив. Напишите программу, 
которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/
Console.Clear();
Console.WriteLine("Выполняется создание массива... ");

int[] array3 = GetArray(5, -10, 10);
Console.WriteLine($"[{String.Join(", ", array3)}]");

int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

bool Check(int x, int[] arr)
{
    int i =0;
    bool f=false;
    while((f==false) && (i < arr.Length))
    {
        if (x == arr[i]) f = true;
        i++;
    }
    return f;
}

int n = GetNumberFromUser($"Введите число: ", "Ошибка ввода!");
Console.WriteLine();

if (Check(n, array3)) Console.WriteLine($"[{String.Join(", ", array3)}] - > да!");
else Console.WriteLine($"[{String.Join(", ", array3)}] - > нет:((");