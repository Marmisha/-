// Напишите программу, которая принмиает ан вход число N и выдает произведение чисел от 1 до N.
// 4-> 24
// 5-> 120


int Prompt(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    int numInt = int.Parse(number);
    return numInt;
} /* т.е. мы имеем первую функцию, которая предлагает ввести число, съедает его
и переводит в integer*/


int multiplyA(int maxNumber) // maxnumber, исходя из условия - наше заданное число
{
    int answer = 1; // пока наша сумма равна 0
    for (int i = 1; i<= maxNumber; i++)
    {
        answer = answer*i; // иначе: multiply = multiply * i
    }
    return answer;
} // тут мы имеем вторую функцию, которая ищет произведение


//и тут мы уже сначала спрашиваем и переформатируем наше число из string в integer, а потом считаем произведение:


int numberA = Prompt("Введите число =>");
//System.Console.WriteLine(numberA);
Console.WriteLine($"Произведение от 1 до {numberA} равна {multiplyA(numberA)}");
