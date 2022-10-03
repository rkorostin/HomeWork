// Поиск минимального и максимального индексов элементов в массиве

void FillArray(int[] elements)
{
    int index1 = 0;
    int N1 = elements.Length;

    while (index1 < N1)
    {
        elements[index1] = new Random().Next(1, 10);
        index1++;
    }
}

void PrintArray(int[] col)
{
    int index2 = 0;
    int N2 = col.Length;
    Console.Write("Массив {");
    while (index2 < N2)
    {
        Console.Write(" " + col[index2]);
        index2++;
    }
    Console.WriteLine(" }");
}

int[] array = new int[5];
int N = array.Length;
int index = 0;
int iMax = 0;
int iMin = 0;

FillArray(array);
PrintArray(array);

while (index < N)
{
    if (array[index] < array[iMin])
    {
        iMin = index;
        index++;
    }
    else if (array[index] > array[iMax])
    {
        iMax = index;
    }
    index++;
}

int sum = 0;
int finish = 0;

if (iMin < iMax)
{
    index = iMin + 1;
    finish = iMax;
}
else
{
    index = iMax + 1;
    finish = iMin;
}

while (index < finish)
{
    sum = sum + array[index];
    index++;
}

Console.WriteLine("iMin = " + iMin + " A[iMin] = " + array[iMin] + "; iMax= " + iMax
+ " A[iMax] = " + array[iMax] + "; Сумма между min и max -> " + sum);


