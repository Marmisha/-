// Семинар 10 задача 1
// Напишите программу, которая на вход принимает два числа и выдает 
// первые N чисел, для которых каждое следующее равно сумме двух предыдущих

Console.Clear();



long GetIntFromReadLine(string message)
{
    Console.Write(message);
    long numInt = long.Parse(Console.ReadLine());
    return numInt;
}



long Fibonacci(long num1, long num2, long num)
{
    if (num == 0) return 0;
    System.Console.WriteLine(num1);
    long temp = Fibonacci(num2, num2 + num1, num - 1) + num1;
    return temp;
}


long num1 = GetIntFromReadLine("Введите 1-ое число: ");
long num2 = GetIntFromReadLine("Введите 2-ое число: ");
long num = GetIntFromReadLine("Введите число: ");
//System.Console.WriteLine($"Ваши числа: {num1} и {num2}.");

Fibonacci(num1, num2, num);









