//Аналогично 5.0, но с циклом и пятизначным числом.
Console.Clear();
void printArray(int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }

}

Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine();
int numberInt = int.Parse(number);

int[] array = new int[5];
int index = array.Length - 1;

while (numberInt >0)
{array[index]=numberInt%10;// если просто делить на 10, будет просто делить. А так он выписывает остаток от деления на 10 каждый раз
numberInt = numberInt/10;
index--; // за счет минуса мы рразворачиваем последовательность чисел в обратную сторону
};

printArray(array); // видимо, для вывода массива нужна именно такая команда
