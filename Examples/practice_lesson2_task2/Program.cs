//Напиши программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
Console.Clear(); 
int number = new Random().Next(10,99);
Console.WriteLine($"Рандомное число: {number}");
int numberFirst = (number / 10);
int numberSecond = (number % 10);
Console.WriteLine($"Первая цифра числа: {numberFirst}");
Console.WriteLine($"Вторая цифра числа: {numberSecond}");

if (numberFirst==numberSecond)
  {
    Console.WriteLine("Числа равны, они же максимальные");
  }
  else
  { 
if (numberFirst>numberSecond)
    {
        Console.WriteLine($"Наибольшая цифра числа: {numberFirst}");

    }
    else 
    {
        Console.WriteLine($"Наибольшая цифра числа: {numberSecond}");
    }

  }