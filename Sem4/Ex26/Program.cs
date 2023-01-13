/* Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

Console.Clear();
int num = GetNumberFromUser("Введите целое число А: ", "Ошибка ввода!"); 
int count = GetCountNumber(num);
Console.WriteLine($"{num} -> {count}");

int GetNumberFromUser(string message, string errorMessage) 
{
    while(true)
    {
        Console.WriteLine(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int GetCountNumber(int number)
{
    int result = 0;
    while(number > 0)
    {
        number = number / 10;  // убираем последнее число введённого числа
        result++; // увеличиваем result тем самым считается количество цифр в введённом числе
    }
    return result;
}