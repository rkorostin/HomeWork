// На входе - три числа, на выходе выдаёт максимальное из этих чисел.
Console.WriteLine("Введите три числа: ");
string userInput1 = Console.ReadLine() ?? "";
int num1 = int.Parse(userInput1);

string userInput2 = Console.ReadLine() ?? "";
int num2 = int.Parse(userInput2);

string userInput3 = Console.ReadLine() ?? "";
int num3 = int.Parse(userInput3);

int max = num1;
if (num1 > max) max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;
Console.Write("max[" + num1 + "," + num2 + "," + num3 + "]" + "->" + max);

