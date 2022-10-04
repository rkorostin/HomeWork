// Записать массив в обратном порядке

void FillArray(int[] elements)
{
    int N1 = elements.Length;
    int index1 = 0;

    while (index1 < N1)
    {
        elements[index1] = new Random().Next(1, 10);
        index1++;
    }
}
void PrintArray(int[] col)
{
    int N2 = col.Length;
    int index2 = 0;

    Console.Write("Массив прямой   {");
    while (index2 < N2)
    {
        Console.Write(" " + col[index2]);
        index2++;
    }
    Console.WriteLine(" }");
}

int[] array = new int[9];
int index = 0;
int N = array.Length;
int temp = 0;

FillArray(array);
PrintArray(array);

while (index < N - 1)
{
    temp = array[N - 1];
    array[N - 1] = array[index];
    array[index] = temp;
    N = N - 1;
    index++;
}

void PrintArrayInv(int[] col)
{
    int N2 = col.Length;
    int index2 = 0;

    Console.Write("Массив инверсия {");
    while (index2 < N2)
    {
        Console.Write(" " + col[index2]);
        index2++;
    }
    Console.WriteLine(" }");
}

PrintArrayInv(array);
