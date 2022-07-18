string emp = String.Empty;// emp используется для косметики: чтобы вся строка помещалась без лишнего скрола
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
// 0 1 2 3 4 5 6 7 8 9 10 11

void InOrderTraversal(int pos = 1) // метод, позволяющий делать обход
{
    if (pos < tree.Length) // если позиция вылетела за кол-во элементов/узлов в дереве
    {
        int left = 2 * pos; //позиция левог оподдерева
        int right = 2 * pos + 1; // позиция правого поддерева
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left); // если существует левое поддерева и элемкент в нем не пустой, то надо запусить обход этого дерева с текущей позиции рекурсивно 
        Console.WriteLine(tree[pos]); // выводим узел конкретный 
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right); // аналогично для правого поддерева
    }
}

InOrderTraversal();
