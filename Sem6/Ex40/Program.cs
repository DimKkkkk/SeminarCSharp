/* Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон
*/

Console.Clear();

int[] array = new int[3]; // создаём при помощи массива и фиксируем что в массиве 3 числа должно быть.

FillNumFromUser(array); // обращаемся к методу который опишем ниже. он не возвращает ничего только прописывает значения в массив
bool result = CheckSide(array); // при помощи bool проверяем истину или ложи сравнение сумму сторон в этом методе
Console.WriteLine($"Треугольник со сторонами [{String.Join(", ", array)}] существует? -> {(result ? "ДА!" : "НЕТ.")}"); // [{String.Join(", ", array)}] - показывает нам массив наш.

void FillNumFromUser(int[] collection)
{
    int lengthArray = collection.Length;
    for(int i = 0; i < lengthArray; i++)
    {
        while(true)
        {
            Console.Write($"Введите {i}-й элемент стороны: ");
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

bool CheckSide(int[] arr)
{
    if(arr[0]+arr[1]>arr[2] && arr[2]+arr[1]>arr[0] && arr[0]+arr[2]>arr[1]) return true;
    else return false;
}