using ToDo_List;

char choice = ' ';

while (choice != 'x')
{
    Console.Clear();

    Console.WriteLine("Hello user!");
    ToDoApp.ShowItems();
    Console.WriteLine();
    Console.WriteLine("a. Add item");
    Console.WriteLine("r. Remove item");
    Console.WriteLine("e. Edit item");
    Console.WriteLine("m. Mark item as done");
    Console.WriteLine("u. Mark item as undone");
    Console.WriteLine("x. Exit");

    choice = Console.ReadKey().KeyChar;
    Console.WriteLine();

    switch (choice)
    {
        case 'a':
            ToDoApp.AddItem();
            break;
        case 'r':
            ToDoApp.RemoveItem();
            break;
        case 'e':
            ToDoApp.EditItem();
            break;
        case 'm':
            ToDoApp.Mark();
            break;
        case 'u':
            ToDoApp.Unmark();
            break;
    } 
}