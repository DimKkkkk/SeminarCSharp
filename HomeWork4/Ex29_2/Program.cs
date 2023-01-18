/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int N = CheckingTheArrayLengthEnteredByTheUser();
double[] array = ArrayFormation(N);
PrintArray(array)

int CheckingTheArrayLengthEnteredByTheUser()

double CheckingTheArrayLengthEnteredByTheUser()

double[] ArrayFormation(int N)
{
    double[] userArray = new double[N];
    int i = 0;
    while (N > 0)
    {
        userArray[i] = CheckingTheArrayLengthEnteredByTheUser();
        i++;
        N--;
    }
    return userArray;
}
