
Console.Clear();

decimal fRec = 0; // подсчет вызова рекурсии
decimal fIte = 0; // подсчет итераций цикла для итеративного подходда

decimal FibonacciRecursion(int n)
{
    fRec++;
    return n == 0 || n == 1 ? 1 : FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
}

decimal FibonacciIteration(int n)
{
    fIte++;
    decimal result = 1;
    decimal f0 = 1;
    decimal f1 = 1;
    for (int i = 2; i <= n; i++)
    {
        result = f0 + f1;

        f0 = f1;
        f1 = result;
        fIte++;
    }
    return result;
}


// # 1 2 3 4 5 6
// V 1 1 2 3 5 8

Console.ReadLine();
DateTime dt = DateTime.Now; // засечем время, когда начал выполняться код
for (int n = 10; n < 40; n++)
{
    System.Console.WriteLine($"FibonacciIteration({n})={FibonacciIteration(n)} fIte= {fIte.ToString("### ### ###"),-15}"); // все что в ToString - косметика
    fIte = 0;
}
System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

System.Console.WriteLine();
Console.ReadLine();
for (int n = 10; n < 40; n++)
{
    System.Console.WriteLine($"FibonacciRecursion({n})={FibonacciRecursion(n)} fRec = {fRec.ToString("### ### ###"),-15} ");
    fRec = 0;
}
