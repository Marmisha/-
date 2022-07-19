// Задайте двумерный массив. Введите элемент и найдите его первое вхождение.
// Выведите позиции по горизонтали и вертикали или напишите, что такого элемента нет.

Console.Clear();
int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] GenerateArray(int row, int column, int min, int max)
{
    var array = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}



void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            System.Console.Write(array[i, k] + "\t");
        }
        System.Console.WriteLine();
    }
}








(int, int) FinfingElementPosition(int[,] array, int num)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == num) return (i, j);
        }
    }
    return (-1, -1);
}

int row = Prompt("Введите число строк: ");
int column =  Prompt("Введите число столбцов: ");
int min = 0;
int max = 10;
int[,] array = GenerateArray(row, column, min, max);
PrintArray(array);
System.Console.WriteLine();

int num = Prompt("Введите число: ");
(int rowPosition, int columnPosition) = FinfingElementPosition(array, num);
if (rowPosition == -1) System.Console.WriteLine("нет такого числа");
else System.Console.WriteLine($"Индекс числа: ({rowPosition}, {columnPosition}), позиция числа (строка: {rowPosition + 1}, столбик: {columnPosition + 1})");