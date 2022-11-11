/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29

https://ru.wikipedia.org/wiki/%D0%A4%D1%83%D0%BD%D0%BA%D1%86%D0%B8%D1%8F_%D0%90%D0%BA%D0%BA%D0%B5%D1%80%D0%BC%D0%B0%D0%BD%D0%B0
       Формула                             Условие
        | n + 1,                         m = 0;
A(m,n)= | A(m - 1, 1),                   m > 0, n = 0;
        | A(m - 1, A(m, n - 1)),         m > 0, n > 0
*/

int numA = GetNumberFromUser("Введите число M (от 0 до 3): ", "Ошибка ввода");
int numB = GetNumberFromUser("Введите число N (от 0 до 3): ", "Ошибка ввода!");

Console.WriteLine($"A({numA},{numB}) = {Akkerman(numA, numB)}");

//Вычисления функции Аккермана с помощью рекурсии
int Akkerman(int m, int n)
{
    if (m == 0) return n + 1; // 8 строка формулы
    if (m > 0 && n == 0) return Akkerman(m - 1, 1); // 9 строка формулы
    return Akkerman(m - 1, Akkerman(m, n - 1)); // 10 строка формулы
}

//Запрашиваю у пользователя
int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int num) && num >= 0 && num < 4;
        if (isCorrect)
            return num;
        Console.WriteLine(errorMessage);
    }
}
