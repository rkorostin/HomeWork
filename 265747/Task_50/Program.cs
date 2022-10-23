/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном 
массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
Комментарии преподавателя: В примере некорректно. Выполнять по описанию задачи.
*/

Console.Clear();
// Уточняем у пользователя размер двумерного массива
int rowsArray = GetNumberByUser("Введите количество строк массива: ", "Ошибка ввода! Нужно натуральное число");
int colsArray = GetNumberByUser("Введите количество столбцов массива: ", "Ошибка ввода! Нужно натуральное число");

Console.WriteLine($"Задан массив {rowsArray}х{colsArray}:");
int[,] array = FillArray(rowsArray, colsArray, 2, 8); // Заполняем массив радномно от 2 до 8
PrintArray(array); // Печатаем массив

// Уточняем у пользователя позицию элемента в массиве
int positionRowInArray = GetPositionByUser("Введите позицию элемента в строке: ", "Ошибка ввода! Нужно положительное целое число");
int positionColumnInArray = GetPositionByUser("Введите позицию элемента в столбце: ", "Ошибка ввода! Нужно положительное целое число");

// Если введенная позиция элемента находится внутри массива, то выводим на печать,
// иначе - сообщаем, что такой позиции в массиве нет
if (positionRowInArray < rowsArray && positionColumnInArray < colsArray)
{
    Console.WriteLine($"Ваш элемент -> {array[positionRowInArray, positionColumnInArray]}");
}
else Console.WriteLine("Такой позиции в массиве нет!Помните, что позиция элемента в массиве начинается с 0");

// Метод рандомного наполнения массива целыми числами
int[,] FillArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
// Метод печати массива
void PrintArray(int[,] inArray)
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
// Метод для получения номера >= 0
int GetPositionByUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine() ?? "", out int userInput) && userInput >= 0;
        if (isCorrect)
            return userInput;
        Console.WriteLine(errorMessage);
    }
}
// Метод для получения номера > 0
int GetNumberByUser(string message, string errorMessage)
{
    while (true)
    {
        int userInput = GetPositionByUser(message, errorMessage);
        if (userInput > 0)
        {
            return userInput;
        }
        Console.WriteLine(errorMessage);
    }
}