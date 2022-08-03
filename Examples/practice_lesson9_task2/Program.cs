//Семинар 9 Задача 2
//Задайте значения M и N. Напишите программу, которая рекурсивно выведет все натуральные числа в промежутке от M до N.



Console.Clear();



int GetIntFromReadLine(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}


//Метод, выводящий на экран все натуральные числа от number1 до number2:
void PrintAllNaturalNumberBetweenPoints(int number1, int number2)
{
    if (number1 > number2) // выходим, когда меньше или иравно 0.Если больше 0, идем по действиям Ифа
    {
        return;
    }
    System.Console.Write($"{number1}  ");
    PrintAllNaturalNumberBetweenPoints(number1 + 1, number2);

}

int N = GetIntFromReadLine("Введите число N: ");
int M = GetIntFromReadLine("Введите число M: ");
System.Console.WriteLine($"Будем выписывать натуральные числа от {N} до {M}: ");

PrintAllNaturalNumberBetweenPoints(N, M);