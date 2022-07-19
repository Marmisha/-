// Задайте двумерный массив. Найдите сумму элементов главной диагонали.


//Считывание введенного пользователем числа:
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



//Подсчет суммы всех чисел по диагонали массива:
int SumOfDiagonalNumbers(int[,] array)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            if (i == j) count += array[i, j];
        }
    }
    return count;
}



int row = InputNumber("Введите число строк: ");
int column = InputNumber("Введите число столбцов: ");
int min = 0;
int max = 10;
int[,] array = CreateArray(row, column, min, max);
PrintArray(array);
System.Console.WriteLine();
int result = SumOfDiagonalNumbers(array);
System.Console.WriteLine("Сумма элементов главной диагонали равна " + result);