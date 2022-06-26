﻿Console.Clear();

//Индексы меняются от 0 как для строк, так и для столбцов.
string[,] table = new string[2, 5]; // от двух включительно до 4
// String.Empty; // для строк иницилизация происходит  такой константой
// table [0,0] table [0,1] table [0,2] table [0,3] table [0,4]
// table [1,0] table [1,1] table [1,2] table [1,3] table [1,4]

/*table[1, 2] ="слово";

// теперь сделаем циклы, чтобы распечатать массив:
for (int rows = 0; rows < 2; rows++)
{
	for (int columns  = 0; columns < 5; columns++)
	{
	Console.WriteLine($"-{table[rows, columns]}-");
	}
}
*/










/*
int [,] matrix = new int[3,4];
for (int i = 0; i < matrix.GetLength(0); i++) //  (0) - количнество строк, первый параметр таблицы, т. е. 3
{
	for (int j  = 0; j < matrix.GetLength(1); j++) // (1) - количнество столбцов, второй параметр таблицы, т. е. 4
	{
	Console.Write($"{matrix[i, j]}");
	}
Console.WriteLine
*/










/*
//Теперь с помощью метода и рандома:
//int [,] matrix = new int [3,4];  ее можно внизу после метода ,как и написали в итоге:
void PrintArray(int[,] matr) //matr новое имя специально
{
    for (int i = 0; i < matr.GetLength(0); i++) //  (0) - количнество строк, первый параметр таблицы, т. е. 3
    {
        for (int j = 0; j < matr.GetLength(1); j++) // (1) - количнество столбцов, второй параметр таблицы, т. е. 4
        {
            Console.Write($"{matr[i, j]}");
        }
        Console.WriteLine();
    }
}
// теперь у нас метод PrintArray принмает в качестве аргумента принимает двумерную таблицу чисел и печатает ее на экран

// Итак мы написали метод, который выводит на печать табличку заданной размерности. Теперь добавим доп метод,который будет заполнять ее рандомными значениями:
void FillArray(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10 );// пусть заполняется рандомными числами от 1 (вкл) до 9(вкл), [1, 10) как бы		}
		}
	}
}

int[,] matrix = new int [3,4];
PrintArray (matrix); // проверка, что массив в принципе выходит на печать
 FillArray(matrix); // заполнение имеющегося массива
PrintArray(matrix); // вывод на печать массива срамндомными числами от 1 до 9 вкл
*/










/*
int[,] pic = new int[,] // необязательно указывать значения, если у нас есть конкретные данные, как здесь:
{
{0,0,0,0,0,0,0,0,0,0,1,1,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0,0,1,0,0,1,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0,0,1,0,0,1,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0},
{0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0},
{0,0,0,0,0,1,1,0,0,0,0,1,0,0,0,0,0,0,0},
{0,0,0,1,1,0,0,0,0,0,1,0,0,0,0,0,0,0,0},
{1,1,1,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,0},
{1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
{1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
{1,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,0},
{1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
{1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
{1,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,0},
{1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0},
{1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0},
{1,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,0},
{1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0},
{0,0,0,0,1,1,1,1,0,0,0,0,0,0,0,1,0,0,0},
{0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,0,0,0,0},
};
void PrintImage(int [,] image) // используем тот же метод. но чуть переделаем для "смотрибельности" картинки
{
	for (int i = 0; i < image.GetLength(0); i++)
	{
		for (int j=0; j< image.GetLength(1); j++)
		{
			//Console.Write($"{image[i,j]}"); // будем не просто выводить, а при 0 печатать пробел
			if (image[i,j]==0) Console.Write($" ");
			else Console.Write($"+"); // если бы было больше условий, было бы else if .... 
		}
		Console.WriteLine();
	}
}
PrintImage(pic);
//Теперь напишем метод для заполнения картинки:
void FillImage(int row, int col) // в качестве аргументов будут позиции строки и столбца пикселя, с которого мы начинаем красить
{
	if(pic[row, col] ==0)
	{
		pic[row, col]=1;
		FillImage(row-1,col);
		FillImage(row, col-1);
		FillImage(row+1,col);
		FillImage(row, col+1);
	}
}

PrintImage(pic); //печатаем изначальный вариант рисунка 
FillImage(13,13); // определяем наобум точку внутри замкнутого контура рисунка, с которой хотим начать красить 
PrintImage(pic); // красим
*/









/*
int Factorial (int n)
{
	if (n==1) return 1; // потмоу что в общем порядке факториал единички (и 0, кстати, тоже) - это единичка
	else return n*Factorial(n-1);
}
Console.WriteLine(Factorial(3)); //Тут указываем число, от которого считаем факториал,сейчас это 3. Тогда: 1*2*3=6
*/










/*
double Factorial (int n)
{
	if (n==1) return 1; // потмоу что в общем порядке факториал единички (и 0, кстати, тоже) - это единичка
	else return n*Factorial(n-1);
}
for (int i=1; i<40; i++)
Console.WriteLine($"{i}! = {Factorial(i)}");
*/









//Числа Фибоначчи
//f(1) = 1
