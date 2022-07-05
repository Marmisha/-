//Ввести трехзначное число и первратить его в массив
Console.Clear();
void printArray(int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }

}

Console.WriteLine("Введите трехзначное число");
string number = Console.ReadLine();
int numberInt = int.Parse(number);

int[] array = new int[3];

array[0] = numberInt / 100;
array[1] = numberInt % 100 / 10;
array[2] = numberInt % 10;

printArray(array); // видимо, для вывода массива нужна именно такая команда
