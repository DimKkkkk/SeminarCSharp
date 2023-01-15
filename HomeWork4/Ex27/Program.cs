/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Clear();
int num = GetNumberFromUser("Введите целое число: ", "Ошибка ввода!"); 
int sumNumbers = GetSumNumbers(num);
Console.WriteLine($"{num} -> {sumNumbers}");

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

int GetSumNumbers(int number)
{
    int sum = 0;
    int temp=0; 
    while(number > 0) 
    {
        temp= number %10;
        number = number / 10;
        sum += temp;          
    }
    return sum; 
}