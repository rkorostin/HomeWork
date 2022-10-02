// На входе число (N), а на выходе показывает все нечётные числа от 1 до N.
// Например, 8 -> 1, 3, 5, 7
Console.WriteLine("Введите число: ");
string userInput = Console.ReadLine() ?? "";
int num = int.Parse(userInput);
int count = -1;

Console.Write(num + " -> ");
while (count < num - 1)
{
    count += 2;
    Console.Write(count + " ");
}

