/* Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

Console.Clear();

int num = GetNumberFromUser("Введите число N: ", "Ошибка ввода!");
int[] numberResult = Fibonacci(num);

Console.WriteLine($"Если N={num} -> {String.Join(" ", numberResult)}");

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

int[] Fibonacci(int num)
{
    if(num==1) return new int[1]{0};
    else if(num==0) Console.WriteLine("Ошибка ввода! Введите число больше НУЛЯ.");
    Console.WriteLine();
    int i = 2;
    int[] result = new int [num];
    result[0]=0;
    result[1]=1;
    
    while(i < num)
    {
        result[i] = result[i-1] + result[i-2];
        i++;
    }
    return result;
}