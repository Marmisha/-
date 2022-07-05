// Напишите программу, котора принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
Console.Clear();

int Prompt(string message){
    Console.WriteLine(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}
int x1 = Prompt("Введите координаты первой точки. Первая координата: x1: ");
int y1 = Prompt("y1 => ");
//Console.WriteLine($"Первая точка ({x1}, {y1}).");

int x2 = Prompt("Теперь координаты второй точки. Первая x2:");
int y2 = Prompt("И вторая y2 => ");
//Console.WriteLine($"Вторая точка ({x2}, {y2}).");
Console.WriteLine($"Наши точки ({x1}, {y1}) и ({x2}, {y2}).");
int a = x1-x2;
//Console.WriteLine(a);
int b=y1-y2;
//Console.WriteLine(b);

double d = Math.Sqrt(a*a+b*b); // для функции Math.Sqrt (извлечение квадрата) int не используется, потому что результат - редко целое число
Console.Write($"Расстояние между ними равно {d}.");