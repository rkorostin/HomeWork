/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение 
двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

Определение.
Результатом умножения матриц Am×n и Bn×k будет матрица Cm×k такая, что элемент матрицы C,
стоящий в i-той строке и j-том столбце (cij), равен сумме произведений элементов i-той строки
матрицы A на соответствующие элементы j-того столбца матрицы B:

cij = ai1 · b1j + ai2 · b2j + ... + ain · bnj

Замечание.
Две матрицы можно перемножить между собой тогда и только тогда, когда количество столбцов 
первой матрицы равно количеству строк второй матрицы.
*/

Console.Clear();

Console.WriteLine($"Матрица А:");
int[,] arrayA = FillArray(2, 2, 3); 
PrintArray(arrayA);

Console.WriteLine($"\nМатрица B:");
int[,] arrayB = FillArray(2, 3, 3); 
PrintArray(arrayB);

Console.WriteLine($"\nМатрица С:");
int[,] arrayC = MatrixMultiplication(arrayA, arrayB);
PrintArray(arrayC);

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

//Перемножаем матрицы
int[,] MatrixMultiplication(int[,] arrayA, int[,] arrayB)
{
/*  if (arrayA.GetLength(1) != arrayB.GetLength(0)) Console.WriteLine("Матрицы нельзя перемножить");
Это доп условие, когда матрицы можно перемножать. Но в данном случае это лишнее, т.к.
матрицы я задаю сам */
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            for (int k = 0; k < arrayA.GetLength(1); k++)
            {
                arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
            }
        }
    }
    return arrayC;
}