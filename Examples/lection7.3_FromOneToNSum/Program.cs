// Сумма чисел от 1 до n

Console.Clear();

//Самый простой способ (итеративный вариант)
int SumFor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++)
        result += i;
    return result;
}

// Сумма чисел от 1 до n (с помощью рекурсии):
int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}

System.Console.WriteLine(SumFor(10));//55
System.Console.WriteLine(SumRec(10)); // 55

