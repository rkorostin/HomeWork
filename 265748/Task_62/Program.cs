/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

Console.Clear();

Console.WriteLine($"Спиральный массив 4 x 4:");
int[,] array = new int[4, 4];
FillSpiralArray(array);
PrintArray(array);

//Наполнение массива.
void FillSpiralArray(int[,] inArray)
{
    int count = 1; // Начинаем "улитку" заполнять с "1"
    int i = 0;
    int j = 0;

    while (count <= inArray.GetLength(0) * inArray.GetLength(1))
    {
        inArray[i, j] = count;
        count++;
        if (i <= j + 1 && i + j < inArray.GetLength(1) - 1) // все элементы "верх" матрицы
            j++;
        else if (i < j && i + j >= inArray.GetLength(0) - 1) // все элементы "право" матрицы
            i++;
        else if (i >= j && i + j > inArray.GetLength(1) - 1) // все элементы "низ" матрицы
            j--;
        else
            i--; // все элементы "лево" матрицы
    }
}

//Печать массива
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