//Возвести a в степень n


//Метод возведения в степень с помощью цикла:
int PowerFor(int a, int n) // a - основание степени, n - показатель степени
{ int result = 1;
 for (int i = 1; i <= n; i++) result *= a;
 return result;
}


// Метод возведения в степень с помощью рекурсии:
int PowerRec(int a, int n)
{ //return n == 0 ? 1 : PowerRec(a, n - 1) * a;
 if (n == 0) return 1; // условие выхода
 else return PowerRec(a, n - 1) * a; // выше в комментарии вариант написания этих двух строк в одну строку
}
//Тут приняли ноль в степени ноль как единичку для этого случая



// Но! Вспоминаем курс математики и переписываем код:
int PowerRecMath(int a, int n)
{
 if (n == 0) return 1;
 else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
 else return PowerRecMath(a, n - 1) * a;
}
Console.WriteLine(PowerFor(2, 10)); // 1024
Console.WriteLine(PowerRec(2, 10)); // 1024
Console.WriteLine(PowerRecMath(2, 10)); // 1024