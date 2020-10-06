using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seed_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList whoKnows = new LinkedList();
            whoKnows.addToEnd("re");
            whoKnows.addToEnd("mi");
            whoKnows.addToEnd("fa");
            whoKnows.addToFront("do");
            whoKnows.addToEnd("so");

            Console.Clear();
            Console.WriteLine("Options:");
            Console.WriteLine("1) Show Head (S)");
            Console.WriteLine("2) Add item (A)");
            Console.WriteLine("3) Remove Item (R)");
            Console.WriteLine("4) Search for Item(I)");
            Console.WriteLine("5) Print (P)");
            Console.WriteLine("6) Exit (E)");
            Console.Write("\r\nSelect an option: ");
            ConsoleKeyInfo Choice = Console.ReadKey();
            if(Choice.Key == ConsoleKey.S)
            {
                whoKnows.getFirst();
            }
            else if(Choice.Key == ConsoleKey.A)
            {
                string newItem = Console.ReadLine();
                if(! string.IsNullOrEmpty(newItem))
                    whoKnows.addToEnd(newItem);
            }
            else if(Choice.Key == ConsoleKey.R)
            {
                whoKnows.Remove();
            }
            else if(Choice.Key == ConsoleKey.I)
            {
                Console.WriteLine("Type in what you want to search for: ";
                whoKnows.Contains(Console.ReadLine());
            }
            else if(Choice.Key == ConsoleKey.P)
            {
                whoKnows.Print();
            }
            else if(Choice.Key == ConsoleKey.E)
            {
                Environment.Exit(0);
            }

        }
    }
}
