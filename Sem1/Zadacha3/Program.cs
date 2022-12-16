Console.WriteLine("Введите целое число от 1 до 7: ");
string userInput = Console.ReadLine()  ?? "";
int number = int.Parse(userInput);

if (number == 1)
{
    Console.WriteLine("Понедельник");
}
else if (number == 2)
{
    Console.WriteLine("Вторник");
}
else if (number == 3)
{
    Console.WriteLine("Среда");
}
else if (number == 4)
{
    Console.WriteLine("Четверг");
}
else if (number == 5)
{
    Console.WriteLine("Тяпница");
}
else if (number == 6)
{
    Console.WriteLine("Суббота");
}
else if (number == 7)
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Введите от 1 до 7");
}

// или вот так можно было
//Console.WriteLine("Введите целое число от 1 до 7: ");
//string userInput = Console.ReadLine()  ?? "";
//int number = int.Parse(userInput);
//if (number == 1) Console.WriteLine("Понедельник");
//else if (number == 2) Console.WriteLine("Вторник");
// ... и так далее
// else Console.WriteLine("Введите от 1 до 7");