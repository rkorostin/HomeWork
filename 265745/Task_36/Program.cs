// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

// Запрашиваем у пользователя длину массива
int userInput = GetNumberForLengthArray("Сколько элементов будет в массиве: ", "Нужно любое натуральное число");
// Создаём массив с количеством элементов, которые указал пользователь
int[] array = new int[userInput];
// Заполняем созданный массив рандомными числами (от -5 до 5)
FillRndArray(array);
// Подсчитываем сумму элементов на нечётных позициях
GetSumOddInxPrint(array);

//-------------------------------------------Методы------------------------------------------------------
int GetNumberForLengthArray(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine() ?? "", out int userInput) && userInput > 0;
        if (isCorrect)
            return userInput;
        Console.WriteLine(errorMessage);
    }
}

void FillRndArray(int[] array)
{
    Console.Write("[");
    for (int index = 0; index < (array.Length - 1); index++)
    {
        array[index] = new Random().Next(-5, 5);
        Console.Write($"{array[index]}, ");
    }
    array[array.Length - 1] = new Random().Next(-5, 5);
    Console.Write($"{array[array.Length - 1]}]");
}

void GetSumOddInxPrint(int[] array)
{
    int Sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (i % 2 == 1) Sum += array[i];

    Console.WriteLine($"\nСумма элементов массива на нечётных позициях -> {Sum}");
}