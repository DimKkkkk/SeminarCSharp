/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.Clear();
int numA = GetNumberFromUserA("Введите целое число А: ", "Ошибка ввода!");
int numB = GetNumberFromUserB("Введите целое число B: ", "Ошибка ввода!");
int stepen = GetStepenResult(numA);
Console.WriteLine($"{numA}, {numB} -> {stepen}");

int GetNumberFromUserA(string message, string errorMessage) 
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

int GetNumberFromUserB(string message, string errorMessage) 
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

int GetStepenResult(int number)

{
    int p = 1;
    for (int i=1; i <= numB; i++)
    {
        p=p*number;
    }
    return p;
}
