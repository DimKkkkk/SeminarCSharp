/* Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/

Console.Clear();

int num = GetNumberFromUser("Введите целое число: ", "Ошибка ввода!"); // заводим метод GetNumberFromUser
string numberResult = GetDesyatNumbers(num);
Console.WriteLine($"{num} -> {numberResult}");

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

string GetDesyatNumbers(int number)
{
    string result = String.Empty; // String.Empty - определяет строку пустой
    if (number == 0) return "0";
    for (int i = 0; number > 0; i++) // делаем цикл и щёлкаем его пока наше число больше нуля.
    {
        result = (number % 2) + result; // остаток от деления на 2 прибавляем в result.
        number = number / 2; // далее делим наше число на 2.
    }
    return result;
}