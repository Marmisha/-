//Собрать строку с числами от a до b, a<=b

//Итеративный подход (вариант 1):
string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)

    {
        result += $"{i} ";
    }
    return result;
}


//Рекурсия (вариант 2): 
string NumbersRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b); // текущее значение a + вызов копии метода, в котором а будет увеличена на единичку
    else return String.Empty; // условие окончания в случае невыполнения условия
}

System.Console.WriteLine( NumbersFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10
System.Console.WriteLine( NumbersRec(1, 10)); // 1 2 3 4 5 6 7 8 9 10
