// Напишите программу, которая на вход принмиает число и выдает его квадрат.
Console.WriteLine("Введите число => "); // Приглашение ко вводу
string parametrString = Console.ReadLine(); // Считыввание введенного текстом числа
int parametrInt = int.Parse(parametrString); // Переводим текстовое число в целочисленный формат
Console.WriteLine($"Вы ввели число:  {parametrInt}");// Вывод числа
int result = parametrInt * parametrInt; // Вычисление квадрата
Console.WriteLine($"Результат (квадрат числа {parametrInt}) = {result}"); // Вывод результата

if (result > 20)
{
    Console.WriteLine("Результат " + result + " больше 20");
    Console.WriteLine("Круто же, ну?");
}
else
{
    Console.WriteLine($"Результат {result} меньше 20");
    Console.WriteLine("Маловато будет");   
}
Console.WriteLine("Вот такие пироги");