// На входе - число, на выходе выдаёт является ли число чётным 
// (делится ли оно на два без остатка).
Console.WriteLine("Введите число: ");
string userInput = Console.ReadLine() ?? "";
int num = int.Parse(userInput);

if (num % 2 == 0)
{
    Console.WriteLine("Число " + num + " чётное");
}
else
{
    Console.WriteLine("Число " + num + " нечётное"); 
}
