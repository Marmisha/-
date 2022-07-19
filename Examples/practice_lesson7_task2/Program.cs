// Задайте двумерный массив размера m на n, каждый элемент
// в массиве находится по формуле: Amin = m + n. Выведите поулченный массив на экран.
// m = 3, n=4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5 

// Ввод числа с консоли:
int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}


//Метод создания массива заданной размерности (столбцы и строки) и из заданного отрезка чисел:
int[,] GenerateArray(int rows, int columns, int min, int max)
{
    var array = new int[rows, columns];
    var rnd = new Random(); // генератор случайных чисел
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            array[i, k] = rnd.Next(min, max);
        }
    }
    return array;
}



void ChangeArray(int[,] array)
{
    for (int i = 1; i < array.GetLength(0); i += 2)
    {
        for (int j = 1; j < array.GetLength(1); j += 2)
        {
            if (i % 2 != 0 && j % 2 != 0) array[i, j] *= array[i, j]; //индекс нечетный, а позиция четная, сдвиг получается 
        }
    }
}


//Вывод массива на экран:
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


int row = Prompt("Колмчеством строк: ");
int column = Prompt("Количество столбцов: ");
int min = -10;
int max = 10;
int[,] array = GenerateArray(row, column, min, max);
PrintArray(array);
System.Console.WriteLine();
ChangeArray(array);
PrintArray(array);