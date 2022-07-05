/* Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным 
первому. Если число второе не кратно первому, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 16, 4 -> кратно */
Console.Clear();
Console.Write("Введите 2 натуральных числа.");
Console.Write("Первое: ");
string numA = Console.ReadLine();
int numAInt = int.Parse(numA);
Console.Write("Второе: ");
string numB = Console.ReadLine();
int numBInt = int.Parse(numB);
Console.WriteLine($"Наши числа: {numAInt} и {numBInt}");
int div= numAInt%numBInt; // деление с остатком, если 0, значит, нацело
//Console.WriteLine("Результат деления " + div2);
if (div==0) Console.WriteLine("Второе число кратно первому.");
else 
{
    Console.Write("Второе число некратно первому. ");
    int numCInt = numAInt/numBInt;
    //Console.WriteLine("Деление равно " + numCInt);
    //Console.WriteLine("Остаток от деления = " + (numAInt-(numC  Int*numBInt)));
    Console.WriteLine("Остаток от деления = " + (numAInt%numBInt));
    // Console.WriteLine(numAInt - (numCInt*numBInt));