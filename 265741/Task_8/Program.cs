// На входе число (N), а на выходе показывает все чётные числа от 1 до N.
// Например, 8 -> 2, 4, 6, 8
Console.WriteLine("Введите число: ");
string userInput = Console.ReadLine() ?? "";
int num = int.Parse(userInput);
int count = 2;  // Вводим переменную "count", присваиваем ей значение 2

Console.Write(num + " -> ");
while (count <= num)  /* В цикле к переменной "count" прибавляем 2 и получаем
все чётные числа от 1 до введённого пользователем числа (переменная "num") */
{
    Console.Write(count + " ");
    count += 2;
}
