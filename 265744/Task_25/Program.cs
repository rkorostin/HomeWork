/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
// Из семинара - задачу надо решить через отдельный метод, который возводит число 
// в степень. Т.е. использовать математическую функцию Math.Pow нельзя!

// -------------------------- Начало программы -------------------------------------
Console.Clear();

int number = GetNumberByUser("Введите число: ", "Ошибка! Нужно ввести любое целое число!");
int degree = GetDegreeByUser("Введите степень: ", "Ошибка! Нужно ввести натуральное число!");
Elevation(number, degree);
// -------------------------- Конец программы --------------------------------------

// -------------------------- Определение методов ----------------------------------
// Метод GetNumberByUser запрашивает число, которое надо возвести в степень.
// Число может быть и отрицательным и положительным, но целым!
int GetNumberByUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message); // вывод в консоль сообщения
        bool isCorrect = int.TryParse(Console.ReadLine(), out int num); // преобразовывает введённую пользователем строку в число типа int.       
        if (isCorrect)
            return num;
        Console.WriteLine(errorMessage); // В случае ошибки выводит в консоль сообщение errorMessage
    }
}
// Метод GetDegreeByUser запрашивает степень, в которую надо возводить число.
// Число может быть и отрицательным и положительным.
int GetDegreeByUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int num) && num > 0;
        if (isCorrect)
            return num;
        Console.WriteLine(errorMessage);
    }
}
/* Создание метода Elevation для выполнения действий над введёнными пользователем
данными. В теле метода Elevation используется цикл for для 
возведения числа в степень.
*/
int Elevation(int number, int degree)
{
    int numberInDegree = 1;
    for (int i = 0; i < degree; i++)
    {
        numberInDegree *= number;
    }
    Console.WriteLine($"{number} ^ {degree} = {numberInDegree}");
    return numberInDegree;
}
// -------------------------- Конец определения методов ----------------------------