// На вход принимается два числа и выдаёт, какое число большее, а какое меньшее.
// Например, [5,2] -> max = 5, min = 2
Console.WriteLine("Введите первое число: "); // Выводим информацию в консоль
string userInput1 = Console.ReadLine() ?? ""; /* Вводим переменную "userInput1" 
типа string. Всё, что будет введено в консоль будет передано в переменную
"userInput" через метод Console.ReadLine()*/
int num1 = int.Parse(userInput1); /* Вводим переменную "num1" типа int.
Преобразуем значение переменной "userInput1" в число */

Console.WriteLine("Введите второе число: ");
string userInput2 = Console.ReadLine() ?? "";
int num2 = int.Parse(userInput2);

if (num1 > num2)  // Если первое введенное число больше второго, то
{
    Console.WriteLine("[" + num1 + "," + num2 + "]" + " -> " + "max = " + num1 + ", " + "min = " + num2);
}
else if (num1 < num2)  // Если первое введенное число меньше второго, то
{
    Console.WriteLine("[" + num1 + "," + num2 + "]" + " -> " + "max = " + num2 + ", " + "min = " + num1);
}
else // иначе
{
    Console.WriteLine("Введённые числа равны!"); // в случае, если первое = второму
}
