/*Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int from = GetNumber("Введите число M: ", "Ошибка ввода");
int to = GetNumber("Введите число N: ", "Ошибка ввода!");

if (from < to) Console.Write($"Сумма чисел между {from} и {to} -> {GetSumIntervalNaturals(from, to)}");
else Console.WriteLine($"Сумма чисел между {from} и {to} -> 0");

//Поиск суммы
int GetSumIntervalNaturals(int inFrom, int inTo)
{
    return inFrom == inTo ? inTo : inFrom + GetSumIntervalNaturals(inFrom + 1, inTo);
}

//Запрашиваю число у пользовтеля
int GetNumber(string message, string errorMessage)
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