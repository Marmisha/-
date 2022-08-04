//Семинар 9 задача 4
// Напишите программу, которая на вход принимает два числа A и B 
// и возводит A в целую степень B с помощью рекурсии.

Console.Clear();



int GetIntFromReadLine(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}


// Метод возведения числа в степень с помощью рекурсии
int NumberPow(int inputNumberOne, int inputNumberTwo)
{

    if (inputNumberTwo == 0) // Для этой задачи пусть будет так
    {
        return 1;
    }
    return (NumberPow(inputNumberOne, inputNumberTwo - 1) * inputNumberOne);
}



int A = GetIntFromReadLine("Введите число A: ");
int B = GetIntFromReadLine("Введите число B: ");
int myResult = NumberPow(A, B);
System.Console.WriteLine($"{A} в степени {B} равно {myResult}.");