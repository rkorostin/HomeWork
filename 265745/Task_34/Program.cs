// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

// Запрашиваем у пользователя длину массива
int userInput = GetNumberForLengthArray("Сколько элементов будет в массиве: ", "Нужно любое натуральное число");
// Создаём массив с количеством элементов, которые указал пользователь
int[] array = new int[userInput];
// Заполняем созданный массив рандомными числами (от 100 до 999)
FillRndArray(array, userInput);
// Подсчитываем сколько в массиве чётных чисел
GetCountPrint(array);

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

void FillRndArray(int[] array, int userInput)
{
    Console.Write("[");
    for (int index = 0; index < (array.Length - 1); index++)
    {
        array[index] = new Random().Next(100, 1000);
        Console.Write($"{array[index]}, ");
    }
    array[array.Length - 1] = new Random().Next(100, 1000);
    Console.Write($"{array[array.Length - 1]}]");
}

void GetCountPrint(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    if (array[i] % 2 == 0) count++;

    Console.WriteLine($"\nИз {array.Length} элементов массива -> {count} чётных");
}