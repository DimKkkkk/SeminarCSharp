/*Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

Console.Clear();

Console.Write("Введите число А: ");
int numA = GetNumberFromUser();
Console.Write("Введите число В: ");
int numB = GetNumberFromUser();

Console.Write($"A = {numA}; B = {numB} -> {numA} в степени {numB} =  ");
Console.WriteLine(StepenResult(numA, numB));


int GetNumberFromUser()
{
    while (true)
    {
        bool isCorrect = int.TryParse(Console.ReadLine(), out int number);
        if (isCorrect) return number;
        else Console.WriteLine("Ошибка ввода!");
    }
}

int StepenResult (int number, int stepen)
{
    int result = 1;
    if(stepen != 0) 
        result = number * StepenResult(number, stepen - 1);
    return result;
}
