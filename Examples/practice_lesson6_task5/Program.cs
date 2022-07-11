// Задача: напишите задачу, которая будет создавать копию заданного массива с помощтю поэлементного копирования:

Console.Clear();


int[] CreateAndFillArray(int len, int min, int max)
{Random rnd= new Random();
        int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(min, max+1);
    }
    return arr;
}




void printArray(int[] arr)
{
    foreach (int element in arr)
    {
        System.Console.Write($"{element};   ");
    }
    System.Console.WriteLine();
}




int[] CopyArray(int[] arr)
{
    int[] arr1 = new int[arr.Length];
    for (int i=0; i<arr.Length; i++)
    {
        arr1[i] = arr[i];
    }
    return    arr1;
     }


int [] myArray =CreateAndFillArray(5,1,10);
System.Console.Write("Первоначальный массив: ");
printArray(myArray);
int [] myCopiedArray = CopyArray(myArray);
System.Console.Write("Копия массива: ");
printArray(myCopiedArray);





