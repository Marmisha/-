// Лекция 6, пример 1
// Есть строка, в которой находятся координаты (парные) точек фигуры, нам надо каждую координату увеличить в два раза и показать результат.

/* Если нам нужно оставить возможность править координаты в дальнейшем:
using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)"
            .Replace("(", "")
            .Replace(")", "")
            ;
System.Console.WriteLine(text);

var data = text.Split(" ")
                .Select(item => item.Split(',')) // и получим массив массивов
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))
                .ToArray();//  команда, разделяющая данные по заданному символу
for (int i = 0; i < data.Length; i++)
{
    System.Console.WriteLine(data[i]);
    System.Console.WriteLine(" => с умножением: (" + data[i].x*10 + " , " + data[i].y*10+")");
    Console.WriteLine();
}
*/





// Если нам нужно умножить лишь один раз и больше координаты не пригодятся:
using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)" // возьмем текст
            .Replace("(", "") // найдем скобочку и заменим на ничто
            .Replace(")", "") // найдем другую скобочку и заменим на ничто
            ;
System.Console.WriteLine(text);

var data = text.Split(" ") // возьмем текст и разделим по делителю (если навести мышь, там подсказку)
                .Select(item => item.Split(','))
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))
                .Where(e=> e.x%2==0) // если координата кортежа четная
                // так мы получим набор четных координат, котоырые уже будем домножать на 10
                .Select(point => (point.x * 10, point.y * 10))
                .ToArray();
for (int i = 0; i < data.Length; i++)
{
    System.Console.WriteLine(data[i]);

}