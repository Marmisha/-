void FillArray(int[]collection) // void - метод. Елси метод ничего не возвращает, то он void, return не нужен. retutn был в поиске максимума из трех чисел

{
    int length=collection.Length; 
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}   

void PrintArray (int[]col) // другие названия для по сути тех же вещей для привыкания давать понятные, разные имена
{
    int count = col.Length; // та же длина массива
    int position = 0; // тот же счетчик
     while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}


int [] array = new int [10]; // new int  - создание нового массива с 10 элементами (по умолчанию - нулями)

FillArray(array); // метод для заполнения массива
PrintArray(array);