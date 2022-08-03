// Семинар 8_задача 1:
//Задайте двумерный массив. 
// Напишите программу, которая поменяет местами 
// первую и последнюю строку массива.

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



void PrintMatrix(int[,] matrx)
{
    for (int i = 0; i < matrx.GetLength(0); i++)
    {
        for (int j = 0; j < matrx.GetLength(1); j++)
        {
            Console.Write($"{matrx[i, j] + "\t"}");
        }
        Console.WriteLine();
    }
}



int[,] ChangeFirstToLastRowElements(int[,] array)
{
    int lastRowIndex = array.GetLength(0) - 1;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int temp = array[0, i];
        array[0, i] = array[lastRowIndex, i];
        array[lastRowIndex, i] = temp;
    }
    return array;
}



int row = GetIntFromReadLine("Введите число строк массива: ");
int column = GetIntFromReadLine("Введите число столбцов массива: ");
int min = 0; //GetIntFromReadLine("Введите минимальное значение для чисел массива: ");
int max = 10; //GetIntFromReadLine("Введите максимальное значение для чисел массива: ");

int[,] myMatrix = CreateMatrix(row, column, min, max);
PrintMatrix(myMatrix);
System.Console.WriteLine($"Итак, количество строк массива равно {myMatrix.GetLength(0)}. А массив с перевернутыми 1 т последней строкой выглядит вот так: ");

PrintMatrix(ChangeFirstToLastRowElements(myMatrix));