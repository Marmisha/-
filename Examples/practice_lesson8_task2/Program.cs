// Семинар 8 задача 2
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа выводит сообщение для пользователя.


Console.Clear();



int GetIntFromReadLine(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}



int[,] CreateMatrix(int row, int column, int min, int max)
{
    var matrix = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}



void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j] + "\t"}");
        }
        Console.WriteLine();
    }
}



int[,] TransposeMatrix(int[,] array)
{
    // int lastRowIndex = array.GetLength(0) - 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++) // j=i, чтобы каждая следующая строка сдвигалась
        {
            int temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
    }
    return array;
}



int row = GetIntFromReadLine("Введите число строк и столбцов массива: ");
int column = row;
int min = GetIntFromReadLine("Введите минимальное значение для чисел массива: ");
int max = GetIntFromReadLine("Введите максимальное значение для чисел массива: ");

int[,] myMatrix = CreateMatrix(row, column, min, max);
System.Console.WriteLine("Исходный массив: ");
PrintMatrix(myMatrix);

int[,] transposedMatrix = TransposeMatrix(myMatrix);
System.Console.WriteLine("Транспонированный массив: ");
PrintMatrix(transposedMatrix);