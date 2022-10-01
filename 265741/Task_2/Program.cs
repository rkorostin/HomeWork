// На вход принимается два числа и выдаёт, какое число большее, а какое меньшее.
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
    Console.WriteLine("max = " + num1);  // Выводим max = первое число
    Console.WriteLine("min = " + num2);  // Выводим min = второе число
}
else if (num1 < num2)  // Если первое введенное число меньше второго, то
{
    Console.WriteLine("max = " + num2); // Выводим max = второе число
    Console.WriteLine("min = " + num1); // Выводим min = первое число
}
else // иначе
{
    Console.WriteLine("Введённые числа равны!"); // в случае, если первое = второму
}
