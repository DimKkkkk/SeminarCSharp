Console.Write("Введите целое число А: ");  // организация пользовательского ввода
string numberA = Console.ReadLine() ?? "";
Console.Write("Введите целое число B: ");  // организация пользовательского ввода
string numberB = Console.ReadLine() ?? "";

int number1 = int.Parse(numberA);
int number2 = int.Parse(numberB);

if(number1 == Math.Pow(number2, 2))
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
