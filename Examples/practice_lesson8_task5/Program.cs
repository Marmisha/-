// Спеминар 8_Задача 5 (что-то не так, лекция https://gb.ru/lessons/240588 2:38)
// Вывести первые N строк треугольника Паскаля. 
// Сделать вывод в виде равнобедренного треугольника.


Console.Clear();

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == 0) { System.Console.Write("\t"); } // игнорирование нулей
            else
            {
                System.Console.Write($"{matrix[i, j]}" + "\t");
            }
        }
    }
}



void Pascal(int N)
{
    int[,] massive = new int[N, 2 * N - 1];
    massive[0, N - 1] = 1;
    for (int i = 1; i < N; i++)
    {
        for (int j = 0; j < 2*N-1; j++)
        {
            if (i == 0) { massive[i, j] = massive[i - 1, j + 1]; }
            if (j == 2 * N - 1 - 1) { massive[i, j] = massive[i - 1, j - 1]; }
            if (j > 0 && j < 2 * N - 1 - 1) { massive[i, j] = massive[i - 1, j - 1] + massive[i - 1, j + 1]; }
           // System.Console.WriteLine((i + " " + j));
        }
        PrintArray(massive);
    }
}

Pascal(5);

