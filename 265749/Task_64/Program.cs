/*Задача 64: Задайте значение N.
Напишите программу, которая выведет все натуральные числа в 
промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int number = GetNumberByUser("Введите число: ", "Ошибка! Нужно ввести любое натуральное число!");
PrintNaturals(number);

//Рекурсия вывода чисел от N до 1
void PrintNaturals(int value)
{
    if (value > 0)
    {
        Console.Write($"{value} ");
        PrintNaturals(value - 1);
        //Console.Write($"{value} "); //Будет выводить от 1 до N (как на семинаре)
    }
}

//Запрашиваю число у пользовтеля
int GetNumberByUser(string message, string errorMessage)
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