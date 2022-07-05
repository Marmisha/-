/*
Задача 1: Задавайте массив из 12 элементов, заполненный случайными числами из промежутка [-9,9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/


//Вариант 1 (более громоздкий):
/*
Console.Clear();
int[] InitArray(int len, int min, int max)
{
    Random rnd = new Random();
    int[] arrA = new int[len];
    for (int i = 0; i < len; i++) // тут можно int, а можно var, тогда программа сама выберет нужную переменную
    {
        arrA[i] = rnd.Next(min, max + 1);
    }
    return arrA;
}

void PrintArray(int[] arrA)
{
    for (int i = 0; i < arrA.Length; i++)
    {
        int element = arrA[i];
        Console.Write($"{element}; ");
    }
    Console.WriteLine();
}


int CalcSumPositiveElements(int[] arrA)
{
    int sum = 0;
    foreach (int element in arrA){
        if (element > 0){
            sum += element;
        }
    }
    return sum;
}

int CalcSumNegativeElements(int[] arrA)
{
    int sum = 0;
    foreach (int element in arrA){
        if (element < 0){
            sum += element;
        }
    }
    return sum;
}

int[] myArray = InitArray(12, -9, 9);
int SumPositive = CalcSumPositiveElements(myArray);
PrintArray(myArray);
Console.WriteLine($"Сумма положительных элементов равна {SumPositive}");

int sumNegative = CalcSumNegativeElements(myArray);
PrintArray(myArray);
Console.WriteLine($"Сумма отрицательных элементов равна {sumNegative}");
*/









//Вариант 2 (более унифицированный в части Calc):

Console.Clear();
int[] InitArray(int len, int min, int max)
{
    Random rnd = new Random();
    int[] arrA = new int[len];
    for (int i = 0; i < len; i++) // тут можно int, а можно var, тогда программа сама выберет нужную переменную
    {
        arrA[i] = rnd.Next(min, max + 1);
    }
    return arrA;
}

void PrintArray(int[] arrA)
{
    for (int i = 0; i < arrA.Length; i++)
    {
        int element = arrA[i];
        Console.Write($"{element}; ");
    }
    Console.WriteLine();
}


int CalcSumElements(int[] arrA, int sign = 1) // знач числа будем передавать через sign, по умолчанию, он равен единице
{
    int sum = 0;
    foreach (int element in arrA){
        if (element*sign    > 0){

/* умножаем на знак, т е если sign 1, числа положительные; sign = -1, числа отрицательные. 
Почему условие срабатыввает и для 1, и для -1? Потому что, допустим, у нас число -5, а sign = -1, число будет 5, а 5 > 0, считаем сумму. 
И если 5 и 1 аналогично. 
А вот если у нас -5 и 1 или 5 и -1 - то что?
*/
            sum = sum + element; //sum += element
        }
    }
    return sum;
}


int[] myArray = InitArray(4, -9, 9);
int SumPositive = CalcSumElements(myArray);// =(myArray, 1)
PrintArray(myArray);
Console.WriteLine($"Сумма положительных элементов равна {SumPositive}");

int sumNegative = CalcSumElements(myArray, -1);
PrintArray(myArray);
Console.WriteLine($"Сумма отрицательных элементов равна {sumNegative}");
