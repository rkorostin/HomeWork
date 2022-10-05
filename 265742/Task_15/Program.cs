/* Задача 15: Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Write("Введите любое целое число от 1 до 7: ");
int Number;
while (true)
{
    if (int.TryParse(Console.ReadLine(), out Number) && Number <= 7 && Number >= 1)
        break;
    Console.WriteLine($"Ошибка ввода! Попробуйте снова ввести любое число от 1 до 7");
}

if (Number == 1) Console.WriteLine($"{Number} -> Нет");
else if (Number == 2) Console.WriteLine($"{Number} -> Нет");
else if (Number == 3) Console.WriteLine($"{Number} -> Нет");
else if (Number == 4) Console.WriteLine($"{Number} -> Нет");
else if (Number == 5) Console.WriteLine($"{Number} -> Нет");
else if (Number == 6) Console.WriteLine($"{Number} -> Да");
else if (Number == 7) Console.WriteLine($"{Number} -> Да"); 