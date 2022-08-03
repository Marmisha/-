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


// Метод, который ищет в массиве элемент с самым маленьким значением:
int FindMinElement(int[,] array)
{
    int min = array[0, 0];
    foreach (int element in array)
    {
        if (element < min)
        {
            min = element;
        }
    }
    return min;
}



// Метод, который ищет координаты (индексы) местоположения конкретного числа:
(int, int) FindIndexByElementInCross(int[,] array, int value)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == value)
            {
                return (i, j);
            }
        }
    }
    return (0, 0);
}


// Метод, удаляющий заданные строку и столбец из массива
int[,] DeleteRowAndColumnInCross(int[,] array2, int row, int column)
{
    int[,] newMatrix = new int[array2.GetLength(0) - 1, array2.GetLength(1) - 1];
    int k = 0;
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        int l = 0;
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            if ((i != row) && (j != column)) //проверка на вычеркивание колонки (строки?)
            {
                newMatrix[k, l] = array2[i, j];
                l++;

            }
        }
        if (i != row)
        {
            k++;
        }
    }
    return newMatrix;
}



int row = GetIntFromReadLine("Введите число строк массива: ");
int column = GetIntFromReadLine("Введите число столбцов массива: ");
int min = GetIntFromReadLine("Введите минимальное значение для чисел массива: ");
int max = GetIntFromReadLine("Введите максимальное значение для чисел массива: ");

int[,] myMatrix = CreateMatrix(row, column, min, max);
System.Console.WriteLine("Исходный массив: ");
PrintMatrix(myMatrix);
System.Console.WriteLine();

int minElement = FindMinElement(myMatrix);
System.Console.WriteLine($"Элемент с минимальным значением: {minElement}");
System.Console.WriteLine();

System.Console.WriteLine("Массив, сокращенный на строку и столбец, содержащие минимальный элемент:");
(int row2, int column2) = FindIndexByElementInCross(myMatrix, FindMinElement(myMatrix));
PrintMatrix(DeleteRowAndColumnInCross(myMatrix, row2, column2));
