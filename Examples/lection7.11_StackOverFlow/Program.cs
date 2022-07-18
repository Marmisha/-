// StackOverFlow (академически бесполезная, но наглядная 
//в плане переполнения стека рекурсия)
/*
void Rec()
{
    Rec();
}
Rec();
*/


// StackOverFlow вар 2:
int i=0;
void Rec()
{
    System.Console.WriteLine(i++);
    Rec();
}
Rec();
// тоже ошибка, которая "кладет" программу, переполняя стек.