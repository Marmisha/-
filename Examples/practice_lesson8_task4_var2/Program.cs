// Семинар 8 задача 4:
// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива

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


// Метод, который ищет в массиве координаты элемента с самым маленьким значением
int[] MinimalElementPosition(int[,] matrix)
{
    int[] coordinates = new int[2];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < matrix[coordinates[0], coordinates[1]])
            {
                coordinates[0] = i;
                coordinates[1] = j;
            }
        }
    }
    return coordinates;
}



//Метод удаления строки массива:
int[,] RemoveRowFromMatrix(int[,] matrix, int minElRow)
{
    int[,] cutRowMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            if (i < minElRow) { cutRowMatrix[i, j] = matrix[i, j]; }
            if (i > minElRow) { cutRowMatrix[i - 1, j] = matrix[i, j]; }
        }
    }
    return cutRowMatrix;
}



//Метод удаления столбца массива:
int[,] RemoveColumnFromMatrix(int[,] matrix, int minElColumn)
{
    int[,] cutColumnMatrix = new int[matrix.GetLength(0), matrix.GetLength(1) - 1];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < minElColumn) { cutColumnMatrix[i, j] = matrix[i, j]; }
            if (j > minElColumn) { cutColumnMatrix[i, j - 1] = matrix[i, j]; }
        }
    }
    return cutColumnMatrix;
}



int row = GetIntFromReadLine("Введите число строк массива: ");
int column = GetIntFromReadLine("Введите число столбцов массива: ");
int min = GetIntFromReadLine("Введите минимальное значение для чисел массива: ");
int max = GetIntFromReadLine("Введите максимальное значение для чисел массива: ");

int[,] myMatrix = CreateMatrix(row, column, min, max);
System.Console.WriteLine("Исходный массив: ");
PrintMatrix(myMatrix);
System.Console.WriteLine();


int[,] cutRowMatrix = RemoveRowFromMatrix(myMatrix, MinimalElementPosition(myMatrix)[0]);
System.Console.WriteLine("Массив с удаленной строкой, содержащей минимальное значение: ");
PrintMatrix(cutRowMatrix);

int[,] finalMatrix = RemoveColumnFromMatrix(cutRowMatrix, MinimalElementPosition(myMatrix)[1]);
System.Console.WriteLine("Массив с удаленным столбцом, содержащим минимальное значение: ");

PrintMatrix(finalMatrix);
