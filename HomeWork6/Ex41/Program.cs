/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
Console.Clear();
Console.WriteLine("Выполняется создание массива... ");
Console.WriteLine();


int elements = GetCountElementsFromUser("Введите количество элементов массива: ", "Ошибка ввода!");

int GetCountElementsFromUser (string message, string errorMessage)
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

int[] array = new int [elements];
FillArrayFromUser(array);

void FillArrayFromUser (int[] el)
{
	int lengthArray = el.Length;
	for(int i = 0; i < lengthArray; i++)
	{
			Console.Write($"Введите {i}-й элемент массива: ");
			bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
			if(isCorrect)
				{
				el[i] = num;
				}
			else Console.WriteLine("Ошибка ввода!");
	}
}
Console.WriteLine();
Console.WriteLine($"[{String.Join(", ", array)}] - полученный массив из {elements} чисел.");
Console.WriteLine();
Console.Write($"[{String.Join(", ", array)}] -> ");

int KolBolshNul (int[] arr)
{
	int kol = 0;
	for(int i = 0; i < arr.Length; i++)
	{
		if(arr[i] > 0) kol++;
	}
	return kol;
}
Console.Write($"{KolBolshNul(array)} числа больше 0.");