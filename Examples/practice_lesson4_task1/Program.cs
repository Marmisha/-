// Задача 1: Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36


/* ВАРИАНТ 1:
int Prompt(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    int numInt = int.Parse(number);
    return numInt;
}

int SumA(int maxNumber)
{
    int answer = 0;
    for (int i = 1; i <= maxNumber; i++)
    {
        answer += i; // answer = answer + 1
    }
	return answer;
}

int numberA = Prompt("Введите число =>");
Console.WriteLine($"Сумма от 1 до {numberA} равна {SumA(numberA)}");
*/






/*ВАРИАНТ 2:
int Prompt(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    int numInt = int.Parse(number);
    return numInt;
}

int SumA(int maxNumber)
{
    int answer = 0;
    for (int i = 1; i <= maxNumber; i++)
    {
        answer += i; // answer = answer + 1
    }
    return answer;
}

int SumAGauss(int maxNumber)
{
    return maxNumber * (maxNumber + 1) / 2;
}

int numberA = Prompt("Введите число =>");
Console.WriteLine($"Сумма от 1 до {numberA} равна {SumA(numberA)}");
Console.WriteLine($"Гаусс сумма {SumAGauss(numberA)}");
*/





