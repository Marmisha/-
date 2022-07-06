//Найдите произведение пар чисел в одномерном массиве.
//Парой считается первый и последний элемент, второй и предпоследний и т. д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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



int[] CountPairs(int[] arr)
{
    int[] array = new int[arr.Length/2];// вот тут непонятно, зачем мы вводим полмассива
    int multi = 0;
    for (int i = 0; i < arr.Length/2; i++)
    {
        multi = arr[i] * arr[arr.Length - i-1];
        array[i]=multi;
    }
    return array;
}

int[] myArray = CreateAndFillArray(4, 0, 10);
printArray(myArray);
int[] newArray = CountPairs(myArray);
printArray(newArray);

