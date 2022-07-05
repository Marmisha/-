// Напишите программу, которая по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти (x и y).
// x от 0 до бесконечности попадает....

int Prompt(string message)
{
    Console.WriteLine(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}
//int x = Prompt("Введите x => ");
//int x = Prompt("Введите y => ");
  
int quater = Prompt("Введите номер четверти => ");

if (quater == 1){
    Console.Write("Значения x > 0, y > 0");
}
if (quater == 2){
    Console.Write("Значения x < 0, y > 0");
}
if (quater == 3){
    Console.Write("Значения x < 0, y < 0");
}
if (quater == 4){
    Console.Write("Значения x > 0, y < 0");
}