// 1. Вывод всех элементов массива.
int[] array = { 0, 1, 3, 4, 5, 6 };

// Через while
int i = 0;
while (i < array.Length)
{
    Console.Write(array[i]);
    i++;
}
// Через for
for (int y = 0; y < array.Length; y++)
{
    Console.Write(array[y]);
}

// 2. Вывод всех элементов массива в обратном порядке.
// Через while
int t = array.Length - 1;
while (t >= 0)
{
    Console.Write(array[t]);
    t--;
}
// Через for
for (int n = array.Length - 1; n >= 0; n--)
{
    Console.Write(array[n]);
}

// 3. Вывод чётных элементов массива.
// Через while
int q = 0;
while (q < array.Length)
{
    if (array[q] % 2 == 0)
    {
        Console.Write(array[q]);
        q++;
    }
    else
    {
        q++;
    }
}
// Через for
for (int i1 = 0; i1 < array.Length; i1++)
{
    int element = array[i1];

    if (element % 2 == 0)
    {
        Console.Write(element);
    }
}

// 4. Вывод всех элементов массива через 1.
// Через while
int w = 0;
while (w < array.Length)
{
    Console.Write(array[w]);
    w += 2;
}

// Через for
for (int i2 = 0; i2 < array.Length; i2 += 2)
{
    Console.Write(array[i2]);
}

// 5. Вывод всех элементов массива пока не встретится элемент 4.
// Через while
int r = 0;
int find = 4;
while (r < array.Length)
{
    if (array[r] != find)
    {
        Console.Write(array[r]);
        r++;
    }
    else
    {
        Console.Write(array[r]);
        break;
    }
}

// Через for
for(int i3 = 0; i3 < array.Length; i3++)
{
    int element = array[i3];

    if (element == 4)
        break;

    Console.Write(element);
}