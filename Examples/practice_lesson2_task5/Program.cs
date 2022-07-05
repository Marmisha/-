// Ввести 3 числа и превратить эту последовательность в массив.
Console.Clear();
Console.WriteLine("Введите 3 числа.");
Console.Write("Первое: ");
string numA = Console.ReadLine();
int numAInt = int.Parse(numA);

Console.Write("Второе: ");
string numB = Console.ReadLine();
int numBInt = int.Parse(numB);

Console.Write("Третье: ");
string numC = Console.ReadLine();
int numCInt = int.Parse(numC);

Console.Write("Наши числа: " + numAInt + numBInt + numCInt);
int[] array = new int [3];
array[0] = numAInt;
array[1] = numBInt;
array[2] = numCInt;
Console.WriteLine(array);
