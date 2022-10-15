// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

// Запрашиваем у пользователя длину массива
int userInput = GetNumberForLengthArray("Сколько элементов будет в массиве: ", "Нужно любое натуральное число");
// Создаём массив с количеством элементов, которые указал пользователь
double[] array = new double[userInput];
// Заполняем созданный массив рандомными вещественными числами (от -99 до 99).
FillRndArray(array, userInput);
// Узнаём максимальный элемент массива
GetМaxArray(array);
// Узнаём минимальный элемент массива
GetМinArray(array);

double result = GetМaxArray(array) - GetМinArray(array);
Console.WriteLine($"\nРазница между максимальным {GetМaxArray(array)} и минимальным {GetМinArray(array)} элементом -> {result}");

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

void FillRndArray(double[] array, int userInput)
{
    Console.Write("[");
    for (int index = 0; index < (array.Length - 1); index++)
    {
        array[index] = Convert.ToDouble(new Random().Next(-99, 100)) / 10;
        Console.Write($"{array[index]}, ");
    }
    array[array.Length - 1] = Convert.ToDouble(new Random().Next(-99, 100)) / 10;
    Console.Write($"{array[array.Length - 1]}]");
}

double GetМaxArray(double[] array)
{
    double Max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > Max) Max = array[i];
    }
    return Max;
}

double GetМinArray(double[] array)
{
    double Min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < Min) Min = array[i];
    }
    return Min;
}