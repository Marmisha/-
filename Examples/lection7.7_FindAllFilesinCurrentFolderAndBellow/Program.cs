//Поиск всех файлов в папке (и подпапках):
void CatalogInfo(string path, string indent = "") // два аргумента: путь и так называемые отступы, чтобы вмидеть структуру папки
{
    DirectoryInfo catalog = new DirectoryInfo(path); // получаем инфу о директории, куда зашли
    
    DirectoryInfo[]catalogs = catalog.GetDirectories();
        for (int i=0; i<catalogs.Length; i++) // получаем массив всех файлов в директории
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}"); // пробегаем по файлам, выводя инфомрацию обо всех файлах в текуйщей папке
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }

    FileInfo[] files = catalog.GetFiles();

    for (int i=0; i<files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}
string path = @"C:/Users/User/Documents/GeekBrains/C sharp/Examples/Examples";
CatalogInfo(path);

