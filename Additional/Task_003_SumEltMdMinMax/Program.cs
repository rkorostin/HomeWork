// Поиск суммы элементов массива, находящихся между min и max элементов

void FillArray(int[] elements)
{
    int N1 = elements.Length;
    int index1 = 0;

    while (index1 < N1)
    {
        elements[index1] = new Random().Next(1, 100);
        index1++;
    }
}

void PrintArray(int[] elements2)
{
    int N2 = elements2.Length;
    int index2 = 0;

    while (index2 < N2)
    {
        Console.WriteLine(elements2[index2]);
        index2++;
    }
}

int[] array = new int[4];
int N = array.Length;
int index = 0;
int iMax = 0;

FillArray(array);
PrintArray(array);

while (index < N)
{
    if (array[index] > array[iMax])
    {
        iMax = index;
        index++;
    }
    else
    {
        index++;
    }
}

int index2 = 0;
int iMin = 0;

while (index2 < N)
{
    if (array[index2] < array[iMin])
    {
        iMin = index2;
        index2++;
    }
    else
    {
        index2++;
    }
}

Console.WriteLine("Минимальный ин = " + array[iMin] + " Максимальный ин = " + array[iMax]);

int Sum = 0;

while ((N - iMax) < (N - iMin))
{
    if ((iMin + 1) < iMax)
    {
        Sum = Sum + array[iMin + 1];
        iMin++;
    }
    else
    {
        iMin++;
    }
Console.WriteLine(Sum);   
}
while ((iMax + 1) < iMin)
    {
        Sum = Sum + array[iMax + 1];
        iMax++;
    }

Console.WriteLine(Sum);


