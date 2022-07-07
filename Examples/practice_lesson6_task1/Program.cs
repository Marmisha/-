// Задача 1: Напишите программу, котора перевернет одномерный массив.
// [12345]->[54321]
// [6736]->[6376]
Console.Clear();

int[] CreateArray(int len, int min, int max)
{
    var array = new int[len]; // тут к var не нужны скобочки, он сам определяет тип переменной
    var rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}


void PrintArray(int[] array)
{
    foreach (int e in array)
    {
        System.Console.Write(e + " ");
    }
}


//Переворот массива (1 вариант: убивает исходный массив, но легкий в обработке):
int[] ReverseArray(int[] array)
{
    for (var i = 0; i < array.Length / 2; i++)
    {
        var tmp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = tmp;

    }
    return array;
}

/*
int[] myArr = CreateArray(4, 1, 10);
PrintArray(myArr);
System.Console.WriteLine();
PrintArray(ReverseArray(myArr));
*/
// скопировано ниже

// Если полученный массив нам далее не нужен, можем оставить так, 
// если же нужен, переделываем метод:
//Переворот массива (2 вариант: с сохранением исходного массива, но в два раза больше памяти занимает):

int[] ReverseCopyArray(int[] array)
{
    int[] reverse = new int[array.Length];
    for (var i = 0; i < array.Length; i++)
    {
        reverse[array.Length - 1 - i] = array[i];

    }
    return reverse;
}


int[] myArr = CreateArray(4, 1, 10);
System.Console.Write("Исходный массив: ");
PrintArray(myArr);
System.Console.WriteLine();

System.Console.Write("Реверс копи: ");
PrintArray(ReverseCopyArray(myArr));
System.Console.WriteLine();

System.Console.Write("Исходный массив: ");
PrintArray(myArr);
System.Console.WriteLine("- проверка, что исходник не испорчен");
System.Console.WriteLine();

System.Console.Write("Реверс: ");
PrintArray(ReverseArray(myArr));
System.Console.WriteLine();

System.Console.Write("Исходный массив: ");
PrintArray(myArr);
System.Console.WriteLine("- исходник испорчен");
System.Console.WriteLine();
