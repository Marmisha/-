// Напишите программу, которая на вход приннимает число и проверяет, кратно ли оно одновременно и 7 и 23.
Console.Clear();
Console.Write("Напишите число: ");
string num = Console.ReadLine();
int numInt = int.Parse(num);
Console.Write("Ваше число: " + numInt + ". ");
if (numInt % 7 == 0 && numInt   % 23 ==0)  Console.WriteLine($"{numInt} кратно 7 и 23");
else Console.WriteLine($"Ваше число {numInt} не кратно одновременно 7 и 23.");