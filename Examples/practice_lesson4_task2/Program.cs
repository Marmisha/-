//Задача 2: Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N.
//4->24
//5->120
Console.Clear();


/* Вариант 1:
int prompt(string message) // методна прием цифры от пользоватиеля
{
	Console.Write(message);
	string number = Console.ReadLine();
	int numInt = int.Parse(number);
	return numInt;
}
int number = prompt("Введите число: ");
int i = 0;
// поканамбер больше нуля, 
while (number >0)
{
    number = number/10;
    i++;
    Console.WriteLine($"{i} деление - {number}");
}
Console.WriteLine($"Количество символов - {i}");
*/







// Вариант 2:
int CountDigit(int number)
{
	int i = 0;
	while (number > 0)
	{
    number = number / 10;
    i++;
    Console.WriteLine($"{i} деление - {number}");
	}
	return i;
}

int prompt(string message) //
{
    Console.Write(message);
    string NumberStr = Console.ReadLine();
    int number = int.Parse(NumberStr);
    return number;
}
int i = 0;

Console.WriteLine($"Количество символов = {CountDigit(number)}");



