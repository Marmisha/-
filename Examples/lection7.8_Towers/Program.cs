//Пирамидки

void Towers(string from = "1", string to = "3", string anotherOne = "2", int count = 5)
// 1 - откуда берем блинчики; 3 - куда кладем блинчики; 
//2 - просто еще один шпиль; count - кол-во блинов
{
    if (count > 1) Towers(from, anotherOne, to, count - 1);
    Console.WriteLine($"{from} >> {to}");
    if (count > 1) Towers(anotherOne, to, from, count - 1);
}

Towers();

//Можно поменять count на 4 и посмотреть более масштабное решение