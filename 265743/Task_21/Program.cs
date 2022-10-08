/*
Задача 21. Напишите программу, которая принимает на вход координаты двух
точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7) -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

// Создаём статический метод, который будет возвращать текст 
// пользователя с координатами
static int coordinate(string message)
{
    Console.Write(message); // Сообщение пользователю
    int result = int.Parse(Console.ReadLine() ?? ""); // Введённое пользователем число
    return result; // вовзращаем введенное значение пользователя
}

// Создаём сообщение пользователю (строка 12) со вводом переменных (координат точек А и В)
int x1 = coordinate("Введите координату x точки А: ");
int y1 = coordinate("Введите координату y точки А: ");
int z1 = coordinate("Введите координату z точки А: ");
int x2 = coordinate("Введите координату x точки В: ");
int y2 = coordinate("Введите координату y точки В: ");
int z2 = coordinate("Введите координату z точки В: ");

// Метод (Distanse), который получает координаты и возвращает значение (result) типа double
static double Distanse(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
    return result;
}

// Вызываем созданный метод (строки 25-30) 
double length = Math.Round(Distanse(x1, y1, z1, x2, y2, z2), 2); // Округляем до сотых (как просят в задаче)
Console.WriteLine($"A ({x1},{y1},{z1}); B ({x2},{y2},{z2}) -> {length}");
