/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит 
их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

Заметки:
Если брать приведённые примеры, то получается некорректная постановка задачи,
т.е. в задании массив из 8 элементов, а в ответе пример из 5-ти и 3-х элементов..
Пояснение от преподавателя на семинаре - задание нужно выполнить для ручного
заполнения массива.
После такого пояснения решил, что длинну массива пусть указывает сам пользователь
А далее будут запросы на ввод самих элементов
*/

// -------------------------- Начало программы -------------------------------------
Console.Clear();
int arrayLength = GetNumberForLengthArray("Укажите количество элементов массива: ", "Нужно натуральное число!");
PrintArray(arrayLength);
// -------------------------- Конец программы --------------------------------------

// -------------------------- Определение методов ----------------------------------
//Метод для ввода числа пользователем, которое будет длиной массива
//Введённое число должно быть > 0. Иначе вывод ошибки!
int GetNumberForLengthArray(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine() ?? "", out int userNumber) && userNumber > 0;
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

//Метод для обхода исключения. Т.е. если пользователем будет введено НЕ число 
//для элемента массива, то будет выведено сообщение, чтобы ввели именно число.
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

//Метод, по которому будут выводиться приглашения для ввода i-го элемента массива
//и в конце итоговый вывод получившегося массива
void PrintArray(int arrayLength)
{
    int[] array = new int[arrayLength];

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1}-ый элемент массива: ");
        array[i] = EnterElementsArray(i, "Ошибка ввода! Введите любое целое число!");
    }
    Console.Write("Массив создан: [");

    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[arrayLength - 1]}]");
}