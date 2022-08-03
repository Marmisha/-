// Семинар 9 Задача 1
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N при помощи рекурсии.
// N=5 -> "1,2,3,4,5"
// N=6 -> "1,2,3,4,5,6"


Console.Clear();



int GetIntFromReadLine(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}


//Метод, выводящий на экран все натуральные числа от 0 до заданного числа N:
void PrintNatural(int number)
{
    if (number <= 0) // выходим, когда меньше или иравно 0.Если больше 0, идем по действиям Ифа
    {
        return;
    }
    System.Console.Write($"{number} v "); 
    PrintNatural(number - 1);
    System.Console.Write($"{number} ^ ");

        // в зависимости о ттго, где относительно рекурсии стоит cw, меняется результат вывода

}

int N = GetIntFromReadLine("Введите число N: ");
System.Console.WriteLine("Наше число: " + N + ".");

PrintNatural(N);