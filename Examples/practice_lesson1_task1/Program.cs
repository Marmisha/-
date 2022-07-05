// Напишите программу, которая на вход принимает два числа и проверяет, 
//является ли первое число квадратом второго.


Console.Clear();

Console.WriteLine("Введите 1 число");
String numberFirst = Console.ReadLine();
int numberFirstInt = int.Parse(numberFirst);

Console.WriteLine("Введите 2 число");
String numberSecond = Console.ReadLine();
int numberSecondInt = int.Parse(numberSecond);

Console.WriteLine("Первое число: " + numberFirstInt);
Console.WriteLine("Второе число: " + numberSecondInt);

int numberSecondSquare = numberSecondInt*numberSecondInt;
Console.WriteLine ($"Вот это квадрат второго числа: {numberSecondSquare}"); // или: Console.WriteLine ("Это квадрат второго числа: " + numberSecondSquare);
if (numberFirstInt == numberSecondSquare)
{
    Console.WriteLine("Первое число - это второе в квадрате");
}
else
{
    Console.WriteLine("Давайте придумаем другие числа");
}