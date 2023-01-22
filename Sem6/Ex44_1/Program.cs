/* Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

Console.Clear();

int num = GetNumberFromUser("Введите число N: ", "Ошибка ввода!");
FibonacciNumber(num);

int GetNumberFromUser(string message, string errorMessage) // заносим два аргумента string message которое будет нам выводить Введите целое число А:, и  string errorMessage которое будет выводить сообщение об ошибке ввода.
{
    while (true)
    {
        Console.WriteLine(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber); // out int userNumber - создаём внутри TryParse переменную юзернамбер
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

void FibonacciNumber(int num)
{
    Console.Write($"Если N = {num} -> 0 ");
    int f1 = 0;
    int f2 = 1;
    int f = 0;
    for(int i = 0; i < num -1; i++)
    {
        f = f1+f2;
        f2=f1;
        f1=f;
        Console.Write($"{f} ");
    }
}