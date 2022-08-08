// Семинар 10 задача 1
// В некотором машинном алфавите имеются четыре буквы "а", "и", "с" и "в".
// Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита.
// n = 2-> аа, ии, сс, вв, аи, иа, ис, си, ас, са, ав, ва, ви, ив, св, вс



Console.Clear();



long GetIntFromReadLine(string message)
{
    Console.Write(message);
    long numInt = long.Parse(Console.ReadLine());
    return numInt;
}



// Метод выводящий на печать все слова заданной длины, состоящие из заданного "алфавита":
void PrintAllWordsOfSpecialLength(string[] array, string pref, int count = 4) // 4 - потому что вверх идем
{
    if (count == 0)
    {
        System.Console.WriteLine(pref);
        return;
    }
    for (int i = 0; i < 4; i++)
    {
        PrintAllWordsOfSpecialLength(array, pref + array[i], count - 1);
    }
}



string[] alphabet = new string[] { "а", "и", "с", "в" };
PrintAllWordsOfSpecialLength(alphabet, "", 4); // "" вмемто преф



