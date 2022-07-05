//Задача 1: 
//Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные и наоборот.
//[-4,-8,8,2] -> [4,8,-8,2]


Console.Clear();

// Метод создания массива с определенной длиной и заполнением рандомными числами из отрезка от в промежутке от a (min) до b (max):
int[] CreateAndFillArray(int large, int min, int max)
{
    int[] array = new int[large];
    for (int ifill = 0; ifill < array.Length; ifill++)
    {
        array[ifill] = new Random().Next(min, max + 1);
    }
    return array;
}



//Метод вывода на экран массива:
void printArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]}   ");
    }
    System.Console.WriteLine();


}



//Делаем инверсию всех значений по знаку, не вникая, положительные они или отрицательные, нам надо поменять все на противоположный знак:
int[] InverseNumberSign(int[] Arr)
{
    for (int i = 0; i < Arr.Length; i++)
    {
        Arr[i] = Arr[i] * (-1);


    }
    return Arr;
}



int[] myArray = CreateAndFillArray(5, -9, 9);
printArray(myArray);
InverseNumberSign(myArray);
printArray(myArray);