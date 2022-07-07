// Задача: напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существаовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: // каждая сторона треугольника меньше суммы двух других сторон.

Console.Clear();


//Вариант мой:
// int MethodIntFromReadLine(string message)
// {
//     Console.Write(message);
//     string number = Console.ReadLine();
//     int numInt = int.Parse(number);
//     return numInt;
// }


// int numberOne = MethodIntFromReadLine("Введите первое число: ");
// int numberTwo = MethodIntFromReadLine("Второе число: ");
// int numberThree = MethodIntFromReadLine("Третье: ");
// Console.WriteLine($"Вы ввели {numberOne}, {numberTwo} и {numberThree}.");


// if (numberOne+numberTwo<numberThree|| 
// numberOne+numberThree<numberTwo || 
// numberTwo+numberThree<numberOne)
// System.Console.WriteLine($"Треугольник со сторонами {numberOne}, {numberTwo} и {numberThree} может существовать.");
// else {System.Console.WriteLine("Невозможен такой треугольник");}







//Вариант другой:

int MethodIntFromReadLine(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    int numInt = int.Parse(number);
    return numInt;
}



bool Check(int numOne, int numTwo, int numTree)
{
    return (numOne+numTwo < numTree|| numOne+numTree<numTwo || numTwo+numTree<numOne);
}


int numberOne = MethodIntFromReadLine("Введите первое число: ");
int numberTwo = MethodIntFromReadLine("Второе число: ");
int numberThree = MethodIntFromReadLine("Третье: ");
Console.WriteLine($"Вы ввели {numberOne}, {numberTwo} и {numberThree}.");
Console.WriteLine(Check(numberOne, numberTwo, numberThree));