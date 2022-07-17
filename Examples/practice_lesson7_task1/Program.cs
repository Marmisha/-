//Задача 1:  Задайте двумерный массив размеом m * x, заполненный случайными йелфми числами.
// m = 3, n=4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

Console.Clear();


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


int numM = Prompt("Колмчеством строк: ");
int numN = Prompt("Количество столбцов: ");
int min = -10;
int max = 10;
int[,] array = GenerateArray(numM, numN, min, max);
PrintArray(array);