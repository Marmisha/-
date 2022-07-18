//Собрать строку с числами от a до b, a<=b (от большего к меньшему)

//Итеративный подход (вариант 1):
string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i >= b; i--)

    {
       result += $"{i} ";
    }
    return result;
}


//Рекурсия (вариант 2): 
string NumbersRec(int a, int b)
{
    if (a <= b) return NumbersRec(a + 1, b) + $"{a} "; // текущее значение a + вызов копии метода, в котором а будет увеличена на единичку
    else return String.Empty; // условие окончания в случае невыполнения условия
}

System.Console.WriteLine(NumbersFor(10, 1)); // 10 9 8 7 6 5 4 3 2 1 
System.Console.WriteLine(NumbersRec(1, 10)); // 10 9 8 7 6 5 4 3 2 1 
