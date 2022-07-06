//Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
//Пример для массив аиз 5, а не 123 элементов. В своем решении сделайте для 123.
//[5,18,123,6,2]->1
//[1,2,3,6,2]->0
//[10,11,12,13,14]->5

Console.Clear();
// Метод создания массива с определенной длиной и заполнением рандомными числами из отрезка от в промежутке от a (min) до b (max):
int[] CreateAndFillArray(int large, int min, int max)
{
    int[] array = new int[large];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}



// Метод вывода на экран массива:
void printArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]}   ");
    }
    System.Console.WriteLine();
}



void SearchNum(int[]arr)
{
    int count = 0;
    for (int i=0; i< arr.Length; i++)
    {
        if (arr[i]>9 && arr[i]<100)
        {
            count++;

        }
    }
    System.Console.WriteLine($"Количество элементов в диапазоне от 10 до 99 в заданном массиве равно {count}.");
}


int[] myArray = CreateAndFillArray(123, -100, 100);
printArray(myArray);
SearchNum(myArray);