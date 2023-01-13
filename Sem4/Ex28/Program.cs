/* Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120
*/

Console.Clear();
int num = GetNumberFromUser("Введите целое число N: ", "Ошибка ввода!"); 
int proizvedNumbers = GetProizNumbers(num); 
Console.WriteLine($"{num} -> {proizvedNumbers}");

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

int GetProizNumbers(int number)
/*{
    int fac = 1; 
    while(number > 0) 
    {
        fac *= number;  
        number--;
    }
    return fac; 
}*/
{
    int fac = 1; 
    for(int i = 1; i <= number; i++) 
    {
        fac = fac * i;          
    }
    return fac; 
}