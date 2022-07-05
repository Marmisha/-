// Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов числе от 1 до N.
//5-> 1,4,9,16,25.
//2->124
Console.Clear();

int Prompt(string message)
{
    Console.WriteLine(message);
    string param = Console.ReadLine();
    return int.Parse(param);// Иными словами: что мы введем, вернется как int.
}
int N = Prompt("Введите число N: ");
Console.WriteLine($"Вы ввели число {N}");
Console.WriteLine($"Выясним, какие числа лежат от 1 до {N}.");

int i = 0;

while (i < N)
{
    i++;
     Console.WriteLine(i * i);
}