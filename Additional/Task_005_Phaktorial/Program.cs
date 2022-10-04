// Поиск факториала введенного числа N

Console.WriteLine("Введите число: ");
string userInput = Console.ReadLine() ?? "";
int num = int.Parse(userInput);

int N = 1;
int index = 1;

while (index <= num)
{
    N = N * index;
    index++;
}

Console.WriteLine("Факториал числа " + num + " -> " + N);