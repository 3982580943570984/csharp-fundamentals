namespace Studying;

/*
 
В лабораторной работе требуется определить класс, содержащий 
типизированную коллекцию, который с помощью событий извещает 
об изменениях в коллекции. Для событий, извещающих об изменениях
в коллекции, определяется пользовательский тип делегат. События 
регистрируются в специальных классах-слушателях.

Сформировать коллекцию элементов в соответствии с заданием. 
Организовать добавление, удаление элементов в коллекцию. 
Вывести содержимое коллекции элементов на экран пользователю.
 
 */
internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm());
    }
}