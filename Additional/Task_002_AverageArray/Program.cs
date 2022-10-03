// Поиск среднего арифметического среди всех элементов массива

void FillArray(int[] elements)
{
    int N = elements.Length;
    int index = 0;
    while (index < N)
    {
        elements[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int N1 = col.Length;
    int position = 0;
    Console.Write("Массив длиною " + N1 + " { ");
    while (position < N1)
    {
        Console.Write(col[position] + " ");
        position++;
    }
    Console.Write("}");
}

int[] array = new int[30];
FillArray(array);
PrintArray(array);

int L = array.Length;
int index = 0;
double sum = 0;
double average = 0;

while (index < L)
{
    sum = sum + array[index];
    index++;
}
average = sum / L;

Console.WriteLine(" -> " + average);




/*
int[] array = { 1, 2, 3, 4, 5, 6 };
int N = array.Length;
int index = 0;
double sum = 0;
double average = 0;

while (index < N)
{
    sum = sum + array[index];
    index++;
}
average = sum / N;

Console.WriteLine(average);
*/
