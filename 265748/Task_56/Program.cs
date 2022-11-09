/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов: 1 строка
*/

Console.Clear();

Console.WriteLine($"Исходный массив:");
int[,] array = FillArray(4, 4, 9); //Создаю исходный двумерный массив (как в примере)
PrintArray(array); //Печатаю двумерный массив

int[] average = GetAvarageRow(array); //Нахожу сумму в строках и делаю из них одномерный массив
int row = GetMinAvarageRow(average); //Ищу номер min индекса (или номер строки) в одн. массиве
Console.WriteLine($"\nНомер строки с наименьшей суммой элементов: {row} строка");

//Наполняем массив случайными числами
int[,] FillArray(int y, int x, int value)
{
    int[,] result = new int[y, x];
    for (int i = 0; i < y; i++)
    {
        for (int j = 0; j < x; j++)
        {
            result[i, j] = new Random().Next(0, value + 1);
        }
    }
    return result;
}

//Выводим на печать массив
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

//Поиск суммы элементов во всех строках
int[] GetAvarageRow(int[,] inArray)
{
    int[] average = new int[inArray.GetLength(0)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            average[i] += inArray[i, j];
        }
    }
    return average;
}

//Поиск наименьшей суммы в строках
int GetMinAvarageRow(int[] average)
{
    int minValue = average[0];
    int row = 1;
    for (int i = 1; i < average.Length; i++)
    {
        if (average[i] < minValue)
        {
            minValue = average[i];
            row = i + 1;
        }
    }
    return row;
}