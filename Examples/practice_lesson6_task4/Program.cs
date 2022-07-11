// Задача: не используя рекурсию, выведите первые N чисел Фибоначчи. Педрвые два числа: 0 т 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Clear();



int MethodIntFromReadLine(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    int numInt = int.Parse(number);
    return numInt;
}


/*
//Числа Фибоначчи
int Fibonacci(int n)
{
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
int count = 0;
for (int i = 1; i < count; i++) // посмотрим, как посчитаются первые 10 чисел
{
    Console.WriteLine(Fibonacci(i));
}
}
*/





//Числа Фибоначчи (чужой вариант, непонятный и не уверена, что правильный):
int Fibonacci(int n)
{
    int first = 0;
    int second = 1;
    int result = 0;
    if (n == 0) return 0;
    if (n == 1 || n == 2) return 1;
    System.Console.WriteLine(first + " ");
    System.Console.WriteLine(second + " ");
    for (int i = 1; i < n; i++) // посмотрим, как посчитаются первые 10 чисел
    {
        result = first + second;
        System.Console.WriteLine(result + " ");
        first = second;
        second = result;

    }
    return result;
}


int N = MethodIntFromReadLine("Введите число: ");
System.Console.WriteLine($"Вы ввели число {N}."); ;
Console.WriteLine(Fibonacci(N));