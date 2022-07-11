// Задача: напишите программу, которая будет преобразовывать десятичное число в двоичное.

Console.Clear();

/*
//Читерский метод:
int MethodIntFromReadLine(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    int numInt = int.Parse(number);
    return numInt;
}

int number = MethodIntFromReadLine("Введите число: ");
Console.WriteLine($"Вы ввели {number}.");

string binary = Convert.ToString(number, 2);
System.Console.WriteLine(binary);
*/

//Нормальный метод:
int MethodIntFromReadLine(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    int numInt = int.Parse(number);
    return numInt;
}



int[] ToBinary(int num) // метод съедает введенную пользователем переменную
{
    int temp = num; 
    int count = 0;
    while (temp > 0) // цикл считает, сколько раз наше число поделится на 2, пока не станет равно 0 (записываем это количество в count)
    {
        temp = temp / 2;
        count++; // 
    }
    int[] arr = new int[count];
    for (int i = 0; i < arr.Length; i++) // теперь for заполнит массив (идем с конца, вспоминаем метод деления столбиком)
    {
        arr[arr.Length - 1 - i] = num % 2;
        num = num / 2;
    }
    return arr;
}



void printArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]}   ");
    }
    System.Console.WriteLine();
}


int number = MethodIntFromReadLine("Введите число: ");
Console.WriteLine($"Вы ввели {number}.");
printArray(ToBinary(number));
