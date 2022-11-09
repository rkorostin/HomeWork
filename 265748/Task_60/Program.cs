/*Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

Console.Clear();

Console.WriteLine($"Трёхмерный массив 2 x 2 x 2:");
int[,,] array3D = new int[2, 2, 2];
FillArrayNotRepeat(array3D);
PrintArray(array3D);

//Наполнение массива случайными неповторяющимися двузначными числами.
/*Задумка метода: Сначала создам одномерный массив, в котором кол-во элементов будет равно кол-ву 
элементов в трёхмерном массиве. Потом наполню одномерный массив случайными числами с проверкой на 
совпадение значений. Если значение совпало, то запускаю процесс new Random() заново. 
В итоге получу одномерный массив с неповторяющимися элементами. 
Затем останется все эти значения переместить в трёхмерный массив. 
*/
void FillArrayNotRepeat(int[,,] array3D)
{
    int[] array1D = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    for (int i = 0; i < array1D.Length; i++) 
    {
        array1D[i] = new Random().Next(10, 100);
        for(int j = 0; j < i; j++)
        {
            if(array1D[j] == array1D[i]) i--;
        }
    }
    int count = 0; 
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                array3D[x, y, z] = array1D[count];
                count++;
            }
        }
    }
}

//Выводим на печать
void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.WriteLine($"{inArray[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}