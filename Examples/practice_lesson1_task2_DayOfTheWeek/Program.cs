/* Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> среда; 5 -> пятница. */
Console.Clear();
Console.WriteLine("Какой сегодня по счету день недели?"); // приглашение ко вводу
string dayOfTheWeek = Console.ReadLine();
Console.WriteLine("Вы ввели " + dayOfTheWeek); // приглашение ко вводу
int dayOfTheWeekInt = int.Parse(dayOfTheWeek);
if (dayOfTheWeekInt < 1 | dayOfTheWeekInt > 7)
{Console.WriteLine("В неделе 7 дней, попробуй другое число");
}
if (dayOfTheWeekInt == 3)
{
    Console.WriteLine("Значит, сегодня среда");
}
else 
    if (dayOfTheWeekInt == 5)
    {
    Console.WriteLine("Ура, сегодня пятница!");
    }
    else 
    {
        Console.WriteLine("Извини, чувак, ни среды, ни пятницы");
    }