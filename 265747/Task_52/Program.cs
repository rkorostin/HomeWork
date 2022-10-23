/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.Clear();
// Уточняем у пользователя размер двумерного массива
int rowsArray = GetNumberByUser("Введите количество строк массива: ", "Ошибка ввода! Нужно натуральное число");
int colsArray = GetNumberByUser("Введите количество столбцов массива: ", "Ошибка ввода! Нужно натуральное число");

Console.WriteLine($"Задан массив {rowsArray}х{colsArray}:");
int[,] array = FillArray(rowsArray, colsArray, 0, 10); // Создаём и заполняем двумерный массив радномно от 0 до 10
PrintArray(array); // Печатаем двумерный массив
FindAndPrintAverage(array); //Находим average каждого столбца массива и выводим в консоль

// Метод вычисления average каждого столбца массива и вывод этого значения в консоль
void FindAndPrintAverage(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        double average = 0; //Среднее значение элементов в столбце
        int summa = 0; // Сумма элементов в столбце
        for (int j = 0; j < inArray.GetLength(0); j++)
        {
            summa += inArray[j, i];
        }
        average = (double)summa / rowsArray; // Возможно в 26 строке нужно сразу присвоить тип double...? Но это расход памяти...
        Console.WriteLine($"Среднее арифметическое {i + 1}-го столбца -> {Math.Round(average, 2)}");
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