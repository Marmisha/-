//Семинар 8 задача 3
// Составить частотный словарь элементов двумерного массива.Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных. Значения элементов массива 0...9 Для упрощения процесса и уменьшения количества обрабатываемой инфомрации, можно какое-то повторяющееся  принять за определенное число.

Console.Clear();


int GetIntFromReadLine(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}



int[,] CreateMatrix(int row, int column)
{
    var matrix = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 9 + 1);
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

//Частотный словарь:
int[] FrequencyVocabulary(int[,] array)
{
    int[] frecVoc = new int[10];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            frecVoc[array[i, j]]++;
        }
    }
    return frecVoc;
}



void PrintArray(int[] arrA)
{
    for (int i = 0; i < arrA.GetLength(0); i++)
    {
        int element = arrA[i];
        System.Console.WriteLine($"{i} - {element} раз(а); ");
    }
    System.Console.WriteLine();
}



int row = GetIntFromReadLine("Введите число строк и столбцов массива: ");
int column = row;
int[,] myMatrix = CreateMatrix(row, column);
System.Console.WriteLine("Массив: ");
PrintMatrix(myMatrix);
// int [] myFrecVoc = FrequencyVocabulary(myMatrix);
PrintArray(FrequencyVocabulary(myMatrix));