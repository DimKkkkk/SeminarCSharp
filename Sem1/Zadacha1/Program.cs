// Задача: вводить число и программа должна обработать и выдать результат в квадрате
Console.Write("Введите целое число: ");  // организация пользовательского ввода
string userInput = Console.ReadLine() ?? "";

int number = int.Parse(userInput); //либо в скобки Парс вставляем Console.ReadLine() ?? "", тогда строка 3 нам не нужна
int result = number * number; // или int result = (int)Math.Pow(number, 2); 2 - это возведение в квадрат. Функция Pow возводит в квадрат
//или double result = Math.Pow(number, 2); вместо int вначале пишем double.
Console.WriteLine($"{number} -> {result}"); //знак доллара $ позволяет нам использовать фигурные скобки и показать результат значения в таком виде

