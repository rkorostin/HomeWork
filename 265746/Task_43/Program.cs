/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.Clear();

Console.WriteLine("Для системы уравнений:\ny = k1 * x + b1 \ny = k2 * x + b2");
double b1 = GetNumberByUser("Введите значение b1: ", "Ошибка ввода! Нужно число");
double k1 = GetNumberByUser("Введите значение k1: ", "Ошибка ввода! Нужно число");
double b2 = GetNumberByUser("Введите значение b2: ", "Ошибка ввода! Нужно число");
double k2 = GetNumberByUser("Введите значение k2: ", "Ошибка ввода! Нужно число");

if (b2 != b1 && k1 == k2) Console.Write("Cистема не имеет решений -> Две прямые параллельны!");
else if (b2 == b1 && k1 == k2) Console.Write("Cистема имеет бесконечное множество решений -> Две прямые совпали!");
else
{  
    double X = GetFindX(k1, k2, b1, b2);
    double Y = GetFindY(k2, b2, X);
    Console.WriteLine($"Ответ: x={X}; y={Y};");
}

//-----------------------------------Методы--------------------------------------------------
//Запрос пользователю на ввод числа
double GetNumberByUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = double.TryParse(Console.ReadLine() ?? "", out double userInput);
        if (isCorrect)
            return userInput;
        Console.WriteLine(errorMessage);
    }
}

//Поиск х
double GetFindX(double k1, double k2, double b1, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}
//Поиск y
double GetFindY(double k2, double b2, double X)
{
    double y = k2 * X + b2;
    return y;
}