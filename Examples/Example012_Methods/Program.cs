// Первая группа, которая ничего не принимает и ничего не возвращает

Console.Clear();

/*
void Method1()
{
Console.WriteLine("Автор Marmisha");
}
//Как вызываются такие мкетоды? Ниже:
Method1();//обязательно со скобками, без них не сработает. Для дальнейшей демонстрации комментим вызов метода или вообще всё.
*/




/*
//Вторая группа, которая что-то принмиает и ничег оне возвращает, может принимать какие-то аргументы
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения"); 
// есть еще аргументы именованные, когда мы хотим к конкретному аргумету вывести конкретное сообщение/значение
*/





/*
void Method21(string msg, int count)
{
    int i = 0;
    while (i<count)
    {
        Console.WriteLine(msg);
        i++; 
    }
}
    Method21("Текст", 4);
*/





/*
// Но мы можем явно указывать, какому аргументу какое значенеи присваивать
void Method21(string msg, int count)
{
    int i = 0;
    while (i<count)
    {
        Console.WriteLine(msg);
        i++; 
    }
}
    Method21(msg: "Текст", count: 4);
    //Если мы используем именованные сообщения, необязательно писать их по порядку:
    Method21(count: 4, msg: "Новый текст");
*/




/*
//Третья группа, которая что-то возвращает, ничего не принимая. Если метод что-то возвращает, мы обязательно должны указать тип данных, который ожидаем.
int Method3()
{
    return DateTime.Now.Year; // здесь произошла какая-то работа 
}
int year = Method3(); // в левой части - используем идентификатор переменной и положить нужное значение 
Console.WriteLine(year); // сюда будет положен результат работы
*/



/*
//Самая важная группа методов: что-то принимают и что-то возвращают.
string Method4(int count, string text) // будем строку с компоновать count раз
{
int i = 0;
string result = ""; //  но правильнее написать  string result = String.Empty;

	while (i < count)
    {
	    result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "asdf"); // укладываем в нужную переменную, указываем кол-во повторений и что укладываем
Console.WriteLine(res);
*/



/*
//Method4 с помощью for 
string Method4(int count, string text) 
{
string result = String.Empty; //  но можно написать  string result = "";
for (int i = 0; i<count;i++)
    {
	    result = result + text;
    }
    return result;
}

string res = Method4(10, "asdf"); // укладываем в нужную переменную, указываем кол-во повторений и что укладываем
Console.WriteLine(res);
*/


/*
for (int i = 2;  i<=10; i++) // внешний цикл
{
	for (int j = 2; j <=10; j++)
	{
	Console.WriteLine($"{i} x {j} = {i*j}"); // Интерполяция строк
	}
    Console.WriteLine(); // Разрыв строки
}
// Здесь второй цикл (внутренний) является телом снешнего цикла. Поэтому, когда он отработает, сделаем переход на новой строке
*/




// ===== Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

//Ясна ли задача?

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
+ "ежели бы вас послали вместо нашего милого Винценгероде,"
+ "вы бы взяли приступом согласие прусского короля. "
+ "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             01234
// чтобы получить конкретный символ s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length; // длина строки, 6
    
    for (int i = 0; i < length; i++)
    {
            if(text[i]==oldValue) result = result + $"{newValue}";
            else result = result + $"{text[i]}";
    }
    
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);

Console.WriteLine();
  
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);

Console.WriteLine();

newText = Replace(text, 'С', 'с');
Console.WriteLine(newText);