using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_List
{
    internal static class ToDoApp
    {
        static List<ToDoItem> ToDoList = new List<ToDoItem>();

        static public void ShowItems() 
        {
            Console.WriteLine("Amount of elemets: " + ToDoList.Count);

            for (int i = 0; i<ToDoList.Count; i++)
            {
                ToDoItem item = ToDoList[i];
                Console.WriteLine((i+1) + ") " + item.text + (item.done? " [X]" : " [ ]"));
            }
        }
        static public void AddItem() 
        {
            Console.WriteLine("Enter text for new item:");
            string text = Console.ReadLine();

            ToDoList.Add(new ToDoItem(text, false));
        }
        public static void RemoveItem() 
        {
            Console.WriteLine("Enter number of element you want to remove: ");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;

            ToDoList.RemoveAt(index);
        }
        public static void EditItem() 
        {
            Console.WriteLine("Enter number of element you want to edit: ");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.WriteLine("Enter new text: ");
            string text = Console.ReadLine();

            ToDoList.Insert(index, new ToDoItem(text, ToDoList[index].done));
            ToDoList.RemoveAt(index+1);
        }
        public static void Mark() 
        {
            Console.WriteLine("Enter number of element you want to mark as done: ");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;

            ToDoList[index].done = true;
        }
        public static void Unmark() 
        {
            Console.WriteLine("Enter number of element you want to mark as undone: ");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;

            ToDoList[index].done = false;
        }
    }
}
