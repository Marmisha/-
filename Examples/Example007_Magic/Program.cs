Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");
int xa = 1, ya = 1, 
    xb = 1, yb = 30,
    xc = 100, yc = 30;
Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");    
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");
// выбираем 2 точки:
int x=xa, y=xb;
int count = 0; // определяем счетчик count, пока что он равен нулю
// пишем цикл:
while(count<10000) // пусть выполняется до 10 000 раз
{//генерируем случайное число:
    int what =new Random().Next(0,3); //[0;3), т.е. 0, 1, 2
// пишем условие:
    if (what == 0)
    {
    x=(x+xa)/2;
    y=(y+ya)/2;
    }
    
    if (what == 1)
    {
    x=(x+xb)/2;
    y=(y+yb)/2;
    }
    
    if (what == 2)
    {
    x=(x+xc)/2;
    y=(y+yc)/2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+"); // чтобы цикл не ушел в бесконечность, нам надо показать, что count вообще-то растет:
    count = count + 1; // или можно написать count++
} 