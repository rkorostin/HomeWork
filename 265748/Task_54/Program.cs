/* Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

Console.Clear();

Console.WriteLine($"Исходный массив:");
int[,] array = FillArray(3, 4, 10);
PrintArray(array);

Console.WriteLine($"\nОтсортированный массив:");
SortArray(array);
PrintArray(array);

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

//Выводим на печать
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

//Сортируем элементы в строках по убыванию
void SortArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < inArray.GetLength(1); k++)
            {
                if (inArray[i, k] > inArray[i, j])
                {
                    int max = inArray[i, k];
                    inArray[i, k] = inArray[i, j];
                    inArray[i, j] = max;
                }
            }
        }
    }
}