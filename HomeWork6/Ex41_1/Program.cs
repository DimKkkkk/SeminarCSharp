/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Clear();
Console.WriteLine("Выполняется создание массива... ");
Console.WriteLine();

int[] array = new int[5];


FillNumFromUser(array); 

void FillNumFromUser(int[] collection)
{
    int lengthArray = collection.Length;
    for(int i = 0; i < lengthArray; i++)
    {
        while(true)
        {
            Console.Write($"Введите {i}-е число: ");
            bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
            if(isCorrect)
                {
                collection[i] = num;
                break;
                }
            else Console.WriteLine("Ошибка ввода!");
        }
    }
}

int KolChisel(int[] arr)
{
    int kol = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) kol++;
    }
    return kol;
}

Console.Write($"[{String.Join(", ", array)}] -> ");
Console.Write(KolChisel(array));
