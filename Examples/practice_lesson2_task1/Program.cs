/*Напишите программу, которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа.
456->6
782->2
918->8
*/
Console.Clear();
Console.WriteLine("Привет, введи трехзначное число!");
string numString = Console.ReadLine();
int numInt = int.Parse(numString);

if (numInt > 99 && numInt < 1000) // проверка правильности введенного числа
    {
    Console.Write($"Итак, это {numInt}, а последняя цифра числа: " + numInt % 10);
    }   
    else
    {
        Console.WriteLine("Введено неверное число!");
    }
