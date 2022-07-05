//Задача 2: Задайте массив. напишите программу, которая определяет, присутствует ли данное число в массиве.
//4; массив [6,7,19,345,3] ->


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



//Метод, который предлагает ввести число, съедает его в виде текста и превращает в integer
int MethodIntFromReadLine(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    int numInt = int.Parse(number);
    return numInt;
}


/*
//Метод поиска заданного (ранее) числа (number)в массиве (вариант 1 с некрасивым выодом итога):
int[] FindNumInArray(int[] Arr, int numToFind)
{
    for (int index = 0; index < Arr.Length; index++) //пока индекс числа массива меньше длины массива, продолжем цикл
    {
        if (Arr[index] == numToFind)
        {
            System.Console.WriteLine($"Заданное число есть в массиве под номером {index + 1}");
            // break;
        }
        else
        {
            //        System.Console.WriteLine($"В {index}-ом элементе массива нет такого числа");
            System.Console.WriteLine($"В {index}-ом элементе массива нет такого числа");
        }
    }
    return Arr;
}
*/



//2 вариант поиска заданного (ранее) числа (number)в массиве через булеву функцию:
bool FindNumInArray(int[] Arr, int numToFind)
{
    for (int index = 0; index < Arr.Length; index++) //пока индекс числа массива меньше длины массива, продолжем цикл
    {
        if (Arr[index] == numToFind)
        {
            System.Console.WriteLine($"Заданное число есть в массиве под номером {index + 1}");
            return true;
        }
        
    }
    return false;  
}

int[] myArray = CreateAndFillArray(10, 0, 10); //Создаем массив
printArray(myArray);// выводим его на экран

int length = myArray.Length; //выясняем длину массива
System.Console.WriteLine($"Длина массива {length} элементов."); // рассказываем об этом на экране


int number = MethodIntFromReadLine("Придумайте число: "); // спрашиваем, какое число искать в массиве
Console.WriteLine($"Будем искать число {number}."); //вот это число


System.Console.WriteLine(FindNumInArray(myArray, number)?"Yes":"No"); // или просто написать System.Console.WriteLine(FindNumInArray(myArray, number)); и в таком виде функция отработает и выдаст true или false



//Если нам не надо считывать число пользователя, еще проще: мы бы убрали метод MethodIntFromReadLine  и просто в методе indNumInArray(myArray, number) - в number указывали число для поиска.