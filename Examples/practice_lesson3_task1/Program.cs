// Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причем Ч не равно 0 или Y не равно 0 и выдает номер четверти плоскости, 
//в которой находится эта точка.

int Prompt(string message){
    Console.WriteLine(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}
int x = Prompt("Введите X =>");
int y = Prompt("Введите Y =>");

if (x == 0|| y==0){
    Console.Write("Одна из координат равна 0");
}

if (x > 0 && y> 0)
{
    Console.WriteLine("1 четверть");
}
if (x < 0 && y > 0)
{
    Console.WriteLine("2 четверть");
}
if (x < 0 && y < 0)
{
    Console.WriteLine("3 четверть");
}

if (x > 0 && y <  0)
{
    Console.WriteLine("4 четверть");
}