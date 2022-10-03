// Поиск кол-ва максимальных элементов в массиве
int[] array = { 1, 21, 23, 45, 66, 66, 47, 28, 19 };
int index = 0;
int max = array[index];
int countMax = 0;

while (index < array.Length)
{
    if (array[index] > max)
    {
        max = array[index];
        countMax = 1;
    }
    else if (array[index] == max)
    {
        countMax++;
    }
    index++;
}
Console.WriteLine(countMax);
