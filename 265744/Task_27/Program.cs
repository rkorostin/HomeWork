/*
452 -> 11
82 -> 10
9012 -> 12
*/
// Из семинара - для подсчёта суммы цифр в введённом числе использовать операции 
// деления и взятия остатка

// -------------------------- Начало программы -------------------------------------
Console.Clear();

int number = GetNumberByUser("Введите число: ", "Ошибка! Нужно ввести любое целое положительное число!");
sumNumbers(number);
// -------------------------- Конец программы --------------------------------------

// -------------------------- Определение методов ----------------------------------
// Метод GetNumberByUser запрашивает число, которое надо возвести в степень.
// Число может быть и отрицательным и положительным, но целым!
int GetNumberByUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message); // вывод в консоль сообщения
        bool isCorrect = int.TryParse(Console.ReadLine(), out int num) && num >= 0; // преобразовывает введённую пользователем строку в число типа int.       
        if (isCorrect)
            return num;
        Console.WriteLine(errorMessage); // В случае ошибки выводит в консоль сообщение errorMessage
    }
}
// Создание метода sumNumbers для подсчёта суммы цифр в числе.
int sumNumbers(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    Console.WriteLine($"Сумма цифр -> {result}");
    return result;
}
/*
// Создание метода CountNumber для подсчёта разрядности введённого числа  
int CountNumber(int number)
{
    int count = 0;
    while (number > 0)
    {
        count++;
        number = number / 10;
    }
    return count;
}
// Создание метода sumNumbers для подсчёта суммы цифр в числе.
int SumNumber(int number)
{
    int whole = 0; // Целое правое число от первоначального. Например, 532 -> 2 
    int result = 0; // Суммы целых чисел (whole). 2 + 3 + 5
    int bitDepth = CountNumber(number); // Разрядность числа, 532 -> 3
    for (int i = 0; i < bitDepth; i++)
    {                                   //  инерация 1    инерация 2   инерация 3
        whole = number - number % 10;   // 2 = 532 - 530; 3 = 53 - 50;  5 = 5 - 0;
        result = result + (number - whole); // 2 = 0 + 2;   5 = 2 + 3; 10 = 5 + 5;
        number = number / 10;               // 532 -> 53;     53 -> 5; 5 -> 0;
    }
    Console.WriteLine($"Сумма цифр -> {result}");
    return result;
}
*/
// -------------------------- Конец определения методов ----------------------------