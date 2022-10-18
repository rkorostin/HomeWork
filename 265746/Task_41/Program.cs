/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

Console.Clear();

int num = GetNumberByUser("Сколько чисел будет введено? ", "Ошибка ввода! Нужно любое натуральное число");
//Создаю массив из одних нулей. Кол-во нулей равно числу, которое ввёл пользователь
int[] array = new int[num];

FillandPrintArray(array);
CountPositiveNum(array);

//-----------------------------------Методы--------------------------------------------------
//Запрос пользователю на ввод числа
int GetNumberByUser(string message, string errorMessage)
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

// Заполнение массива числами через ввод в консоль и вывод их (как в задании)
void FillandPrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1}-ое число: ");
        array[i] = EnterElementsArray(i, "Ошибка ввода! Введите любое целое число!");
    }
    Console.Write(String.Join(", ", array));
}

//Для обхода исключений при вводе пользователем не чисел
int EnterElementsArray(int element, string errorMessage)
{
    while (true)
    {
        bool isCorrect = int.TryParse(Console.ReadLine() ?? "", out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

//Считаем положительные числа
int CountPositiveNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    Console.WriteLine($" -> {count}");
    return count;
}