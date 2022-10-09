﻿/* Задача 19. Напишите программу, которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Write("Введите пятизначное число: ");
int Number;
while (true)
{
    if (int.TryParse(Console.ReadLine(), out Number) && Number <= 99999 && Number >= 10000) // парсим введенное значение в тип int,
    // если не получается - просим ввести заново.
    // Также проверяем, чтобы число было пятизначным
    // C отрицательными числами Владимир сказал не работать
        break;
    Console.WriteLine($"Ошибка ввода! Попробуйте снова ввести любое число от 10000 до 99999");
}

if (Number / 10000==Number % 10 && (Number / 1000) % 10==(Number / 10) % 10) Console.WriteLine($"{Number} -> да");
else Console.WriteLine($"{Number} -> нет");


