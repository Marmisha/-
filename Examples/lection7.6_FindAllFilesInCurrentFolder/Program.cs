// Поиск даты создания папки по его местонахождению:
string path = "C:/Users/User/Documents/GeekBrains/C sharp/Examples/Examples";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);
FileInfo [] fi=di.GetFiles();


//Поиск всех файлов в текущей папке:
for(int i =0; i<fi.Length; i++) // найдем все файлы в папке
{
    System.Console.WriteLine(fi[i].Name);
}


//Теперь  напишем рекурсию, которая пробежится по папкам и посмотрит, что в них есть (следующий task)
