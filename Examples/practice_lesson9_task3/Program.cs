//Семинар 9 Задача 3
// Напишите программу, которая принимает на вход число и возвращает сумму состаляющих его цифр (с исползованием рекурсии)
// 453 -> 12
// 45 > 9


Console.Clear();



int GetIntFromReadLine(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}



// Тот же метод подсчета суммы чисел, составляющих заданное число, но с рекурсией:
int GetSumOfNumbersOfInputNumber(int inputNumber)
{
    if (inputNumber == 0) // если заданное число 0, считать нечего, сумма 0.
    {
        return 0;
        Console.WriteLine("Сумма составляющих число чисел равна 0");
    }
    int remainderOfDiv =inputNumber%10; //текущий остаток от деления, то, что прибавляем к сумме
    int sum = remainderOfDiv;
    System.Console.WriteLine($"Сейчас к сумме прибавляем {sum}, а число для следующего цикла = {inputNumber/10}");
    return sum + GetSumOfNumbersOfInputNumber(inputNumber / 10);
    Console.WriteLine($"Сумма равна {sum}.");
}




int myNumber = GetIntFromReadLine("Введите число подлиннее: ");
int summa = GetSumOfNumbersOfInputNumber(myNumber);
System.Console.WriteLine(summa);
