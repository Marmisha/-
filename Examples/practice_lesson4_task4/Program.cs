//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайнм порядке
//Вариант 1
/*
void PrintArray(int[] Ar)
{
    for (int i = 0; i < Ar.Length; i++)
    {
        Console.Write(Ar[i] + " ");
    }
}

int[] array;
array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,2);

}

PrintArray(array);
/*
т.е. мы говорим: иди найди функцию  PrintArray и передай ей параметр array/ и наш array становится Ar (в контексте функции он становится Ar)
*/







/*
//Вариант 2:
void PrintArray(int[] r)
{
    for (int i = 0; i < r.Length; i++)
    {
        Console.Write(r[i] + " ");
    }
}

int[] BinaryArray(int Length)
{
    int[] array;
    array = new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);

    }
    return array;
}

int[] MyArray = BinaryArray(10);
PrintArray(MyArray);
*/






//Вариант 3 + дополнение: метод, считающий сумму всех элементов:
void PrintArray(int[] r)
{
    for (int i = 0; i < r.Length; i++)
    {
        Console.Write(r[i] + " ");
    }
    System.Console.WriteLine();
}

int[] BinaryArray(int Length)
{
    int[] array;
    array = new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);

    }
    return array;
}

//Вот тут новое условие
int SumArray (int[] Array) // Arr - названеи, которое будет использоваться только в цикле
{
    int sum=0;
    for (int i = 0; i < Array.Length; i++)
    {
        sum = sum + Array[i];
    } // а теперь, посколкьу это не void, надо что-то вернунть:
    return sum;
}

int[] MyArray = BinaryArray(10);
PrintArray(MyArray);
System.Console.WriteLine("Сумма чисел массива равна " + SumArray(MyArray));