// Вывести массив, посчитать сумму обеих диагоналей, 
// если суммы равны, добавляем ко всему массиву по единичке

int InputNumber(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}


//Создание массива заданной размерности с заданными минимум и мксимумом для чисел:
int[,] CreateArray(int row, int column, int min, int max)
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


//Вывод на экран массива:
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}


//Подсчет суммы всех чисел по первой диагонали массива:
(int, int) SumOfDiagonals(int[,] array)
{
    int countofDiagonal1 = 0;
    int countofDiagonal2 = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j) countofDiagonal1 += array[i, j];
        }
    }
    int k = array.GetLength(1) - 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        countofDiagonal2 += array[i, k];
        k--;
    }
    return (countofDiagonal1, countofDiagonal2);
}

int row = InputNumber("Введите число строк: ");
int column = InputNumber("Введите число столбцов: ");
int min = 0;
int max = 10;
int[,] array = CreateArray(row, column, min, max);
PrintArray(array);

System.Console.WriteLine();
(int countofDiagonal1, int countofDiagonal2) = SumOfDiagonals(array);
System.Console.WriteLine($"Сумма элементов диагоналей равна {countofDiagonal1 + countofDiagonal2}");