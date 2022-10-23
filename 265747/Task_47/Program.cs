/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Console.Clear();
// Уточняем у пользователя размер двумерного массива
int rowsArray = GetNumberByUser("Введите количество строк массива: ", "Ошибка ввода! Нужно натуральное число");
int colsArray = GetNumberByUser("Введите количество столбцов массива: ", "Ошибка ввода! Нужно натуральное число");

double[,] array = FillArray(rowsArray, colsArray, 100); // Заполняем массив радномно от 0 до 100
Console.WriteLine($"Задан массив {rowsArray}х{colsArray} из вещественных чисел:");
PrintArray(array); // Печатаем массив

// Метод рандомного наполнения массива вещественными числами
double[,] FillArray(int m, int n, int value)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(value + 1) * 0.01;
        }
    }
    return result;
}
// Метод вывода на печать массива
void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
// Метод для получения номера > 0
int GetNumberByUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine() ?? "", out int userInput) && userInput > 0;
        if (isCorrect)
            return userInput;
        Console.WriteLine(errorMessage);
    }
}